using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.AbmRoles {
    public partial class AbmRoles : Form {

        Roles roles;
        Funcionalidades funcs = new Funcionalidades();

        public AbmRoles() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            //--Completa con todas las funcionalidades y las agrega al listBox
            funcs.FillWithAll();
            lbFuncionalidades.Items.AddRange(funcs.ToList());

            FillDgv();
        }

        //--Click en el botón buscar
        private void bBuscar_Click(object sender, EventArgs e) {

            //--Vaciar lista entidad y dgv
            dgvRoles.Rows.Clear();
            roles.ClearList();

            //--Trae los roles aplicando el filtro y los llena en el dgv
            //roles.FillWithFilter(tbRol.Text, lbFuncionalidades.SelectedItems, cbHabilitado.Checked);
            FillDgv();

            foreach (Rol rol in roles.items)
                dgvRoles.Rows.Add(rol.id, rol.nombre, rol.funcionalidades, rol.habilitado);
        }

        //--Click en un elemento del dgv
        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            //--Si era en la columna de seleccionar (editar)
            if (dgvRoles.Columns[e.ColumnIndex].HeaderText == "Seleccionar") {
                //--Abrir ventana de edición mandando el rol seleccionado
                Abm_de_Rol.EditRol formEdit = new Clinica_Frba.Abm_de_Rol.EditRol(roles[dgvRoles.Rows[e.RowIndex].Cells["id"].Value.ToString()]);
                formEdit.ShowDialog();

                //--Si el resultado del diálogo es OK, recargar dgv
                if (formEdit.DialogResult == DialogResult.OK) {
                    FillDgv();
                }
            }

        }

        //--Click en el botón eliminar
        private void bEliminar_Click(object sender, EventArgs e) {
            //--Elimina los roles seleccionados
            roles.DeleteSelected(dgvRoles);
        }

        //--Click en el botón agregar rol
        private void bAgregar_Click(object sender, EventArgs e) {
            //--Abrir ventana de creación de rol
            Abm_de_Rol.EditRol editForm = new Abm_de_Rol.EditRol();
            editForm.ShowDialog();

            //--Si el resultado del diálogo es OK, recargar dgv
            if (editForm.DialogResult == DialogResult.OK) {
                FillDgv();
            }
        }

        /// <summary>
        /// Llena el dgv y la lista entidad con TODOS los roles
        /// </summary>
        private void FillDgv() {

            //--Traer todos los roles
            roles = new Roles();
            roles.FillWithFilter(tbRol.Text, lbFuncionalidades.SelectedItems, cbHabilitado.Checked);

            //--Limpiar dgv y volverlo a llenar
            dgvRoles.Rows.Clear();
            foreach (Rol rol in roles.items)
                dgvRoles.Rows.Add(rol.id, rol.nombre, rol.funcionalidades, rol.habilitado);

        }

    }
}