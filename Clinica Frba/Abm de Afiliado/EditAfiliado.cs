using System;
using System.Collections.Generic;
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
        public Afiliado[] integrantes;

        public EditAfiliado() {
            InitializeComponent();

            orden = 1;

            nueva = true;
        }

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

        public EditAfiliado(int p_grupoFamiliar, int p_orden) {

            InitializeComponent();

            orden = 1;

            nueva = true;
        }

        private void EditAfiliado_Load(object sender, EventArgs e) {

            estadosCiviles.FillWithAll();
            cmbEstadoCivil.Items.AddRange(estadosCiviles.ToList());

            grupos.FillWithAll();
            cmbGrupoFamiliar.Items.AddRange(grupos.ToList());

            planes.FillWithAll();
            cmbPlanMedico.Items.AddRange(planes.ToList());

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

            }

            tbOrden.Text = orden.ToString();

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
            
            //--Si está todo piola
            DialogResult = DialogResult.OK;
        }

        private void bAgregarACargo_Click(object sender, EventArgs e) {


        }
    }
}
