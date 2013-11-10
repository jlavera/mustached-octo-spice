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
    public partial class CancelarProfesional : Form {

        Turnos turnos = new Turnos();
        Profesional profesional;

        public CancelarProfesional(Usuario _usuario) {
            InitializeComponent();
            try {
                profesional = new Profesional(_usuario.id);
            } catch (NoTrajoNadaExcep ex) {
                //Si fallo al traer afiliados, es que el usuario no es un afiliado
                MessageBox.Show("Este usuario no tiene un profesional asociado,\na modo de debug, le vamos a dejar elejir un profesional");
                miniProfesional mini = new miniProfesional();
                while (mini.DialogResult != DialogResult.OK)
                    mini.ShowDialog();
                profesional = mini.profesional;
            }
        }

        private void bSeleccionar_Click(object sender, EventArgs e) {
            if (dtpDia.Value.Ticks < FuncionesBoludas.GetDateTime().AddDays(-1).Ticks)
                MessageBox.Show("La cancelación deberá realizarse con un día de antelación.");
            else {
                gbSeleccion.Enabled = false;
                gbMotivo.Enabled = true;
            }
        }

        private void bVolver_Click(object sender, EventArgs e) {
            gbMotivo.Enabled = false;
            gbSeleccion.Enabled = true;
        }

        private void bAceptar_Click(object sender, EventArgs e) {
            if(FuncionesBoludas.policia(gbMotivo.Controls)){
                if (FuncionesBoludas.policia(gbMotivo.Controls)) {
                    String query;
                    query = "UPDATE " + DB.schema + "turno SET tur_habilitado=0 WHERE  CAST(tur_fechaYHoraTurno AS DATE)='" + dtpDia.Value.ToString("yyyy-MM-dd") + "' AND tur_profesional='" + profesional.id + "'; " +
                            "INSERT INTO moustache_spice.turnoAudit(tuA_razon, tuA_turno) (SELECT '" + tbDetalle.Text + "', tur_id FROM moustache_spice.turno WHERE  CAST(tur_fechaYHoraTurno AS DATE)='" + dtpDia.Value.ToString("yyyy-MM-dd") + "' AND tur_profesional='" + profesional.id + "');";
                    if (DB.ExecuteNonQuery(query) == -1)
                        MessageBox.Show("Error en la baja del dia");
                    DialogResult = DialogResult.OK;
                }
            }
            //--TODO UPDATES ciclando por cada dia seleccionado (por eso el month calendar, podés seleccionar períodos)
        }
    }
}
