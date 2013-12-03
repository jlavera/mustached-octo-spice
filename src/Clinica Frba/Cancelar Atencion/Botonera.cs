using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Cancelar_Atencion {
    public partial class Botonera : Form {

        public string rol;

        public Botonera() {
            InitializeComponent();
        }

        private void bAfiliado_Click(object sender, EventArgs e) {
            rol = "Afiliado";
            DialogResult = DialogResult.OK;
        }

        private void bProfesional_Click(object sender, EventArgs e) {
            rol = "Profesional";
            DialogResult = DialogResult.OK;
        }
    }
}
