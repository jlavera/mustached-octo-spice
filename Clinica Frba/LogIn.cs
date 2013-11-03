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
                userTemp = users.VerifyUser(tbUsuario.Text, FuncionesBoludas.getHashSha256(tbPassword.Text));

                //--Si hay más de 0
                if (userTemp == null) {
                    MessageBox.Show("Fail");

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

            rol = (Rol)lbRoles.SelectedItem;
            user = userTemp;

            DialogResult = DialogResult.OK;
        }

        private void LogIn_Load(object sender, EventArgs e) {
            //MessageBox.Show(DateTime.Now.ToString());
            //FuncionesBoludas.SetDateTime(DateTime.Now);
            //MessageBox.Show(FuncionesBoludas.GetDateTime().ToString());
        }

    }
}