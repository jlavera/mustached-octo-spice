using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Listados_Estadisticos {
    public partial class ListadosEstadisticos : Form {
        public ListadosEstadisticos() {
            InitializeComponent();
        }

        private void b_Click(object sender, EventArgs e) {
            openView(((Button)sender).Name);
        }

        private void openView(string tipo) {

            Ver form = new Ver((rbPrimer.Checked) ? 1 : 2, tipo);
            form.ShowDialog();
        }
    }
}
