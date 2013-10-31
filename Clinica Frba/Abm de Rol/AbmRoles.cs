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
            funcs.FillWithAll();
            lbFuncionalidades.Items.AddRange(funcs.ToList());
            FillDgvYLb();
        }

        private void bBuscar_Click(object sender, EventArgs e) {

            dgvRoles.Rows.Clear();

            roles.ClearList();
            roles.FillWithFilter(tbRol.Text, lbFuncionalidades.SelectedItems, cbHabilitado.Checked);

            foreach (Rol rol in roles.items)
                dgvRoles.Rows.Add(rol.id, rol.nombre, rol.funcionalidades, rol.habilitado);
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            if (dgvRoles.Columns[e.ColumnIndex].HeaderText == "Seleccionar") {
                Abm_de_Rol.EditRol formEdit = new Clinica_Frba.Abm_de_Rol.EditRol(roles[e.RowIndex]);
                formEdit.ShowDialog();

                if (formEdit.DialogResult == DialogResult.OK) {
                    FillDgvYLb();
                }
            }

        }

        private void bEliminar_Click(object sender, EventArgs e) {
            roles.DeleteSelected(dgvRoles, dgvRoles.SelectedRows);
        }

        private void bAgregar_Click(object sender, EventArgs e) {
            Abm_de_Rol.EditRol editForm = new Abm_de_Rol.EditRol();
            editForm.ShowDialog();

            if (editForm.DialogResult == DialogResult.OK)
            {
                FillDgvYLb();
            }

        }


        private void FillDgvYLb() {
            dgvRoles.Rows.Clear();
            roles = new Roles();
            roles.FillWithFilter(tbRol.Text, lbFuncionalidades.SelectedItems, cbHabilitado.Checked);

            foreach (Rol rol in roles.items)
                dgvRoles.Rows.Add(rol.id, rol.nombre, rol.funcionalidades, rol.habilitado);            

        }

    }
}
