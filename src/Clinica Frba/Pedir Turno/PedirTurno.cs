﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.PedirTurno {
    public partial class PedirTurno : Form {

        Profesionales profs = new Profesionales();
        Profesional prof;
        Afiliado afiliado;
        Turnos turnos = new Turnos();

        Agendas agendas = new Agendas();

        Especialidades esps = new Especialidades();

        public bool cerrar = false;

        public PedirTurno(Usuario _usuario) {
            InitializeComponent();
            int tmp = DB.ExecuteCardinal("SELECT TOP 1 afi_id FROM "+DB.schema+"vAfiliado WHERE usu_id="+_usuario.id);
            if (tmp != -1) {
                afiliado = new Afiliado(tmp);
            } else {
                //Si fallo al traer afiliados, es que el usuario no es un afiliado
                MessageBox.Show("Este usuario no tiene un afiliado asociado,\na modo de debug, le vamos a dejar elejir un afiliado");
                miniAfiliado mini = new miniAfiliado();
                if (mini.ShowDialog() != DialogResult.OK)
                    cerrar = true;
                afiliado = mini.afiliado;
            }
        }

        private void Turno_Load(object sender, EventArgs e) {

            //--Cargar profesionales
            FillDgv();

            //--Traer y llenar los listBox
            esps.FillWithAll();
            lbEspecialidades.Items.AddRange(esps.ToList());
        }

        private void FillDgv() {

            //--Limpia lista entidad y la trae aplicando los filtros
            profs.ClearList();
            dgvProfesionales.Rows.Clear();

            profs.FillWithFilter(tbMatricula.Text,
                tbNombre.Text,
                tbApellido.Text,
                "",
                "",
                -1,
                -1,
                "",
                "",
                "",
                lbEspecialidades.SelectedItems,
                Convert.ToInt32(nLimit.Value));

            //--Llena dgv
            foreach (Profesional prof in profs.items) {
                dgvProfesionales.Rows.Add(prof.id, (prof.matricula == -1) ? "Falta cargar" : prof.matricula.ToString(),
                    prof.usuario.apellido + ", " + prof.usuario.nombre, ">>", prof.concatEsps());
            }
        }

        private void dgvProfesionales_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            //--Guardar profesional que clickeo y habilita para seleccionar día
            if (dgvProfesionales.Columns[e.ColumnIndex].Name == "Seleccionar") {
                prof = profs[dgvProfesionales.Rows[e.RowIndex].Cells["id"].Value.ToString()];

                gbProf.Enabled = false;
                gbEspecialidad.Enabled = true;

                //--Cargar lb con especialidades
                cmbEspecialidades.Items.Clear();
                cmbEspecialidades.Items.AddRange(prof.especialidades.ToList());

                //--Traer agenda del elegido y setear min y max date
                DateTime aux = DateTime.Now; //--los igualo así no los agrega al filtro
                agendas.FillWithFilter(prof, aux, aux, -1, "", "");

                dtpDia.MinDate = FuncionesBoludas.GetDateTime();
                if (agendas.items.Count > 0)
                    dtpDia.MaxDate = agendas[0].hasta;

            }
        }

        private void bLimpiar_Click(object sender, EventArgs e) {
            FuncionesBoludas.limpiarControles(gbProf.Controls);
        }

        private void bBuscar_Click(object sender, EventArgs e) {
            FillDgv();
        }

        //--------------ESPECIALIDAD---------
        private void bSiguienteEsp_Click(object sender, EventArgs e) {

            if (cmbEspecialidades.SelectedIndex == -1) {
                MessageBox.Show("Debe elegir una especialidad", "Error");
                return;
            }

            gbEspecialidad.Enabled = false;
            gbDia.Enabled = true;
        }
        private void bVolverEsp_Click(object sender, EventArgs e) {
            gbEspecialidad.Enabled = false;
            gbProf.Enabled = true;
        }

        //--------------DIA---------
        private void bSiguienteDia_Click(object sender, EventArgs e) {

            if (dtpDia.Value.DayOfWeek == DayOfWeek.Sunday) {
                MessageBox.Show("Los domingos no hay atención", "Error");
                return;
            }
            gbDia.Enabled = false;
            gbHorario.Enabled = true;

            turnos.FillForDay(prof, dtpDia.Value);
            lbTurnos.Items.AddRange(turnos.ToList());

        }
        private void bVolverDia_Click(object sender, EventArgs e) {
            gbDia.Enabled = false;
            gbEspecialidad.Enabled = true;
        }

        //--------------HORARIO---------
        private void bVolverHorario_Click(object sender, EventArgs e) {
            lbTurnos.Items.Clear();
            turnos.ClearList();
            gbDia.Enabled = true;
            gbHorario.Enabled = false;
        }
        private void bFinalizar_Click(object sender, EventArgs e) {
            int agenda = DB.ExecuteCardinal("SELECT TOP 1 age_id FROM " + DB.schema + "semanal " +
                                       "JOIN " + DB.schema + "agenda ON age_id = sem_agenda " +
                                       "WHERE age_profesional= " + prof.id + " AND " +
                                        "sem_dia=" + (int)(dtpDia.Value.DayOfWeek + 1) % 7 + " AND " +
                                        "age_desde<='" + dtpDia.Value.ToString("yyy-MM-dd") + "' AND " +
                                        "age_hasta>='" + dtpDia.Value.ToString("yyy-MM-dd") + "' AND " +
                                        "sem_desde<='" + dtpHora.Value.ToString("HH:mm:ss") + "' AND " +
                                        "sem_hasta>='" + dtpHora.Value.ToString("HH:mm:ss") + "'");
            if (agenda == -1) {
                MessageBox.Show("No atiende a esta hora.");
                return;
            };
            if (DB.ExecuteCardinal("SELECT COUNT(*) FROM " + DB.schema + "turno WHERE " +
                            "tur_agenda = "+ agenda +" AND " +
                            "'" + dtpDia.Value.ToString("yyy-MM-dd") + "'= CAST(tur_fechaYHoraTurno AS DATE) AND " +
                            "ABS(DATEDIFF(minute, tur_fechaYHoraTurno, '" + dtpHora.Value.ToString() + "')) < 30") > 0) {
                MessageBox.Show("Esa media hora esta ocupada.");
                return;
            };

            if (MessageBox.Show("Turno con el dr. " + prof.usuario.apellido + ", " + prof.usuario.nombre + " para el día " + dtpDia.Value.DayOfWeek + " " + dtpDia.Value.Day + " del " + dtpDia.Value.Month + " a las " + dtpHora.Value.ToString("HH:mm:ss"), "Confirmar", MessageBoxButtons.OKCancel) == DialogResult.OK)
                if (DB.ExecuteNonQuery("INSERT INTO " + DB.schema + "turno (tur_afiliado, tur_profesional, tur_especialidad, tur_fechaYHoraTurno, tur_agenda) VALUES " +
                    "(" + afiliado.id + ", " + prof.id + ", " + ((Especialidad)cmbEspecialidades.SelectedItem).id + ", '" +
                    dtpDia.Value.ToString("yyy-MM-dd") + " " + dtpHora.Value.ToString("HH:mm:ss") + "', " + agenda + ")") < 0)
                    MessageBox.Show("Error al agregar al turno", "Correción");
                else
                    DialogResult = DialogResult.OK;
        }

        //--Cuando apreta ENTER en una celda, selecciona el profesional
        private void dgvProfesionales_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.Handled = true;
                dgvProfesionales_CellContentClick(sender,
                    new DataGridViewCellEventArgs(dgvProfesionales.Columns["seleccionar"].Index, dgvProfesionales.CurrentCell.RowIndex));
            }
        }

        private void cmbEspecialidades_KeyPress(object sender, KeyPressEventArgs e) {

            e.Handled = true;

            if (e.KeyChar == (char)13)
                bSiguienteEsp.PerformClick();
        }

        private void dtpDia_KeyPress(object sender, KeyPressEventArgs e) {

            e.Handled = true;

            if (e.KeyChar == (char)13)
                bSiguienteDia.PerformClick();
        }
    }
}