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
                userTemp = users.VerifyUser(tbUsuario.Text, tbPassword.Text);

                //--Si hay más de 0
                if (userTemp == null) {
                    MessageBox.Show("Fail");

                    return;
                }

                MessageBox.Show("Success");

                roles.FillRolesByUser(user.id);
                lbRoles.Items.AddRange(roles.ToList());

            }
        }

        private void bEntrar_Click(object sender, EventArgs e) {

            rol = (Rol)lbRoles.SelectedItem;
            user = userTemp;

            this.Close();
        }

        public static string getHashSha256(string text) {

            SHA256Managed hashstring = new SHA256Managed();

            byte[] bytes = Encoding.Unicode.GetBytes(text);
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;

            foreach (byte x in hash) {
                hashString += String.Format("{0:x2}", x);
            }

            return hashString;
        }
    }
}