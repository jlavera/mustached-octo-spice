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
                EditAfiliado formEdit = new EditAfiliado(afiliados[dgvAfiliados.Rows[e.RowIndex].Cells["id"].Value.ToString()]);
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
                Convert.ToInt64((tbNumeroDni.Text == "") ? "-1" : tbNumeroDni.Text),
                Convert.ToInt64((tbTelefono.Text == "") ? "-1" : tbTelefono.Text),
                tbMail.Text,
                tbNombreUsuario.Text,
                cmbSexo.Text,
                lbGrupoFamiliar.SelectedItems,
                lbEstadoCivil.SelectedItems,
                lbPlanMedico.SelectedItems,
                Convert.ToInt32((tbOrden.Text == "") ? "-1" : tbOrden.Text),
                Convert.ToInt32((tbFamiliaresACargo.Text == "") ? "-1" : tbFamiliaresACargo.Text),
                Convert.ToInt32(nLimit.Value));

            //--Llena dgv
            foreach (Afiliado afiliado in afiliados.items) {
                dgvAfiliados.Rows.Add(afiliado.grupoFamiliar.grupo.ToString("D6") + "-" + afiliado.orden.ToString("D2"),
                    afiliado.usuario.nombre, afiliado.usuario.apellido,
                    (afiliado.usuario.tipoDocumento == "") ? "Faltar cargar" : afiliado.usuario.tipoDocumento, afiliado.usuario.numeroDocumento,
                    afiliado.usuario.direccion, afiliado.usuario.telefono, afiliado.usuario.mail, afiliado.usuario.fechaNacimiento,
                    (afiliado.usuario.sexo == "") ? "Faltar cargar" : afiliado.usuario.sexo, afiliado.usuario.nombreUsuario,
                    (afiliado.estadoCivil.nombre == "") ? "Falta cargar" : afiliado.estadoCivil.ToString(),
                    (afiliado.familiaresACargo == -1) ? "Falta cargar" : afiliado.familiaresACargo.ToString(), afiliado.planMedico.nombre,
                    "Editar", afiliado.id);
            }
        }

        private void bEliminar_Click(object sender, EventArgs e) {

            if (MessageBox.Show("Está seguro de que desea eliminar los " + dgvAfiliados.SelectedRows.Count + " elementos seleccionados?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //--Elimina los roles seleccionados
                afiliados.DeleteSelected(dgvAfiliados);
        }

        private void bLimpiar_Click(object sender, EventArgs e) {
            FuncionesBoludas.limpiarControles(gbFiltros.Controls);
        }

        //--Hotkeys para las funcionalidades
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            switch (keyData) {
                case (Keys.Control | Keys.A):
                    bAgregar.PerformClick();
                    break;
                case (Keys.Control | Keys.Delete):
                    bEliminar.PerformClick();
                    break;
                case (Keys.Control | Keys.L):
                    bLimpiar.PerformClick();
                    break;
                case (Keys.Control | Keys.Enter):
                    bBuscar.PerformClick();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}