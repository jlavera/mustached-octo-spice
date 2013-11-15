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
        Profesional profesional;
        public bool cerrar = false;

        public RegistrarResultado(Usuario _usuario) {
            InitializeComponent();
            int tmp = DB.ExecuteCardinal("SELECT TOP 1 pro_id FROM " + DB.schema + "vProfesional WHERE usu_id=" + _usuario.id);
            if (tmp != -1) {
                profesional = new Profesional(tmp);
            } else {
                //Si fallo al traer afiliados, es que el usuario no es un afiliado
                MessageBox.Show("A modo de debug, le vamos a dejar elejir un profesional");
                miniProfesional mini = new miniProfesional();
                if (mini.ShowDialog() != DialogResult.OK)
                    cerrar = true;
                profesional = mini.profesional;
            }
        }

        private void RegistrarResultado_Load(object sender, EventArgs e) {
            turnos.FillForProf(profesional, true);
            lbTurnos.Items.AddRange(turnos.ToList());

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

        private void bFinalizar_Click(object sender, EventArgs e) {
            if (rbSi.Checked) {
                DB.ExecuteNonQuery("UPDATE " + DB.schema + "turno SET tur_fechaYHoraAtencion='" + FuncionesBoludas.GetDateTime().ToString() + "', "+
                                                                     "tur_sintomas='" + tbSintomas.Text + "', " +
                                                                     "tur_diagnostico='" + tbDiagnostico.Text + "' " + 
                                                                     "WHERE tur_id=" + ((Turno)lbTurnos.SelectedItem).id);
            }
            DialogResult = DialogResult.OK;
        }
    }
}