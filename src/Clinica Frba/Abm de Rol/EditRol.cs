using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.Abm_de_Rol {
    public partial class EditRol : Form {

        public DialogResult dr = DialogResult.Cancel;

        public int id;
        public string nombre;
        public bool habilitado;
        public Funcionalidades allFuncs = new Funcionalidades();
        public Usuarios allUsu = new Usuarios();

        public bool nueva;
        private Funcionalidades selectedFuncs;
        private Usuarios selectedUsu;
        private Roles roles = new Roles();

        public EditRol() {

            nueva = true;

            InitializeComponent();
        }

        public EditRol(Rol p_rol) {
            id = p_rol.id;
            nombre = p_rol.nombre;
            habilitado = p_rol.habilitado;
            selectedFuncs = p_rol.funcionalidades;
            selectedUsu = new Usuarios(id);

            nueva = false;

            InitializeComponent();
        }

        private void EditRol_Load(object sender, EventArgs e) {
            allFuncs.FillWithAll();
            lbFuncionalidades.Items.AddRange(allFuncs.ToList());

            allUsu.FillWithAll();
            lbUsuarios.Items.AddRange(allUsu.ToList());

            if (nueva) {
                tbId.Text = roles.GetNextIdentity().ToString();
                cbHabilitado.Visible = false;

            } else {
                tbId.Text = id.ToString();
                tbNombre.Text = nombre;
                cbHabilitado.Checked = habilitado;

                foreach (Funcionalidad func in selectedFuncs.items) {
                    for (int i = 0; i < lbFuncionalidades.Items.Count; i++) {
                        if (func.Equals(lbFuncionalidades.Items[i])) {
                            lbFuncionalidades.SetSelected(i, true);
                            break;
                        }
                    }
                }
                foreach (Usuario usu in selectedUsu.items)
                {
                    for (int i = 0; i < lbUsuarios.Items.Count; i++)
                    {
                        if (usu.Equals(lbUsuarios.Items[i]))
                        {
                            lbUsuarios.SetSelected(i, true);
                            break;
                        }
                    }
                }

            }
        }

        private void bGuardar_Click(object sender, EventArgs e) {

            string subQuery = "";

             if (nueva) {
                 if (DB.ExecuteNonQuery("INSERT INTO " + DB.schema + "rol(rol_nombre, rol_habilitado) VALUES ('" + tbNombre.Text + "', " + Convert.ToInt32(cbHabilitado.Checked) + ");") < 0)
                    MessageBox.Show("Error en inserscion de rol");
            } else {
                //Es mas facil borrar todos los rol_x_funcionalidad que revisar cuales cambiaron
                if (DB.ExecuteNonQuery("DELETE " + DB.schema + "rol_x_usuario WHERE rxu_rol=" + tbId.Text + ";" +
                                       "DELETE " + DB.schema + "rol_x_funcionalidad WHERE rxf_rol=" + tbId.Text + "; " +
                                       "UPDATE " + DB.schema + "rol SET rol_nombre='" + tbNombre.Text + "', rol_habilitado=" + Convert.ToInt32(cbHabilitado.Checked) + " WHERE rol_id=" + tbId.Text) < 0)
                    MessageBox.Show("Error en modificacion de rol");
            }
            if (lbUsuarios.SelectedItems.Count > 0){
                foreach (Usuario usuario in lbUsuarios.SelectedItems)
                {
                    subQuery += "(" + usuario.id + ", " + tbId.Text + "), ";
                }
                //Comoconcatena con ", " le saco los ultimos dos caracteres al string
                subQuery = subQuery.Substring(0, subQuery.Length - 2);

                if (DB.ExecuteNonQuery("INSERT INTO " + DB.schema + "rol_x_usuario(rxu_usuario, rxu_rol) VALUES " + subQuery) < 0)
                    MessageBox.Show("Error en inserscion de rol x usuario");
             }
            if (lbFuncionalidades.SelectedItems.Count > 0){
                subQuery = "";
                foreach (Funcionalidad funcionalidad in lbFuncionalidades.SelectedItems){
                    subQuery += "(" + funcionalidad.id + ", " + tbId.Text + "), ";
                }
                //Comoconcatena con ", " le saco los ultimos dos caracteres al string
                    subQuery = subQuery.Substring(0, subQuery.Length - 2);

                if (DB.ExecuteNonQuery("INSERT INTO " + DB.schema + "rol_x_funcionalidad(rxf_funcionalidad, rxf_rol) VALUES " + subQuery) < 0)
                    MessageBox.Show("Error en inserscion de rol x funcionalidad");
            }

            this.Close();
            DialogResult = DialogResult.OK;
        }
    }
}
