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

        public string nombre;
        public string apellido;
        public string direccion;
        public string tipoDocumento;
        public decimal numeroDocumento;
        public decimal telefono;
        public string mail;
        public string nombreUsuario;
        public string sexo;
        public EstadoCivil estadoCivil;
        public PlanMedico planMedico;
        public GrupoFamiliar grupoFamiliar;
        public int orden = 0; //--0 significa NO titular
        ArrayList integrantes = new ArrayList();

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

            nueva = false;
        }

        /// <summary>
        /// Formulario para crear afiliado (integrante de un grupo)
        /// </summary>
        /// <param name="p_grupoFamiliar">Grupo familiar al que pertenece</param>
        /// <param name="p_orden">Orden que va a tener</param>
        public EditAfiliado(int p_grupoFamiliar, int p_orden) {

            InitializeComponent();

            nueva = true;
        }

        private void EditAfiliado_Load(object sender, EventArgs e) {

            //--Llenar y cargar en comboBox's
            estadosCiviles.FillWithAll();
            cmbEstadoCivil.Items.AddRange(estadosCiviles.ToList());

            grupos.FillWithAll();
            cmbGrupoFamiliar.Items.AddRange(grupos.ToList());

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

                cmbEstadoCivil.SelectedItem = estadoCivil;
                cmbPlanMedico.SelectedItem = planMedico;
                cmbGrupoFamiliar.SelectedItem = grupoFamiliar;

                tbOrden.Text = orden.ToString();

                //--Traer los integrantes del grupo y si alguno es conyuge, marcar la flag
                foreach (DataRow dr in DB.ExecuteReader(
                    "SELECT * FROM moustache_spice.vAfiliado va WHERE va.afi_grupoFamiliar = 0 ORDER BY va.afi_grupoFamiliar ASC").Rows) {
                    integrantes.Add(new Afiliado(dr));
                    if (Convert.ToInt32(dr["orden"]) == 2)
                        tieneConyuge = true;
                }
            }
        }

        private void bAgregarACargo_Click(object sender, EventArgs e) {
            //--Abrir ventana para agregar afiliado
            /*EditIntegrante editForm = new EditIntegrante(tieneConyuge);
            editForm.ShowDialog();

            //--Si el diálogo tiene resultado OK, guardar el afiliado
            if (editForm.DialogResult == DialogResult.OK) {
                DataTable dt = new DataTable();
                dt.Columns.Add("afi_id");
                dt.Columns.Add("afi_orden");
                dt.Columns.Add("afi_usuario");
                dt.Columns.Add("afi_estadoCivil");
                dt.Columns.Add("afi_familiaresACargo");
                dt.Columns.Add("afi_planMedico");
                dt.Columns.Add("afi_habilitado");

                dt.Columns.Add("usu_id");
                dt.Columns.Add("usu_nombreUsuario");
                dt.Columns.Add("usu_contrasegna");
                dt.Columns.Add("usu_intentosFallidos");
                dt.Columns.Add("usu_nombre");
                dt.Columns.Add("usu_apellido");
                dt.Columns.Add("usu_tipoDocumento");
                dt.Columns.Add("usu_numeroDocumento");
                dt.Columns.Add("usu_direccion");
                dt.Columns.Add("usu_telefono");
                dt.Columns.Add("usu_mail");
                dt.Columns.Add("usu_fechaNacimiento");
                dt.Columns.Add("usu_sexo");
                dt.Columns.Add("usu_habilitado");

                dt.Columns.Add("pla_id");
                dt.Columns.Add("pla_nombres");
                dt.Columns.Add("pla_codigo");
                dt.Columns.Add("pla_precioBonoConsulta");
                dt.Columns.Add("pla_precioBonoFarmacia");

                dt.Columns.Add("est_id");
                dt.Columns.Add("est_estado");

                DataRow dr = dt.NewRow();

                //TODO rellenar datarow con los datos creados, crear el afiliado, agregar a array de afiliados

                //--Si el que agregó es conyuge, marcar que tiene conyuge
                if (editForm.esConyuge)
                    tieneConyuge = true;

                lbIntegrantes.Items.Clear();
                foreach (Afiliado afil in integrantes)
                    lbIntegrantes.Items.Add(afil.orden.ToString("D2") + afil.usuario.apellido + ", " + afil.usuario.nombre);
            }*/

        }

        private void rbExistente_CheckedChanged(object sender, EventArgs e) {
            if (rbExistente.Checked)
                cmbGrupoFamiliar.Enabled = true;
            else
                cmbGrupoFamiliar.Enabled = false;
        }

        private void bGuardar_Click(object sender, EventArgs e) {
            if (nueva) {

                //--INSERT

            } else {

                //--UPDATE

            }
            

            //--TODO cuando guarda todo tiene que asignar los ordenes, y asignar al conyuge el 2

            //--Si está todo piola
            DialogResult = DialogResult.OK;
        }
    }
}
