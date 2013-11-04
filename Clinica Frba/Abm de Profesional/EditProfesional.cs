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

        private Especialidades especialidades = new Especialidades();
        private Especialidades esps = new Especialidades();

        private bool nueva;
        private int profId;
        private int usuarioID;
        
        public string nombre;
        public string apellido;
        public string direccion;
        public string tipoDocumento;
        public decimal numeroDocumento;
        public decimal telefono;
        public decimal matricula;
        public string mail;
        public string nombreUsuario;
        public string contrasegna;
        public string sexo;
        public DateTime fechaNacimiento;

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
            usuarioID = p_prof.usuario.id;

            nombre = p_prof.usuario.nombre;
            apellido = p_prof.usuario.apellido;
            direccion = p_prof.usuario.direccion;
            tipoDocumento = p_prof.usuario.tipoDocumento;
            numeroDocumento = p_prof.usuario.numeroDocumento;
            telefono = p_prof.usuario.telefono;
            mail = p_prof.usuario.mail;
            nombreUsuario = p_prof.usuario.nombreUsuario;
            contrasegna = p_prof.usuario.contrasegna;
            sexo = (p_prof.usuario.sexo == "M") ? "Masculino" : ((p_prof.usuario.sexo == "F") ? "Femenino" : "");
            fechaNacimiento = p_prof.usuario.fechaNacimiento;
            matricula = p_prof.matricula;

            especialidades = p_prof.especialidades;

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
                cmbSexo.Text = sexo;
                dtpFechaNacimiento.Value = fechaNacimiento;
                tbContrasegna.Text = "****";

                if (matricula != -1)
                {
                    tbMatricula.Enabled = false;
                    tbMatricula.Text = matricula.ToString();
                }
                if (tipoDocumento != "")
                {
                    cmbTipoDNI.SelectedItem = tipoDocumento;
                    cmbTipoDNI.Enabled = false;
                }
                tbNombre.Enabled = false;
                tbApellido.Enabled = false;
 
                tbNumeroDni.Enabled = false;

                foreach (Especialidad esp in especialidades.items) {
                    for (int i = 0; i < lbEspecialidades.Items.Count; i++) {
                        if (esp.Equals(lbEspecialidades.Items[i])) {
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
                if (nueva) {
                    //--Insertar Usuario
                    profId = DB.ExecuteCardinal("SELECT IDENT_CURRENT('" + DB.schema + "profesional')")+1;

                    if (DB.ExecuteNonQuery("INSERT INTO " + DB.schema + "usuario " +
                        " (usu_nombre, usu_apellido, usu_tipoDocumento, usu_numeroDocumento, usu_direccion, usu_telefono, usu_mail, usu_fechaNacimiento, usu_sexo, usu_nombreUsuario, usu_contrasegna) " +
                        " VALUES " +
                        " ('" + tbNombre.Text + "', '" + tbApellido.Text + "', '" + cmbTipoDNI.Text + "', " + tbNumeroDni.Text + ", '" + tbDireccion.Text + "', " + tbTelefono.Text + ", '" + tbMail.Text + "', '" + dtpFechaNacimiento.Value + "', '" + ((cmbSexo.Text  == "Masculino") ? "M" : "F") + "', '" + tbNombreUsuario.Text + "', '" + FuncionesBoludas.getHashSha256(tbContrasegna.Text) + "');") < 0) {
                        MessageBox.Show("Error en inserscion de usuario");
                        return;
                    }

                    /********(no) FALTAN MODIFICAR TODOS ESTOS QUERYS**********/
                    //--Insertar Profesional
                    if (DB.ExecuteNonQuery("INSERT INTO " + DB.schema + "profesional " +
                        " (pro_matricula, pro_usuario) " +
                        " VALUES " +
                        " ('" + tbMatricula.Text + "', IDENT_CURRENT('" + DB.schema + "usuario') );") < 0)
                    {
                        MessageBox.Show("Error en inserscion de profesional");
                        return;
                    }
                } else {
                    //Update del profesional
                    if (DB.ExecuteNonQuery(
                    "UPDATE " + DB.schema + "profesional SET " +
                            "pro_matricula=" + tbMatricula.Text +
                            " WHERE pro_id=" + profId + "; " +
                    "UPDATE moustache_spice.usuario SET usu_direccion='" + tbDireccion.Text + "'" +
                            ", usu_telefono=" + tbTelefono.Text +
                            ", usu_mail='" + tbMail.Text + "' " +
                            ", usu_tipoDocumento='" + cmbTipoDNI.Text + "' " +
                            ((tbContrasegna.Text == "****") ? "" : (", usu_contrasegna='" + FuncionesBoludas.getHashSha256(tbContrasegna.Text) + "' ")) +
                            ", usu_sexo='" + ((cmbSexo.Text == "Masculino") ? "M" : "F") + "' " +
                            "WHERE usu_id=" + usuarioID + "; ") < 0)
                        MessageBox.Show("Error en modificacion del profesional");

                    //Es mas facil borrar todos los profesional_x_especialidad que revisar cuales cambiaron
                    if (DB.ExecuteNonQuery("DELETE " + DB.schema + "profesional_x_especialidad WHERE pxe_profesional=" + profId + "; ") < 0)
                        MessageBox.Show("Error en modificacion de rol_x_funcionalidad");
                }
                if (lbEspecialidades.SelectedItems.Count > 0) {
                    string subQuery = "";
                    foreach (Especialidad esp in lbEspecialidades.SelectedItems)
                    {
                        subQuery += "(" + profId + ", " + esp.id + "), ";
                    }
                    //Comoconcatena con ", " le saco los ultimos dos caracteres al string
                    if (lbEspecialidades.SelectedItems.Count > 0)
                        subQuery = subQuery.Substring(0, subQuery.Length - 2);

                    if (DB.ExecuteNonQuery("INSERT INTO " + DB.schema + "profesional_x_especialidad(pxe_profesional, pxe_especialidad) VALUES " + subQuery) < 0)
                        MessageBox.Show("Error en inserscion de rol_x_funcionalidad");
                }

                this.Close();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
