using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.AbmAfiliados {
    public partial class EditIntegrante : Form {

        private bool tieneConyuge;
        public Integrante integrante;

        public EditIntegrante(bool p_tiene) {
            InitializeComponent();

            tieneConyuge = p_tiene;
        }

        private void EditIntegrante_Load(object sender, EventArgs e) {

            //--Si ya tiene conyuge, no puede agregar conyuge
            if (tieneConyuge)
                cbConyuge.Enabled = false;
        }

        private void bGuardar_Click(object sender, EventArgs e) {
            integrante = new Integrante(tbNombre.Text, tbApellido.Text, tbDireccion.Text, tbMail.Text, cmbTipoDNI.SelectedText,
                Convert.ToInt64(tbNumeroDni.Text), Convert.ToInt64(tbTelefono), (EstadoCivil)cmbEstadoCivil.SelectedItem,
                (cmbSexo.SelectedText == "Masculino") ? "M" : "F", tbNombreUsuario.Text, cbConyuge.Checked);

            this.Close();
        }


    }
}