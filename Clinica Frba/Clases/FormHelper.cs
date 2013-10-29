using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clinica_Frba.Clases {
    public partial class FormHelper : Form {

        private string titulo;

        public FormHelper(string pTitulo) {
            InitializeComponent();

            titulo = pTitulo;
        }

        private void FormHelper_Load(object sender, EventArgs e) {

            this.Text = titulo;

            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM " + titulo, Clinica_Frba.Properties.Settings.Default.GD2C2013ConnectionString);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);

            dgv.DataSource = tabla;

        }

        private void bBuscar_Click(object sender, EventArgs e) {
            string query = "";

            foreach (Panel panel in flp.Controls) {
                query += panel.Name + " = " + Transformer.Megatron(panel.Controls["txb"]) + " ";
            }

            MessageBox.Show(query);

            
        }
    }
}
