using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.Registrar_Agenda {
    public partial class EditAgenda : Form {
        public bool nueva = false;
        private Agenda vieja;

        Profesionales pros = new Profesionales();

        public EditAgenda(Agenda _agenda) {
            InitializeComponent();
            vieja = _agenda;
        }
        public EditAgenda() {
            InitializeComponent();
            nueva = true;
        }

        private void EditAgenda_Load(object sender, EventArgs e) {

            //--Llenar los profesionales en el listBox
            pros.FillWithAll();
            cbProfesional.Items.AddRange(pros.ToList());

            //--Si la agenda es nueva
            if (nueva) {
                dtpDesde.Value = DateTime.Today;
                dtpHasta.Value = DateTime.Today;
            } else {
                cbProfesional.Enabled = false;
                cbProfesional.Items.Add(vieja.profesional);
                dtpDesde.Value = vieja.desde;
                dtpHasta.Value = vieja.hasta;
            }
        }

        private void bGuardar_Click(object sender, EventArgs e) {
            string query = "DELETE " + DB.schema + "semanal WHERE sem_profesional =" + cbProfesional.SelectedItem + "; ";
            if (nueva) {
                query = "INSERT INTO " + DB.schema + "agenda(age_desde, age_hasta, age_profesional) VALUES(" + dtpDesde.Value.ToString("yyyy-MM-dd") + ", " + dtpHasta.Value.ToString("yyyy-MM-dd") + ", " + cbProfesional.SelectedItem + ");";

                //INSERT INTO " + DB.schema + "semanal(sem_agenda, sem_dia, sem_hora)
            } else {
            }

            foreach (Control lb in this.Controls) {
                if (lb is ListBox) {
                    MessageBox.Show(((ListBox)lb).SelectedItems.ToString());
                }
            }

            //DB.ExecuteNonQuery(query);
            this.Close();
            DialogResult = DialogResult.OK;
        }
    }
}