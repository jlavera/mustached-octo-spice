using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.Generar_Receta {
    public partial class CargarMedicamentos : Form {

        public Medicamento medicamento;

        internal Medicamentos medicamentos = new Medicamentos();

        public CargarMedicamentos() {
            InitializeComponent();
        }

        private void Medicamentos_Load(object sender, EventArgs e) {
            medicamentos.FillWithAll();
            lbMedicamento.Items.AddRange(medicamentos.ToList());
            dtpPrescripcion.Value = FuncionesBoludas.GetDateTime();
        }

        private void bAgregar_Click(object sender, EventArgs e) {
            if (lbMedicamento.SelectedIndex != -1 && nCantidad.Value >= 1 && nCantidad.Value <= 3) {
                medicamento = new Medicamento(((Medicamento)lbMedicamento.SelectedItem).id, ((Medicamento)lbMedicamento.SelectedItem).nombre, (int)nCantidad.Value, dtpPrescripcion.Value);
                DialogResult = DialogResult.OK;
            } else
                MessageBox.Show("Errores en la eleccion de medicamento");
        }

        private void bFiltrar_Click(object sender, EventArgs e) {
            medicamentos.ClearList();
            lbMedicamento.Items.Clear();

            medicamentos.FillWithFilter(tbFiltro.Text);
            lbMedicamento.Items.AddRange(medicamentos.ToList());
        }
    }
}
