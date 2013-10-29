using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba
{
    public partial class Main : Form
    {

        Usuario user;
        Rol rol;
        Funcionalidades funcs = new Funcionalidades();

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            LogIn login = new LogIn();
            login.ShowDialog();

            //--Si se cerró el login sin usuario => cerrar ventana
            if (login.user == null)
                this.Close();

            user = login.user;
            rol = login.rol;
            funcs.FillByRol(rol.id);

            


        }

        private void bRoles_Click(object sender, EventArgs e) {
            AbmRoles.AbmRoles form = new Clinica_Frba.AbmRoles.AbmRoles();
        }
    }
}
