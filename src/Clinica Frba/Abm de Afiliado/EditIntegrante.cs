﻿using System;
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
        EstadosCiviles estadosCiviles = new EstadosCiviles();

        public Integrante integrante;

        public EditIntegrante(bool p_tiene, string p_telefono, string p_direccion, string p_apellido) {
            InitializeComponent();

            tieneConyuge = p_tiene;
            tbTelefono.Text = p_telefono;
            tbDireccion.Text = p_direccion;
            tbApellido.Text = p_apellido;
        }

        private void EditIntegrante_Load(object sender, EventArgs e) {
            estadosCiviles.FillWithAll();
            cmbEstadoCivil.Items.AddRange(estadosCiviles.ToList());

            //--Si ya tiene conyuge, no puede agregar conyuge
            if (tieneConyuge)
                cbConyuge.Enabled = false;
        }

        private void bGuardar_Click(object sender, EventArgs e) {
            if (FuncionesBoludas.policia(gbDatos.Controls)){

                integrante = new Integrante(tbNombre.Text, tbApellido.Text, tbDireccion.Text, tbMail.Text, cmbTipoDNI.Text,
                    Convert.ToInt64(tbNumeroDni.Text), Convert.ToInt64(tbTelefono.Text), (EstadoCivil)cmbEstadoCivil.SelectedItem,
                    (cmbSexo.SelectedText == "Masculino") ? "M" : "F", tbNombreUsuario.Text, cbConyuge.Checked, dtpFechaNacimiento.Value, tbContrasegna.Text, (int)nFamiliares.Value);
                DialogResult = DialogResult.OK;
            }
        }


    }
}