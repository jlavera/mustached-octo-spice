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
    public partial class CambiarGrupo : Form {

        public GrupoFamiliar actual;
        public GrupoFamiliar nuevo;
        public int afiliadoId;
        public bool nueva;

        GruposFamiliares grupos = new GruposFamiliares();

        public CambiarGrupo(GrupoFamiliar p_grupo, int p_afiliadoId) {
            InitializeComponent();

            actual = p_grupo;
            afiliadoId = p_afiliadoId;
        }

        private void CambiarGrupo_Load(object sender, EventArgs e){

            //--Mostrar grupo actuali y cargar todos en cmb
            tbActual.Text = actual.titular;

            grupos.FillWithAll();
            cmbGrupos.Items.AddRange(grupos.ToList());
        }

        private void rbExistente_CheckedChanged(object sender, EventArgs e) {

            if (rbExistente.Checked) {
                lFiltro.Enabled = true;
                tbFiltro.Enabled = true;
                bFiltrar.Enabled = true;
                cmbGrupos.Enabled = true;
            } else {
                lFiltro.Enabled = false;
                tbFiltro.Enabled = false;
                bFiltrar.Enabled = false;
                cmbGrupos.Enabled = false;
            }
        }

        private void bFiltrar_Click(object sender, EventArgs e) {

            //--Filtrar grupos según nombre y apellido
            grupos.ClearList();
            cmbGrupos.Items.Clear();

            grupos.FillByName(tbFiltro.Text);
            cmbGrupos.Items.AddRange(grupos.ToList());
        }

        private void bGuardar_Click(object sender, EventArgs e) {

            //--Si es nueva, updatear el grupo id con el afiliado id, sino
            if (rbNueva.Checked)
                DB.ExecuteNonQuery("UPDATE " + DB.schema + "afiliado SET afi_grupoFamiliar2 = NULL, afi_orden = 1 WHERE afi_id = " + afiliadoId);
            else
            {
                nuevo = (GrupoFamiliar)cmbGrupos.SelectedItem;
                DB.ExecuteNonQuery("UPDATE " + DB.schema + "afiliado SET afi_grupoFamiliar2 = " + ((GrupoFamiliar)cmbGrupos.SelectedItem).grupo + ", afi_orden = " + ((GrupoFamiliar)cmbGrupos.SelectedItem).proximoOrden + " WHERE afi_id = " + afiliadoId);
            }

            DialogResult = DialogResult.OK;
            nueva = rbNueva.Checked;
            this.Close();
        }
    }
}