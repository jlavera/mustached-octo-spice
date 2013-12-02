using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.AbmAfiliados {
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
        public int planViejo; //Para guardar el plan viejo y auditarlo
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
        public EditAfiliado(Afiliado p_afil) {

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
            planViejo = planMedico.id;
            grupoFamiliar = p_afil.grupoFamiliar;
            orden = p_afil.orden;
            fechaNacimiento = p_afil.usuario.fechaNacimiento;

            tbNombre.Enabled = false;
            tbApellido.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
            tbNombreUsuario.Enabled = false;
            tbNumeroDni.Enabled = false;
            if (orden > 1) {
                lbIntegrantes.Enabled = false;
                bAgregarACargo.Enabled = false;
                cmbPlanMedico.Enabled = false;
            }

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

                if (orden > 1)
                    bAgregarACargo.Enabled = false;
                else
                    bCambiarGrupo.Enabled = false;

                tbNombre.Text = nombre;
                tbApellido.Text = apellido;
                tbDireccion.Text = direccion;
                cmbTipoDNI.Text = tipoDocumento;
                tbNumeroDni.Text = numeroDocumento.ToString();
                tbTelefono.Text = telefono.ToString();
                tbMail.Text = mail;
                tbNombreUsuario.Text = nombreUsuario;

                if (sexo == "M")
                    cmbSexo.SelectedItem = "Masculino";
                if (sexo == "F")
                    cmbSexo.SelectedItem = "Femenino";

                dtpFechaNacimiento.Value = fechaNacimiento;
                tbContrasegna.Text = "****";

                cmbEstadoCivil.SelectedItem = estadoCivil;
                cmbPlanMedico.SelectedItem = planMedico;
                //Tengo que hacerlos invisibles aca, porque sino salta el evento
                tbRazon.Visible = false;
                label13.Visible = false;

                //--Traer los integrantes del grupo
                foreach (DataRow dr in DB.ExecuteReader(
                    "SELECT * FROM " + DB.schema + "vAfiliado va WHERE va.afi_grupoFamiliar = " + grupoFamiliar.grupo).Rows) {

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
            EditIntegrante editForm = new EditIntegrante(tieneConyuge, telefono.ToString(), direccion, apellido);
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
            if (FuncionesBoludas.policia(gbDatos.Controls)){

                string query;
                //--Grabar o editar al titular
                if (nueva) {
                    query = "INSERT INTO " + DB.schema + "usuario(usu_nombre, usu_apellido, usu_direccion, usu_tipoDocumento, usu_numeroDocumento, usu_telefono, usu_mail, usu_sexo, usu_nombreUsuario, usu_fechaNacimiento" + ((tbContrasegna.Text == "****") ? "" : ", usu_contrasegna") + ") VALUES " +
                            "('" + tbNombre.Text + "', '" + tbApellido.Text + "', '" + tbDireccion.Text + "', '" + cmbTipoDNI.Text + "', " + tbNumeroDni.Text + ", " + tbTelefono.Text + ", '" + tbMail.Text + "', '" + ((cmbSexo.SelectedText == "Masculino") ? "M" : "F") + "', '" + tbNombreUsuario.Text + "', '" + dtpFechaNacimiento.Value.ToString("yyyy-MM-dd") + "'" + ((tbContrasegna.Text == "****") ? "" : ", '" + FuncionesBoludas.getHashSha256(tbContrasegna.Text) + "'") + "); ";
                    query += "INSERT INTO " + DB.schema + "afiliado(afi_estadoCivil, afi_familiaresACargo, afi_usuario, afi_orden, afi_planMedico) VALUES (" +
                            ((EstadoCivil)cmbEstadoCivil.SelectedItem).id + ", " + nFamiliares.Value + ", SCOPE_Identity(), 1, " + ((PlanMedico)cmbPlanMedico.SelectedItem).id + "); ";

                    //Donde vas a insertar el padre
                    afiliadoID = DB.ExecuteCardinal("SELECT IDENT_CURRENT('" + DB.schema + "afiliado')");
                } else {

                    query = "UPDATE " + DB.schema + "usuario SET usu_direccion='" + tbDireccion.Text + "'" +
                            ", usu_telefono=" + tbTelefono.Text +
                            ", usu_mail='" + tbMail.Text + "' " +
                            ", usu_tipoDocumento='" + cmbTipoDNI.Text + "' " +
                            ((tbContrasegna.Text == "****") ? "" : (", usu_contrasegna='" + FuncionesBoludas.getHashSha256(tbContrasegna.Text) + "' ")) +
                            ", usu_sexo='" + ((cmbSexo.SelectedText == "Masculino") ? "M" : "F") + "' " +
                            "WHERE usu_id=" + usuarioID + "; ";
                    query += "UPDATE " + DB.schema + "afiliado SET afi_estadoCivil=" + ((EstadoCivil)cmbEstadoCivil.SelectedItem).id +
                             ", afi_planMedico=" + ((PlanMedico)cmbPlanMedico.SelectedItem).id +
                             ", afi_familiaresACargo=" + nFamiliares.Value +
                             " WHERE afi_id=" + afiliadoID + "; ";

                }

                //--Agregar a la DB a los integrantes que estén para grabar
                int ordenInsertado = 1;
                foreach (Integrante inte in lbIntegrantes.Items) {
                    ordenInsertado++;
                    if (inte.faltaGrabar) {
                        //--Grabarlo
                        query += "INSERT INTO " + DB.schema + "usuario(usu_nombre, usu_apellido, usu_direccion, usu_tipoDocumento, usu_numeroDocumento, usu_telefono, usu_mail, usu_sexo, usu_nombreUsuario, usu_fechaNacimiento, usu_contrasegna) VALUES " +
                                "('" + inte.nombre + "', '" + inte.apellido + "', '" + inte.direccion + "', '" + inte.tipoDocumento + "', " + inte.numeroDocumento + ", " + inte.telefono + ", '" + inte.mail + "', '" + inte.sexo + "', '" + inte.nombreUsuario + "', '" + inte.fechaNacimiento + "', '" + FuncionesBoludas.getHashSha256(inte.contrasegna) + "'); ";
                        query += "INSERT INTO " + DB.schema + "afiliado(afi_estadoCivil, afi_usuario, afi_orden, afi_planMedico, afi_grupoFamiliar2, afi_familiaresACargo) VALUES (" +
                            inte.estadoCivil.id + ", SCOPE_Identity(), " + ((inte.esConyuge) ? 2 : ordenInsertado) + ", " + ((PlanMedico)cmbPlanMedico.SelectedItem).id + ", " + afiliadoID + ", " + inte.familiares  + "); ";
                    }
                }
                if (tbRazon.Visible)
                    query += " INSERT INTO " + DB.schema + "planMedicoAudit(grA_afiliado, grA_plan_medicoViejo, grA_razon) VALUES(" + afiliadoID + ", " + planViejo + ", '" + tbRazon.Text + "'); ";
                if (DB.ExecuteNonQuery(query) == -1) {
                    MessageBox.Show("Error en la insercion, probablemente algun campo unico este repetido");
                    DialogResult = DialogResult.Cancel;
                }
                //--Si está t0do piola
                DialogResult = DialogResult.OK;
            }

        }

        private void bCambiarGrupo_Click(object sender, EventArgs e) {
            CambiarGrupo formCamb = new CambiarGrupo(grupoFamiliar, afiliadoID);
            formCamb.ShowDialog();
            if (formCamb.DialogResult == DialogResult.OK) {
                if (!formCamb.nueva) {
                    //--Traer los integrantes del grupo
                    foreach (DataRow dr in DB.ExecuteReader(
                        "SELECT * FROM " + DB.schema + "vAfiliado va WHERE va.afi_grupoFamiliar = " + grupoFamiliar.grupo + " ORDER BY va.afi_grupoFamiliar ASC").Rows) {

                        //--Crea el integrante que trajo y lo agrega al listbox
                        Integrante integrante = new Integrante(dr);
                        lbIntegrantes.Items.Add(integrante);

                        //--Si algún integrante es conyuge, marca la flag
                        if (Convert.ToInt32(dr["afi_orden"]) == 2)
                            tieneConyuge = true;

                        //--Bloquear agregar integrantes
                        bAgregarACargo.Enabled = false;
                    }
                } else
                    bAgregarACargo.Enabled = true;
                DialogResult = DialogResult.OK;
            }
        }

        private void cmbPlanMedico_SelectedIndexChanged(object sender, EventArgs e) {
            if (!nueva) {
                label13.Visible = true;
                tbRazon.Visible = true;
            }
        }
    }
}