using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.AbmProfesionales{
    public partial class EditProfesional: Form {

        private Especialidades esps = new Especialidades();

        private bool nueva;
        private int profId;
        
        public string nombre;
        public string apellido;
        public string direccion;
        public string tipoDocumento;
        public decimal numeroDocumento;
        public decimal telefono;
        public string mail;
        public string nombreUsuario;
        public string contrasegna;
        public string sexo;
        public DateTime fechaNacimiento;

        public string[] especialidades;


        /// <summary>
        /// Formulario para la creación de profesional nuevo
        /// </summary>
        public EditProfesional() {
            InitializeComponent();

            nueva = true;
        }

        /// <summary>
        /// Formulario para la edición de un profesional
        /// </summary>
        /// <param name="p_prof">Profesional a editar</param>
        public EditProfesional(Profesional p_prof) {
            InitializeComponent();

            profId = p_prof.id;

            nombre = p_prof.usuario.nombre;
            apellido = p_prof.usuario.apellido;
            direccion = p_prof.usuario.direccion;
            tipoDocumento = p_prof.usuario.tipoDocumento;
            numeroDocumento = p_prof.usuario.numeroDocumento;
            telefono = p_prof.usuario.telefono;
            mail = p_prof.usuario.mail;
            nombreUsuario = p_prof.usuario.nombreUsuario;
            contrasegna = p_prof.usuario.contrasegna;
            sexo = p_prof.usuario.sexo;
            fechaNacimiento = p_prof.usuario.fechaNacimiento;

            especialidades = p_prof.especialidadesLista;

            nueva = false;
        }

        private void EditProfesional_Load(object sender, EventArgs e) {
            esps.FillWithAll();
            lbEspecialidades.Items.AddRange(esps.ToList());

            if (!nueva) {

                tbNombre.Text = nombre;
                tbApellido.Text = apellido;
                tbDireccion.Text = direccion;
                tbMail.Text = mail;
                tbNombreUsuario.Text = nombreUsuario;
                tbContrasegna.Text = contrasegna;
                tbNumeroDni.Text = numeroDocumento.ToString();
                tbTelefono.Text = telefono.ToString();
                cmbSexo.SelectedItem = sexo;
                cmbTipoDNI.SelectedItem = tipoDocumento;
                dtpFechaNacimiento.Value = fechaNacimiento;
                tbContrasegna.Text = "****";

                foreach (string func in especialidades) {
                    for (int i = 0; i < lbEspecialidades.Items.Count; i++) {
                        if (func == lbEspecialidades.Items[i].ToString()) {
                            lbEspecialidades.SetSelected(i, true);
                            break;
                        }
                    }
                }

            }
        }

        private void bGuardar_Click(object sender, EventArgs e) {
            bool invalidez = false;
            foreach (Control ctrl in gbDatos.Controls) {
                if ((ctrl.Visible && ctrl is TextBox && ((TextBox)ctrl).Text == "") || (ctrl is MaskedTextBox && ((MaskedTextBox)ctrl).Text == "") || (ctrl is ComboBox && ((ComboBox)ctrl).SelectedIndex == -1)) {
                    invalidez = true;
                    ctrl.BackColor = Color.RosyBrown;
                }
            }
            if (invalidez)
                MessageBox.Show("Falta completar campos");
            else {
                string subQuery = "";
                foreach (Especialidad esp in lbEspecialidades.SelectedItems) {
                    subQuery += "(" + profId + ", " + esp.id + "), ";
                }
                //Comoconcatena con ", " le saco los ultimos dos caracteres al string
                if (lbEspecialidades.SelectedItems.Count > 0)
                    subQuery = subQuery.Substring(0, subQuery.Length - 2);


                if (nueva) {
                    //--Insertar Usuario
                    if (DB.ExecuteNonQuery("INSERT INTO " + DB.schema + "usuario " +
                        " (usu_nombre, usu_apellido, usu_tipoDocumento, usu_numeroDocumento, usu_direccion, usu_telefono, usu_mail, usu_fechaNacimiento, usu_sexo, usu_nombreUsuario, usu_contrasegna) " +
                        " VALUES " +
                        " ('" + tbNombre.Text + "', '" + tbApellido.Text + "', '" + cmbTipoDNI.Text + "', '" + tbNumeroDni.Text + "', '" + tbDireccion.Text + "', '" + tbTelefono.Text + "', '" + tbMail.Text + "', '" + dtpFechaNacimiento.Value + "', '" + cmbSexo.Text + "', '" + tbNombreUsuario.Text + "', '" + tbContrasegna.Text + "', );") < 0) {
                        MessageBox.Show("Error en inserscion de usuario");
                        return;
                    }

                    /********FALTAN MODIFICAR TODOS ESTOS QUERYS**********/
                    //--Insertar Profesional
                    if (DB.ExecuteNonQuery("INSERT INTO " + DB.schema + "profesional " +
                        " (rol_nombre) " +
                        " VALUES " +
                        " ('" + tbNombre.Text + "');") < 0) {
                        MessageBox.Show("Error en inserscion de profesional");
                        return;
                    }
                } else {
                    //Es mas facil borrar todos los rol_x_funcionalidad que revisar cuales cambiaron
                    if (DB.ExecuteNonQuery("DELETE " + DB.schema + "rol_x_funcionalidad WHERE rxf_rol=" + profId + "; " +
                                            "UPDATE " + DB.schema + "rol SET rol_nombre='" + tbNombre.Text + "', rol_habilitado=" + Convert.ToInt32(true) + " WHERE rol_id=" + profId) < 0)
                        MessageBox.Show("Error en modificacion de rol");
                }
                if (lbEspecialidades.SelectedItems.Count > 0) {
                    if (DB.ExecuteNonQuery("INSERT INTO " + DB.schema + "rol_x_funcionalidad(rxf_funcionalidad, rxf_rol) VALUES " + subQuery) < 0)
                        MessageBox.Show("Error en inserscion de rol_x_funcionalidad");
                }

                /********HASTA ACA**************/

                this.Close();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
