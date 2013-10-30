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

        public int id;
        public string nombre;
        public Funcionalidades allFuncs = new Funcionalidades();

        public bool nueva;
        private string[] selectedFuncs;
        private Roles roles = new Roles();

        public EditRol() {

            nueva = true;

            InitializeComponent();
        }

        public EditRol(Rol p_rol) {
            id = p_rol.id;
            nombre = p_rol.nombre;
            selectedFuncs = p_rol.funcionalidades.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            nueva = false;

            InitializeComponent();
        }

        private void EditRol_Load(object sender, EventArgs e) {
            allFuncs.FillWithAll();
            lbFuncionalidades.Items.AddRange(allFuncs.ToList());

            if (nueva) {
                tbId.Text = roles.GetNextIdentity().ToString();

            } else {
                tbId.Text = id.ToString();
                tbNombre.Text = nombre;

                foreach (string func in selectedFuncs) {
                    for (int i = 0; i < lbFuncionalidades.Items.Count; i++) {
                        if (func == lbFuncionalidades.Items[i].ToString()) {
                            lbFuncionalidades.SetSelected(i, true);
                            break;
                        }
                    }
                }
            }
        }

        private void bGuardar_Click(object sender, EventArgs e) {

            string subQuery = "";
            foreach (Funcionalidad funcionalidad in lbFuncionalidades.SelectedItems)
            {
                subQuery += "(" + funcionalidad.id + ", " + tbId.Text + "), ";
            }
            //Comoconcatena con ", " le saco los ultimos dos caracteres al string
            if(lbFuncionalidades.SelectedItems.Count > 0)
                subQuery = subQuery.Substring(0, subQuery.Length - 2);

             if (nueva) {
                 if (DB.ExecuteNonQuery("INSERT INTO " + DB.schema + "rol(nombre) VALUES ('" + tbNombre.Text + "');") < 0)
                    MessageBox.Show("Error en inserscion de rol");
            } else {
                //Es mas facil borrar todos los rol_x_funcionalidad que revisar cuales cambiaron
                if (DB.ExecuteNonQuery("DELETE " + DB.schema + "rol_x_funcionalidad WHERE rol=" + tbId.Text + "; " +
                                        "UPDATE " + DB.schema + "rol SET nombre='" + tbNombre.Text + "' WHERE id=" + tbId.Text) < 0)
                    MessageBox.Show("Error en modificacion de rol");
            }
            if (lbFuncionalidades.SelectedItems.Count > 0){
                if (DB.ExecuteNonQuery("INSERT INTO " + DB.schema + "rol_x_funcionalidad(funcionalidad, rol) VALUES " + subQuery) < 0)
                    MessageBox.Show("Error en inserscion de rol_x_funcionalidad");
            }
            this.Close();
            DialogResult = DialogResult.OK;
        }
    }
}
