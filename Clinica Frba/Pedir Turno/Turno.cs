using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.Turno {
    public partial class Turno : Form {

        Profesionales profs = new Profesionales();
        Profesional prof;

        Agendas agendas = new Agendas();
        Agenda agenda;

        Especialidades esps = new Especialidades();

        public Turno() {
            InitializeComponent();
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
                    prof.usuario.apellido + ", " + prof.usuario.nombre, prof.especialidades);
            }
        }

        private void dgvProfesionales_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            //--Guardar profesional que clickeo y habilita para seleccionar día
            if (dgvProfesionales.Columns[e.ColumnIndex].HeaderText == "Elegir") {
                prof = profs[dgvProfesionales.Rows[e.RowIndex].Cells["id"].Value.ToString()];

                gbDia.Enabled = true;
                gbProf.Enabled = false;

                //--Traer agenda del elegido y setear min y max date
                DateTime aux = DateTime.Now; //--los igualo así no los agrega al filtro
                agendas.FillWithFilter(prof, aux, aux, -1, "", "");

                dtpDia.MinDate = agendas[0].desde;
                dtpDia.MaxDate = agendas[0].hasta;



            }
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

        private void bVolver_Click(object sender, EventArgs e) {
            gbDia.Enabled = false;
            gbProf.Enabled = true;
        }

        private void bSiguiente_Click(object sender, EventArgs e) {

        }

    }
}