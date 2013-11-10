using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.Clases {
    public partial class miniProfesional : Form {
        public Profesional profesional;

        private Profesionales profesionales = new Profesionales();

        public miniProfesional() {
            InitializeComponent();
        }

        private void miniAfiliado_Load(object sender, EventArgs e) {
            profesionales.FillWithAll();
            cbAfi.Items.AddRange(profesionales.ToList());
        }

        private void button1_Click(object sender, EventArgs e) {
            if (cbAfi.Text != "") {
                profesional = (Profesional)cbAfi.SelectedItem;
                DialogResult = DialogResult.OK;
            } else
                MessageBox.Show("Porfavor, selecciona un profesional");
        }
    }
}
