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
        Profesionales pros = new Profesionales();

        public RegistrarAgendas() {
            InitializeComponent();
        }

        private void RegistrarAgendas_Load(object sender, EventArgs e) {
            dtpDesde.Value = dtpDesde.MinDate;
            dtpHasta.Value = dtpDesde.MaxDate;

            pros.FillWithAll();
            cbProfesional.Items.AddRange(pros.ToList());

            //La primera carga se hace a mano
            agendas.FillWithAll();
            foreach (Agenda agenda in agendas.items)
                dgvAgenda.Rows.Add(agenda.id, agenda.profesional, agenda.desde.ToString("dd-MM-yyyy"), agenda.hasta.ToString("dd-MM-yyyy"));
        }

        private void FillDgv() {
            agendas.ClearList();
            dgvAgenda.Rows.Clear();
            agendas.FillWithFilter(((Profesional)cbProfesional.SelectedItem), dtpDesde.Value, dtpHasta.Value, FuncionesBoludas.diaCereal(cbDia.Text), cbDiaDesde.Text, cbDiaHasta.Text);

            foreach (Agenda agenda in agendas.items)
                dgvAgenda.Rows.Add(agenda.id, agenda.profesional, agenda.desde, agenda.hasta);

        }

        private void bEliminar_Click(object sender, EventArgs e) {

            if (dgvAgenda.SelectedRows.Count == 0) {
                MessageBox.Show("No seleccionó ninguna fila.");
                return;
            }

            agendas.DeleteSelected(dgvAgenda, dgvAgenda.SelectedRows);
            FillDgv();
        }

        private void dgvAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvAgenda.Columns[e.ColumnIndex].HeaderText == "Seleccionar") {
                Registrar_Agenda.EditAgenda formEdit = new Registrar_Agenda.EditAgenda(agendas[dgvAgenda.Rows[e.RowIndex].Cells["id"].Value.ToString()]);
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

        private void bLimpiar_Click(object sender, EventArgs e) {
            //Limpiar las cosa para buscar
            dtpDesde.Value = dtpDesde.MinDate;
            dtpHasta.Value = dtpDesde.MaxDate;

            FuncionesBoludas.limpiarControles(gbFiltros.Controls);
        }
    }
}