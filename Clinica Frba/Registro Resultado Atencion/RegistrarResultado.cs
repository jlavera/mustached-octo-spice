using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.RegistroResultado {
    public partial class RegistrarResultado : Form {

        Turnos turnos = new Turnos();
        Profesional prof;

        public RegistrarResultado() {
            InitializeComponent();
            //--TODO creo que debería llegar un profesional por parámetro
        }

        private void RegistrarResultado_Load(object sender, EventArgs e) {
            turnos.FillRegistrarAtencion(prof);

        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void bSiguiente_Click(object sender, EventArgs e) {

            //--Cachear el turno seleccionado
            gbTurno.Enabled = false;
            gbFecha.Enabled = true;

        }

        private void rbSi_CheckedChanged(object sender, EventArgs e) {

            //--Si marca que se concretó
            if (rbSi.Checked)
                gbDatos.Enabled = true;
            else
                gbDatos.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e) {
            //--TODO esto podría abrir la ventana para crear una receta y/o dar para elegir una ya creada, como mais te guste
        }

        private void bFinalizar_Click(object sender, EventArgs e) {
            if (rbSi.Checked) {
                //--UPDATE de que SI se realizo
                //--acordate la receta
            } else {
                //--UPDATE de que NO se realizo
            }
        }


    }
}
