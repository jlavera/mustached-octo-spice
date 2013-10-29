using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.AbmRoles {
    public partial class AbmRoles : Form {

        Funcionalidades items;

        public AbmRoles() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Roles roles = new Roles();
        }

        private void bBuscar_Click(object sender, EventArgs e) {

            Column1.DisplayIndex = dgvRoles.Columns.Count - 1;
            //items = new Funcionalidades(dgvRoles.Rows);


        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            if (dgvRoles.Columns[e.ColumnIndex].HeaderText == "Seleccionar")
                MessageBox.Show(dgvRoles.Rows[e.RowIndex].Cells["nombre"].Value.ToString());

        }

    }
}