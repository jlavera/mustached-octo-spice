using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba {
    public partial class Main : Form {

        Usuario user;
        Rol rol;
        Funcionalidades funcs = new Funcionalidades();

        public Main() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            LogIn login = new LogIn();
            login.ShowDialog();

            //--Si se cerró el login sin usuario => cerrar ventana
            if (login.user == null || login.DialogResult != DialogResult.OK)
                Application.Exit();

            user = login.user;
            rol = login.rol;
            if(rol!=null)
                funcs.FillByRol(rol.id);

            foreach (Funcionalidad func in funcs.items) {
                if (flp1.Controls.ContainsKey(func.ToString()))
                    flp1.Controls[func.nombre].Visible = true;
                else
                    flp2.Controls[func.nombre].Visible = true;
            }
        }

        private void Abm_Roles_Click(object sender, EventArgs e) {
            AbmRoles.AbmRoles form = new AbmRoles.AbmRoles();
            form.ShowDialog();
        }

        private void Abm_Afiliado_Click(object sender, EventArgs e) {
            AbmAfiliados.AbmAfiliados form = new AbmAfiliados.AbmAfiliados();
            form.ShowDialog();
        }

        private void Abm_Profesional_Click(object sender, EventArgs e) {
            AbmProfesionales.AbmProfesionales form = new AbmProfesionales.AbmProfesionales();
			form.ShowDialog();
        }

        private void Abm_Planes_Medicos_Click(object sender, EventArgs e) {
            MessageBox.Show("Como la funcionalidad fue simplificada no es necesario realizar la implementación de este caso de uso pero si su modelado.");
        }

        private void Abm_Especialidades_Medicas_Click(object sender, EventArgs e) {
            MessageBox.Show("Para reducir el tiempo de desarrollo de los alumnos, no será necesario que realicen la implementación de dicho ABM.");
        }

        private void Agendas_Click(object sender, EventArgs e)
        {
            RegistrarAgendas.RegistrarAgendas form = new RegistrarAgendas.RegistrarAgendas();
            form.ShowDialog();
        }

        private void Abm_Usuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para reducir el tiempo de confección del TP y así beneficiar al alumno se determinó que no será necesario que se implemente/codifique el ABM de usuarios.");
        }
    }
}