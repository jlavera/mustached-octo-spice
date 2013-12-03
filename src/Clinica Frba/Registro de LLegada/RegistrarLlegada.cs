using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.RegistrarLlegada {
    public partial class RegistrarLlegada : Form {

        Profesionales profs = new Profesionales();
        Profesional prof;

        Turnos turnos = new Turnos();
        Turno turno;

        Especialidades esps = new Especialidades();

        public RegistrarLlegada() {
            InitializeComponent();
        }

        private void RegistrarLlegada_Load(object sender, EventArgs e) {

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
                    prof.usuario.apellido + ", " + prof.usuario.nombre,">>", prof.concatEsps());
            }
        }

        private void dgvProfesionales_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            //--Guardar profesional que clickeo y habilita para seleccionar día
            if (dgvProfesionales.Columns[e.ColumnIndex].Name == "Seleccionar") {
                prof = profs[dgvProfesionales.Rows[e.RowIndex].Cells["id"].Value.ToString()];

                gbTurno.Enabled = true;
                gbProf.Enabled = false;

                turnos.FillForProf(prof, false);
                lbTurnos.Items.AddRange(turnos.ToList());
            }
        }

        private void bLimpiar_Click(object sender, EventArgs e) {
            FuncionesBoludas.limpiarControles(gbProf.Controls);
        }

        private void bBuscar_Click(object sender, EventArgs e) {

            FillDgv();
        }

        private void dgvProfesionales_KeyDown(object sender, KeyEventArgs e) {

            if (e.KeyCode == Keys.Enter) {
                e.Handled = true;
                dgvProfesionales_CellContentClick(sender,
                    new DataGridViewCellEventArgs(dgvProfesionales.Columns["seleccionar"].Index, dgvProfesionales.CurrentCell.RowIndex));
            }
        }

        //--Turnos
        private void bVolverTurno_Click(object sender, EventArgs e) {
            gbTurno.Enabled = false;
            gbProf.Enabled = true;
        }

        private void bSiguienteTurno_Click(object sender, EventArgs e) {

            //--Validar que haya seleccionado un turno
            if (lbTurnos.SelectedItems.Count != 1) {
                MessageBox.Show("Debe seleccionar un turno");
                return;
            }

            turno = (Turno)lbTurnos.SelectedItem;
            
            gbAfiliado.Enabled = true;
            gbTurno.Enabled = false;
        }

        //--Afiliados
        private void bVolvereAfi_Click(object sender, EventArgs e) {
            tbAfiliado.Text = "";

            gbTurno.Enabled = true;
            gbAfiliado.Enabled = false;
        }

        private void bSiguienteAfi_Click(object sender, EventArgs e) {
            //--Validar que el turno pertenezca al afiliado ingresado
            if (tbAfiliado.Text == "" || (turno.afiliado.id != Convert.ToInt32(tbAfiliado.Text))) {
                MessageBox.Show("El turno no le pertenece al afilado ingresado o es inválido.");
                return;
            }

            gbAfiliado.Enabled = false;
            gbBono.Enabled = true;
        }

        private void bSiguienteBono_Click(object sender, EventArgs e) {
            try {
                if (tbBono.Text == "") {
                    MessageBox.Show("El número de bono es inválido.");
                    return;
                }
                BonoConsulta bono = new BonoConsulta(Convert.ToInt32(tbBono.Text));
                Afiliado afiliado = new Afiliado(Convert.ToInt32(tbAfiliado.Text));
                if (afiliado.grupoFamiliar.grupo != bono.comprador.grupoFamiliar.grupo) { //Que pertenezca al grupo del que lo comrpo
                    MessageBox.Show("El bono no coresponde al afiliado");
                    return;
                }

                //Si llego aca coincide t0do, y va t0do bien.
                DB.ExecuteNonQuery("SET IDENTITY_INSERT " + DB.schema + "atencion ON; " +
                                    "INSERT INTO " + DB.schema + "atencion(ate_bonoConsulta, ate_fechaYHoraLlegada, ate_turno) VALUES (" + bono.id + ", '" + FuncionesBoludas.GetDateTime() + "', " + ((Turno)lbTurnos.SelectedItem).id  + "); " +
                                    "SET IDENTITY_INSERT " + DB.schema + "atencion OFF; " +
                                  "UPDATE "+DB.schema + "bonoConsulta SET bco_habilitado=0, bco_afiliado=" + tbAfiliado.Text + " WHERE bco_id=" + bono.id); //Caundo se consume, poner por quien
                DialogResult = DialogResult.OK;

            } catch (NoTrajoNadaExcep) {
                MessageBox.Show("No existe ese bono");
            }
            //--validar existencia de bono, deshabilitarlo y ponerle la fecha y hora de llegada al turno
        }

        private void lbTurnos_KeyPress(object sender, KeyPressEventArgs e) {

            e.Handled = true;

            if (e.KeyChar == (char)13)
                bSiguienteTurno.PerformClick();
        }

        private void tbAfiliado_KeyPress(object sender, KeyPressEventArgs e) {

            e.Handled = true;

            if (e.KeyChar == (char)13)
                bSiguienteAfi.PerformClick();
        }

        private void tbBono_KeyPress(object sender, KeyPressEventArgs e) {

            e.Handled = true;

            if (e.KeyChar == (char)13)
                bSiguienteBono.PerformClick();
        }
    }
}