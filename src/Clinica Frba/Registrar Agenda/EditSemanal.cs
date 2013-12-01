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
    public partial class EditSemanal : Form {

        public Semanal semanal;

        public EditSemanal() {
            InitializeComponent();
        }

        private void EditSemanal_Load(object sender, EventArgs e) {

        }

        private void bAceptar_Click(object sender, EventArgs e) {
            if (FuncionesBoludas.policia(this.Controls) && dtpHasta.Value > dtpDesde.Value) {
                semanal = new Semanal(FuncionesBoludas.diaCereal(cDia.Text), dtpDesde.Value, dtpHasta.Value);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
