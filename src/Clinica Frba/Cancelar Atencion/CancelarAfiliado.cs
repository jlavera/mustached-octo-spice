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
        Afiliado afiliado;
        public bool cerrar = false;

        public CancelarAfiliado(Usuario _usuario) {
            InitializeComponent();
            int tmp = DB.ExecuteCardinal("SELECT TOP 1 afi_id FROM " + DB.schema + "vAfiliado WHERE usu_id=" + _usuario.id);
            if (tmp != -1) {
                afiliado = new Afiliado(tmp);
            } else {
                //Si fallo al traer afiliados, es que el usuario no es un afiliado
                MessageBox.Show("A modo de debug, le vamos a dejar elejir un afiliado");
                miniAfiliado mini = new miniAfiliado();

                if (mini.ShowDialog() != DialogResult.OK)
                    cerrar = true;

                afiliado = mini.afiliado;
            }
        }

        private void CancelarAfiliado_Load(object sender, EventArgs e) {
            //--Cargar los turnos que puede cancelar
            turnos.FillForAfi(afiliado);
            lbTurnos.Items.AddRange(turnos.ToList()); 
        }

        private void bSeleccionar_Click(object sender, EventArgs e) {
            if (lbTurnos.SelectedIndex != -1) {
                gbSeleccion.Enabled = false;
                gbMotivo.Enabled = true;
                gbMotivo.Focus();
            }
        }

        private void bAceptar_Click(object sender, EventArgs e) {
            if (FuncionesBoludas.policia(gbMotivo.Controls)) {
                String query;
                query = "UPDATE " + DB.schema + "turno SET tur_habilitado=0 WHERE tur_id=" + ((Turno)lbTurnos.SelectedItem).id +
                        "; INSERT INTO " + DB.schema + "cancelacion(tuA_razon, tuA_tipo, tuA_turno, tua_cancelante) VALUES"+
                        "('" + tbDetalle.Text + "', '" + cbTipo.Text + "', " + ((Turno)lbTurnos.SelectedItem).id + ", 0)";
                if (DB.ExecuteNonQuery(query) == -1)
                    MessageBox.Show("Error en la baja del turno");
                DialogResult = DialogResult.OK;
            }
        }

        private void bVolver_Click(object sender, EventArgs e) {
            tbDetalle.Text = "";
            gbMotivo.Enabled = false;
            gbSeleccion.Enabled = true;
        }
    }
}
