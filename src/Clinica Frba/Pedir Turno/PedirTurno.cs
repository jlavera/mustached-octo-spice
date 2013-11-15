using System;
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

        Agendas agendas = new Agendas();
        Semanales semanales = new Semanales();

        Especialidades esps = new Especialidades();

        public PedirTurno(Usuario _usuario) {
            InitializeComponent();
            int tmp = DB.ExecuteCardinal("SELECT TOP 1 afi_id FROM "+DB.schema+"vAfiliados WHERE usu_id="+_usuario.id);
            if (tmp != -1) {
                afiliado = new Afiliado(tmp);
            } else {
                //Si fallo al traer afiliados, es que el usuario no es un afiliado
                MessageBox.Show("Este usuario no tiene un afiliado asociado,\na modo de debug, le vamos a dejar elejir un afiliado");
                miniAfiliado mini = new miniAfiliado();
                while (mini.DialogResult != DialogResult.OK)
                    mini.ShowDialog();
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
                    prof.usuario.apellido + ", " + prof.usuario.nombre, prof.concatEsps());
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

            semanales.items.Clear();
            cmbHorario.Items.Clear();

            semanales.FillTurnosLibres(prof.id, dtpDia.Value);
            cmbHorario.Items.AddRange(semanales.ToList());

            gbDia.Enabled = false;
            gbHorario.Enabled = true;

        }
        private void bVolverDia_Click(object sender, EventArgs e) {
            gbDia.Enabled = false;
            gbEspecialidad.Enabled = true;
        }

        //--------------HORARIO---------
        private void bVolverHorario_Click(object sender, EventArgs e) {
            semanales.items.Clear();
            cmbHorario.Items.Clear();

            gbDia.Enabled = true;
            gbHorario.Enabled = false;
        }
        private void bFinalizar_Click(object sender, EventArgs e) {

            if (cmbHorario.SelectedIndex == -1) {
                MessageBox.Show("Debe elegir un horario", "Error");
                return;
            }

            if (MessageBox.Show("Turno con el dr. " + prof.usuario.apellido + ", " + prof.usuario.nombre + " para el día " + dtpDia.Value.DayOfWeek + " " + dtpDia.Value.Day + " del " + dtpDia.Value.Month + " a las " + cmbHorario.SelectedItem.ToString(), "Confirmar", MessageBoxButtons.OKCancel) == DialogResult.OK)
                //--TODO QUERY INSERT
                if (DB.ExecuteNonQuery("INSERT INTO " + DB.schema + "turno (tur_afiliado, tur_profesional, tur_especialidad, tur_fechaYHoraTurno) VALUES " +
                    "(" + afiliado.id + ", " + prof.id + ", " + ((Especialidad)cmbEspecialidades.SelectedItem).id + ", '" +
                    dtpDia.Value.ToString("yyy-MM-dd") + " " + ((Semanal)cmbHorario.SelectedItem).hora.ToString("HH:mm:ss") + "')") < 0)
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
    }
}