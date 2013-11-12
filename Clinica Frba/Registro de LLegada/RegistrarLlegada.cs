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
                    prof.usuario.apellido + ", " + prof.usuario.nombre, prof.concatEsps());
            }
        }

        private void dgvProfesionales_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            //--Guardar profesional que clickeo y habilita para seleccionar día
            if (dgvProfesionales.Columns[e.ColumnIndex].Name == "Seleccionar") {
                prof = profs[dgvProfesionales.Rows[e.RowIndex].Cells["id"].Value.ToString()];
            }

            gbTurno.Enabled = true;
            gbProf.Enabled = false;

            //--TODO llenar LB con los turnos del día del profesional
            turnos.FillForProf(prof);
            lbTurnos.Items.AddRange(turnos.ToList());
            
        }

        private void bLimpiar_Click(object sender, EventArgs e) {
            //Limpiar las cosa para buscar
            foreach (Control ctrl in gbProf.Controls) {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = "";
                if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedIndex = -1;
                if (ctrl is MaskedTextBox)
                    ((MaskedTextBox)ctrl).Text = "";
                if (ctrl is ListBox)
                    ((ListBox)ctrl).ClearSelected();
            }
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
            gbTurno.Enabled = true;
            gbAfiliado.Enabled = false;
        }

        private void bSiguienteAfi_Click(object sender, EventArgs e) {

            //--Validar que el turno pertenezca al afiliado ingresado
            if (turno.afiliado.id != Convert.ToInt32(tbAfiliado.Text)) { //--TODO puede que este mal este if, no lo se
                MessageBox.Show("El turno no le pertenece al afilado ingresado");
                return;
            }

            gbAfiliado.Enabled = false;
            gbBono.Enabled = true;
        }

        private void bSiguienteBono_Click(object sender, EventArgs e) {

            //--TODO validar existencia de bono, deshabilitarlo y ponerle la fecha y hora de llegada al turno :)
        }
    }
}