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
    public partial class AbmAfiliados : Form {
        Usuarios users = new Usuarios();
        Afiliados afiliados = new Afiliados();
        PlanesMedicos planes = new PlanesMedicos();

        public AbmAfiliados() {
            InitializeComponent();
        }

        private void AbmAfiliados_Load(object sender, EventArgs e) {


        }

        private void cmbTipoDNI_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void FillDgvYLb() {

            afiliados.FillWithAll();

            foreach (Afiliado afiliado in afiliados.items) {
                dgvRoles.Rows.Add(afiliado.usuario.id, afiliado.usuario.nombre, afiliado.usuario.apellido, afiliado.usuario, tipoDocumento, afiliado.usuario.numeroDocumento, afiliado.usuario.direccion, afiliado.usuario.telefono, afiliado.usuario.mail, afiliado.usuario.fechaNacimiento, afiliado.usuario.sexo, afiliado.usuario.nombreUsuario, afiliado.grupoFamiliar, afiliado.orden, afiliado.estadoCivil, afiliado.familiaresACargo, afiliado.planMedico.nombre);
            }

        }
    }
}