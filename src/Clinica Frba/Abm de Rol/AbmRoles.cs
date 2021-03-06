﻿using System;
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
            FillDgv();
        }

        //--Click en un elemento del dgv
        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            //--Si era en la columna de seleccionar (editar)
            if (dgvRoles.Columns[e.ColumnIndex].HeaderText == "Seleccionar") {
                //--Abrir ventana de edición mandando el rol seleccionado
                Abm_de_Rol.EditRol formEdit = new Abm_de_Rol.EditRol(roles[dgvRoles.Rows[e.RowIndex].Cells["id"].Value.ToString()]);
                formEdit.ShowDialog();

                //--Si el resultado del diálogo es OK, recargar dgv
                if (formEdit.DialogResult == DialogResult.OK) {
                    FillDgv();
                }
            }

        }

        //--Click en el botón eliminar
        private void bEliminar_Click(object sender, EventArgs e) {
            if (dgvRoles.SelectedRows.Count == 0) {
                MessageBox.Show("No seleccionó ninguna fila.");
                return;
            }
            //--Elimina los roles seleccionados
            if (MessageBox.Show("Está seguro de que desea eliminar los " + dgvRoles.SelectedRows.Count + " elementos seleccionados?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
        /// Llena el dgv y la lista entidad con T0DOS los roles
        /// </summary>
        private void FillDgv() {

            //--Traer t0dos los roles
            roles = new Roles();
            roles.FillWithFilter(tbRol.Text, lbFuncionalidades.SelectedItems, cbHabilitado.Checked);

            //--Limpiar dgv y volverlo a llenar
            dgvRoles.Rows.Clear();
            foreach (Rol rol in roles.items)
                dgvRoles.Rows.Add(rol.id, rol.nombre, rol.concatFuncs(), rol.habilitado, "Editar");

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
                case (Keys.Control | Keys.Enter):
                    bBuscar.PerformClick();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void bLimpiar_Click(object sender, EventArgs e) {

            FuncionesBoludas.limpiarControles(gbFiltros.Controls);
        }

    }
}