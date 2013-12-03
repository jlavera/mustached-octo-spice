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
        public bool cerrar = false;

        public CancelarProfesional(Usuario _usuario) {
            InitializeComponent();
            int tmp = DB.ExecuteCardinal("SELECT TOP 1 pro_id FROM "+DB.schema+"vProfesional WHERE usu_id="+_usuario.id);
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

        private void bSeleccionar_Click(object sender, EventArgs e) {
            
            if (monthCalendar.SelectionEnd < FuncionesBoludas.GetDateTime().AddDays(-1))
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
            if (FuncionesBoludas.policia(gbMotivo.Controls)) {
                String queryDelete, queryAudit, queryAux = "";

                queryDelete = "UPDATE " + DB.schema + "turno SET tur_habilitado=0 WHERE (";
                queryAudit = "INSERT INTO " + DB.schema + "cancelacion(tuA_razon, tuA_tipo, tuA_turno, tua_cancelante) (SELECT '" + tbDetalle.Text + "', '" + cbTipo.Text + "', tur_id, 1 FROM " + DB.schema + "turno WHERE tur_habilitado=1 AND (";

                for (DateTime dateTime = monthCalendar.SelectionStart;
                     dateTime <= monthCalendar.SelectionEnd;
                     dateTime += TimeSpan.FromDays(1)) {
                    queryAux += "CAST(tur_fechaYHoraTurno AS DATE)='" + dateTime.ToString("yyyy-MM-dd") + "' OR ";
                }
                queryAux = queryAux.Substring(0, queryAux.Length - 3) + ") ";

                queryDelete += queryAux + "AND tur_profesional='" + profesional.id + "'; ";
                queryAudit += queryAux + "AND tur_profesional='" + profesional.id + "'); ";

                if (DB.ExecuteNonQuery(queryAudit + queryDelete) == -1)
                    MessageBox.Show("Error en la baja del dia");
                DialogResult = DialogResult.OK;
            }
        }

        private void monthCalendar_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;

            if (e.KeyChar == (char)13)
                bSeleccionar.PerformClick();
        }
    }
}
