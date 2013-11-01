using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.RegistrarAgendas {
    public partial class RegistrarAgendas : Form {
        Agendas agendas = new Agendas();

        public RegistrarAgendas() {
            InitializeComponent();
        }

        private void RegistrarAgendas_Load(object sender, EventArgs e) {
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;

            //La primera carga se hace a mano
            agendas.FillWithAll();
            foreach (Agenda agenda in agendas.items)
                dgvAgenda.Rows.Add(agenda.id, agenda.profesional, agenda.desde, agenda.hasta);
        }

        private void FillDgv() {
            agendas.ClearList();
            dgvAgenda.Rows.Clear();
            agendas.FillWithFilter(cbProfesional.SelectedIndex, dtpDesde.Value, dtpHasta.Value);

            foreach (Agenda agenda in agendas.items)
                dgvAgenda.Rows.Add(agenda.id, agenda.profesional, agenda.desde, agenda.hasta);

        }

        private void bEliminar_Click(object sender, EventArgs e) {
            agendas.DeleteSelected(dgvAgenda, dgvAgenda.SelectedRows);
            FillDgv();
        }

        private void dgvAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvAgenda.Columns[e.ColumnIndex].HeaderText == "Seleccionar") {
                Registrar_Agenda.EditAgenda formEdit = new Registrar_Agenda.EditAgenda(agendas[e.RowIndex]);
                formEdit.ShowDialog();

                if (formEdit.DialogResult == DialogResult.OK) {
                    FillDgv();
                }
            }

        }

        private void bAgregar_Click(object sender, EventArgs e) {
            Registrar_Agenda.EditAgenda editForm = new Registrar_Agenda.EditAgenda();
            editForm.ShowDialog();

            if (editForm.DialogResult == DialogResult.OK) {
                FillDgv();
            }

        }

        private void bBuscar_Click(object sender, EventArgs e) {
            if (dtpDesde.Value.Ticks >= dtpHasta.Value.Ticks)
                MessageBox.Show("Las fechas no estan en orden");
            else
                FillDgv();
        }
    }
}