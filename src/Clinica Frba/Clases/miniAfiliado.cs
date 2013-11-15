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
    public partial class miniAfiliado : Form {
        public Afiliado afiliado;

        private Afiliados afiliados = new Afiliados();

        public miniAfiliado() {
            InitializeComponent();
        }

        private void miniAfiliado_Load(object sender, EventArgs e) {
            afiliados.FillWithAll();
            cbAfi.Items.AddRange(afiliados.ToList());
        }

        private void button1_Click(object sender, EventArgs e) {
            if (cbAfi.Text != "") {
                afiliado = (Afiliado)cbAfi.SelectedItem;
                DialogResult = DialogResult.OK;
            } else
                MessageBox.Show("Porfavor, selecciona un afiliado");
        }
    }
}
