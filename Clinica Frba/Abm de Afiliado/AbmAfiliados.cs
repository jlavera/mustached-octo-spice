using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.AbmAfiliados {
    public partial class AbmAfiliados : Form {
        Afiliados afiliados = new Afiliados();
        EstadosCiviles estadosCiviles = new EstadosCiviles();
        GruposFamiliares grupos = new GruposFamiliares();
        PlanesMedicos planes = new PlanesMedicos();

        public AbmAfiliados() {
            InitializeComponent();
        }

        private void AbmAfiliados_Load(object sender, EventArgs e) {

            //--Llenar dgv con todos los afiliados
            FillDgv();

            //--Traer y llenar los listBox
            estadosCiviles.FillWithAll();
            lbEstadoCivil.Items.AddRange(estadosCiviles.ToList());

            grupos.FillWithAll();
            lbGrupoFamiliar.Items.AddRange(grupos.ToList());

            planes.FillWithAll();
            lbPlanMedico.Items.AddRange(planes.ToList());

        }

        //--Click en el botón buscar
        private void bBuscar_Click(object sender, EventArgs e) {
            FillDgv();
        }

        //--Click en el botón de agregar
        private void bAgregar_Click(object sender, EventArgs e) {

            //--Abrir ventana para agregar afiliado
            EditAfiliado editForm = new EditAfiliado();
            editForm.ShowDialog();

            //--Si el diálogo tiene resultado OK, volver a llenar dgv
            if (editForm.DialogResult == DialogResult.OK) {
                FillDgv();
            }
        }

        private void dgvAfiliados_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            //--Abrir ventana para editar afiliado
            if (dgvAfiliados.Columns[e.ColumnIndex].HeaderText == "Seleccionar") {
                EditAfiliado formEdit = new EditAfiliado(afiliados[e.RowIndex]);
                formEdit.ShowDialog();

                //--Si el diálogo tiene resultado OK, volver a llenar dgv
                if (formEdit.DialogResult == DialogResult.OK) {
                    FillDgv();
                }
            }
        }

        //--Llenar dgv con todos los afiliados
        private void FillDgv() {

            //--Limpia lista entidad y la trae aplicando los filtros
            afiliados.ClearList();
            dgvAfiliados.Rows.Clear();

            afiliados.FillWithFilter(tbNombre.Text,
                tbApellido.Text,
                tbDireccion.Text,
                cmbTipoDNI.Text,
                Convert.ToInt64((tbNumeroDni.Text == "")? "-1" : tbNumeroDni.Text),
                Convert.ToInt64((tbTelefono.Text == "") ? "-1" : tbTelefono.Text),
                tbMail.Text,
                tbNombreUsuario.Text,
                cmbSexo.SelectedText.ToString(),
                lbGrupoFamiliar.SelectedItems, 
                lbEstadoCivil.SelectedItems,
                lbPlanMedico.SelectedItems,
                Convert.ToInt32((tbOrden.Text == "") ? "-1" : tbOrden.Text),
                Convert.ToInt32((tbFamiliaresACargo.Text == "") ? "-1" : tbFamiliaresACargo.Text));
            //--Llena dgv
            foreach (Afiliado afiliado in afiliados.items) {
                dgvAfiliados.Rows.Add(afiliado.grupoFamiliar.grupo.ToString("D5") + "-" + afiliado.orden.ToString("D2"),
                    afiliado.usuario.nombre, afiliado.usuario.apellido,
                    (afiliado.usuario.tipoDocumento == "") ? "Faltar cargar" : afiliado.usuario.tipoDocumento, afiliado.usuario.numeroDocumento,
                    afiliado.usuario.direccion, afiliado.usuario.telefono, afiliado.usuario.mail, afiliado.usuario.fechaNacimiento,
                    (afiliado.usuario.sexo == "") ? "Faltar cargar" : afiliado.usuario.sexo, afiliado.usuario.nombreUsuario,
                    (afiliado.estadoCivil.nombre == "") ? "Falta cargar" : afiliado.estadoCivil.ToString(),
                    (afiliado.familiaresACargo == -1) ? "Falta cargar" : afiliado.familiaresACargo.ToString(), afiliado.planMedico.nombre);
            }
        }

        private void bEliminar_Click(object sender, EventArgs e) {

            //--Elimina los roles seleccionados
            afiliados.DeleteSelected(dgvAfiliados);
        }
    }
}