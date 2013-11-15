using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using Clinica_Frba.Clases;

namespace Clinica_Frba {
    public partial class LogIn : Form {

        public Usuario user;
        public Rol rol;
        private Roles roles = new Roles();
        private Usuario userTemp;

        public LogIn() {
            InitializeComponent();
        }

        private void bValidar_Click(object sender, EventArgs e) {
            
            //--Validar que haya valor en los campos
            if ((tbUsuario.Text != "") && (tbPassword.Text != "")) {

                //--Traer usuarios con ese user y pass
                Usuarios users = new Usuarios();
                try{
                    userTemp = users.VerifyUser(tbUsuario.Text, FuncionesBoludas.getHashSha256(tbPassword.Text));
                }catch (Exception ex) {
                    lIntentos.Text = (Convert.ToInt16(lIntentos.Text) + 1).ToString();
                    MessageBox.Show(ex.Message);
                    return;
                }
                
                roles.ClearList();
                roles.FillRolesByUser(userTemp.id);

                lbRoles.Items.Clear();
                lbRoles.Items.AddRange(roles.ToList());

                lbRoles.Enabled = true;
                bEntrar.Enabled = true;

            } else {
                MessageBox.Show("Faltan datos");
            }


        }

        private void bEntrar_Click(object sender, EventArgs e) {
            if (lbRoles.SelectedItems.Count < 1) {
                MessageBox.Show("Seleccione un rol");
                return;
            }
            rol = (Rol)lbRoles.SelectedItem;
            user = userTemp;

            DialogResult = DialogResult.OK;
        }

    }
}