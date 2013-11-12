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

        //--Hotkeys para las funcionalidades
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            switch (keyData) {
                case (Keys.Control | Keys.A):
                    if (flp1.Controls.ContainsKey("Abm_afiliado"))
                        ((Button)flp1.Controls["Abm_afiliado"]).PerformClick();                    
                    break;
                case (Keys.Control | Keys.L):
                    if (flp1.Controls.ContainsKey("Abm_Planes_Medicos"))
                        ((Button)flp1.Controls["Abm_Planes_Medicos"]).PerformClick();  
                    break;
                case (Keys.Control | Keys.P):
                    if (flp1.Controls.ContainsKey("Abm_Profesional"))
                        ((Button)flp1.Controls["Abm_Profesional"]).PerformClick();  
                    break;
                case (Keys.Control | Keys.E):
                    if (flp1.Controls.ContainsKey("Abm_Especialidades_Medicas"))
                        ((Button)flp1.Controls["Abm_Especialidades_Medicas"]).PerformClick();  
                    break;
                case (Keys.Control | Keys.R):
                    if (flp1.Controls.ContainsKey("Abm_Rol"))
                        ((Button)flp1.Controls["Abm_Rol"]).PerformClick();  
                    break;
                case (Keys.Control | Keys.U):
                    if (flp1.Controls.ContainsKey("Abm_Usuario"))
                        ((Button)flp1.Controls["Abm_Usuario"]).PerformClick();  
                    break;
            }
            switch (keyData) {
                case (Keys.Shift | Keys.A):
                    if (flp2.Controls.ContainsKey("Agendas"))
                        ((Button)flp2.Controls["Agendas"]).PerformClick();
                    break;
                case (Keys.Shift | Keys.B):
                    if (flp2.Controls.ContainsKey("Bonos"))
                        ((Button)flp2.Controls["Bonos"]).PerformClick();
                    break;
                case (Keys.Shift | Keys.T):
                    if (flp2.Controls.ContainsKey("Turnos"))
                        ((Button)flp2.Controls["Turnos"]).PerformClick();
                    break;
                case (Keys.Shift | Keys.L):
                    if (flp2.Controls.ContainsKey("Registro_de_Llegada"))
                        ((Button)flp2.Controls["Registro_de_Llegada"]).PerformClick();
                    break;
                case (Keys.Shift | Keys.R):
                    if (flp2.Controls.ContainsKey("Registro_de_Resultado"))
                        ((Button)flp2.Controls["Registro_de_Resultado"]).PerformClick();
                    break;
                case (Keys.Shift | Keys.C):
                    if (flp2.Controls.ContainsKey("Cancelar_atencion"))
                        ((Button)flp2.Controls["Cancelar_atencion"]).PerformClick();
                    break;
                case (Keys.Shift | Keys.X):
                    if (flp2.Controls.ContainsKey("Receta"))
                        ((Button)flp2.Controls["Receta"]).PerformClick();
                    break;
                case (Keys.Shift | Keys.E):
                    if (flp2.Controls.ContainsKey("Estadisticas"))
                        ((Button)flp2.Controls["Estadisticas"]).PerformClick();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Turnos_Click(object sender, EventArgs e) {
            PedirTurno.PedirTurno form = new PedirTurno.PedirTurno(user);
            form.ShowDialog();
        }

        private void Cancelar_atencion_Click(object sender, EventArgs e) {
            if (rol.nombre == "Afiliado") {
                Cancelar_Atencion.CancelarAfiliado form = new Cancelar_Atencion.CancelarAfiliado(user);
                form.ShowDialog();
            } else {
                Cancelar_Atencion.CancelarProfesional form = new Cancelar_Atencion.CancelarProfesional(user);
                form.ShowDialog();
            }
        }

        private void Receta_Click(object sender, EventArgs e) {
            GenerarReceta.GenerarReceta form = new GenerarReceta.GenerarReceta();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK) {
                System.IO.File.WriteAllText(@"..\..\Recetas\receta" + form.GetHashCode() + ".html", form.reporte);
                System.Diagnostics.Process.Start(@"..\..\Recetas\receta" + form.GetHashCode() + ".html");
            }
        }
    }
}