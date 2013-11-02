using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.AbmAfiliados{
    public partial class EditAfiliado : Form {
        EstadosCiviles estadosCiviles = new EstadosCiviles();
        GruposFamiliares grupos = new GruposFamiliares();
        PlanesMedicos planes = new PlanesMedicos();

        private bool nueva;
        private bool tieneConyuge;
        private int usuarioID;
        private int afiliadoID;

        public string nombre;
        public string apellido;
        public string direccion;
        public string tipoDocumento;
        public decimal numeroDocumento;
        public decimal telefono;
        public string mail;
        public string nombreUsuario;
        public string sexo;
        public DateTime fechaNacimiento;
        public EstadoCivil estadoCivil;
        public PlanMedico planMedico;
        public GrupoFamiliar grupoFamiliar;
        public int orden = 0; //--0 significa NO titular

        /// <summary>
        /// Formulario para crear afiliado nuevo
        /// </summary>
        public EditAfiliado() {
            InitializeComponent();

            orden = 1;

            nueva = true;
        }

        /// <summary>
        /// Formulario para editar un afiliado
        /// </summary>
        /// <param name="p_afil">Afiliado a editar</param>
        public EditAfiliado(Afiliado p_afil){

            InitializeComponent();
            usuarioID = p_afil.usuario.id;
            afiliadoID = p_afil.id;

            nombre = p_afil.usuario.nombre;
            apellido = p_afil.usuario.apellido;
            direccion = p_afil.usuario.direccion;
            tipoDocumento = p_afil.usuario.tipoDocumento;
            numeroDocumento = p_afil.usuario.numeroDocumento;
            telefono = p_afil.usuario.telefono;
            mail = p_afil.usuario.mail;
            nombreUsuario = p_afil.usuario.nombreUsuario;
            sexo = p_afil.usuario.sexo;
            estadoCivil = p_afil.estadoCivil;
            planMedico = p_afil.planMedico;
            grupoFamiliar = p_afil.grupoFamiliar;
            orden = p_afil.orden;
            fechaNacimiento = p_afil.usuario.fechaNacimiento;

            tbNombre.Enabled = false;
            tbApellido.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
            tbNombreUsuario.Enabled = false;
            tbNumeroDni.Enabled = false;
            cmbTipoDNI.Enabled = false;
            cmbSexo.Enabled = false;         

            nueva = false;
        }

        private void EditAfiliado_Load(object sender, EventArgs e) {

            //--Llenar y cargar en comboBox's
            estadosCiviles.FillWithAll();
            cmbEstadoCivil.Items.AddRange(estadosCiviles.ToList());

            planes.FillWithAll();
            cmbPlanMedico.Items.AddRange(planes.ToList());

            //--Si no es nueva, poner los datos a modificar en los textBox
            if (!nueva) {

                tbNombre.Text = nombre;
                tbApellido.Text = apellido;
                tbDireccion.Text = direccion;
                cmbTipoDNI.SelectedItem = tipoDocumento;
                tbNumeroDni.Text = numeroDocumento.ToString();
                tbTelefono.Text = telefono.ToString();
                tbMail.Text = mail;
                tbNombreUsuario.Text = nombreUsuario;

                if (sexo == "M")
                    cmbSexo.SelectedItem = "Masculino";
                if (sexo == "F")
                    cmbSexo.SelectedItem = "Femenino";

                dtpFechaNacimiento.Value = fechaNacimiento;

                cmbEstadoCivil.SelectedItem = estadoCivil;
                cmbPlanMedico.SelectedItem = planMedico;

                //--Traer los integrantes del grupo
                foreach (DataRow dr in DB.ExecuteReader(
                    "SELECT * FROM moustache_spice.vAfiliado va WHERE va.afi_grupoFamiliar = " + grupoFamiliar.grupo + " AND va.afi_orden > 1 ORDER BY va.afi_grupoFamiliar ASC").Rows) {

                    //--Crea el integrante que trajo y lo agrega al listbox
                    Integrante integrante = new Integrante(dr);
                    lbIntegrantes.Items.Add(integrante);

                    //--Si algún integrante es conyuge, marca la flag
                    if (Convert.ToInt32(dr["afi_orden"]) == 2)
                        tieneConyuge = true;
                }
            }
        }

        private void bAgregarACargo_Click(object sender, EventArgs e) {
            //--Abrir ventana para agregar integrante
            EditIntegrante editForm = new EditIntegrante(tieneConyuge);
            editForm.ShowDialog();

            //--Si el diálogo tiene resultado OK, guardar el integrante en el listBox
            if (editForm.DialogResult == DialogResult.OK) {
                lbIntegrantes.Items.Add(editForm.integrante);

                //--Si el que agregó es conyuge, marcar que tiene conyuge
                if (editForm.integrante.esConyuge)
                    tieneConyuge = true;

            }
        }

        private void bGuardar_Click(object sender, EventArgs e) {

            string query;
            //--Grabar o editar al titular
            if (nueva) {
                query = "INSERT INTO moustache_spice.usuario(usu_nombre, usu_apellido, usu_direccion, usu_tipoDocumento, usu_numeroDocumento, usu_telefono, usu_mail, usu_sexo, usu_nombreUsuario, usu_fechaNacimiento ) VALUES " +
                        "('" + tbNombre.Text + "', '" + tbApellido.Text + "', '" + tbDireccion.Text + "', '" + cmbTipoDNI.SelectedText + "', " + tbNumeroDni.Text + ", " + tbTelefono.Text + ", '" + tbMail.Text + "', '" + cmbSexo.SelectedText + "', '" + tbNombreUsuario.Text + "', '" + dtpFechaNacimiento.Value.ToString("yyyy-MM-dd") + "'); ";
                query += "INSERT INTO moustache_spice.afiliado(afi_estadoCivil, afi_familiaresACargo, afi_usuario, afi_grupoFamiliar, afi_orden) VALUES ("+
                        ((EstadoCivil)cmbEstadoCivil.SelectedItem).id + ", " + lbIntegrantes.Items.Count + ", SCOPE_Identity(), 1)";
            } else {

                query = "UPDATE moustache_spice.usuario SET usu_direccion='" + tbDireccion +
                        ", usu_telefono=" + tbTelefono.Text +
                        ", usu_mail=" + tbMail.Text +
                        "' WHERE usu_id=" + usuarioID + "; ";
                query += "UPDATE moustache_spice.afiliado SET afi_estadoCivil=" + ((EstadoCivil)cmbEstadoCivil.SelectedItem).id +
                        ", afi_familiaresACargo=" + lbIntegrantes.Items.Count +
                        "' WHERE afi_id=" + afiliadoID + "; ";

            }
            DB.ExecuteNonQuery(query);

            //--Agregar a la DB a los integrantes que estén para grabar
            foreach (Integrante inte in lbIntegrantes.Items) {
                if (inte.faltaGrabar) {
                    //--Grabarlo
                    if (inte.esConyuge) {
                        //--********----------------****Acá le asignás el 2 en orden
                    } else {
                        //--********----------------****Acá tenés el próximo orden, bofi
                    }
                }
            }

            //--Si está todo piola
            DialogResult = DialogResult.OK;
        }
    }
}
