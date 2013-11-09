using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.Cancelar_Atencion {
    public partial class CancelarAfiliado : Form {

        Turnos turnos = new Turnos();

        public CancelarAfiliado() {
            InitializeComponent();
        }

        private void CancelarAfiliado_Load(object sender, EventArgs e) {
            
            //--Cargar los motivos de cancelación
            //cmbMotivo.Items.AddRange();

            //--Cargar los turnos que puede cancelar
            turnos.FillWithAll();//acordate que tiene que ser al menos un día antes
            //lbTurnos.Items.AddRange() 
        }

        private void bSeleccionar_Click(object sender, EventArgs e) {

            gbSeleccion.Enabled = false;
            gbMotivo.Enabled = true;
        }

        private void bAceptar_Click(object sender, EventArgs e) {
            //--TODO UPDATE
        }

        private void bVolver_Click(object sender, EventArgs e) {
            cmbMotivo.SelectedIndex = -1;
            gbMotivo.Enabled = false;
            gbSeleccion.Enabled = true;
        }
    }
}
