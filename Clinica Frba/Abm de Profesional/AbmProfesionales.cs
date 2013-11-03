using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.AbmProfesionales {
    public partial class AbmProfesionales: Form {
        Profesionales profs = new Profesionales();
        Especialidades esps = new Especialidades();

        public AbmProfesionales() {
            InitializeComponent();
        }

        private void AbmProfesionales_Load(object sender, EventArgs e) {

            //--Llenar dgv con todos los afiliados
            FillDgv();

            //--Traer y llenar los listBox
            esps.FillWithAll();
            lbEspecialidades.Items.AddRange(esps.ToList());

        }

        //--Click en el botón buscar
        private void bBuscar_Click(object sender, EventArgs e) {
            FillDgv();
        }

        private void FillDgv() {

            //--Limpia lista entidad y la trae aplicando los filtros
            profs.ClearList();
            dgvProfesionales.Rows.Clear();

            profs.FillWithFilter(tbMatricula.Text,
                tbNombre.Text,
                tbApellido.Text,
                tbDireccion.Text,
                cmbTipoDNI.Text,
                Convert.ToInt64((tbNumeroDni.Text == "") ? "-1" : tbNumeroDni.Text),
                Convert.ToInt64((tbTelefono.Text == "") ? "-1" : tbTelefono.Text),
                tbMail.Text,
                tbNombreUsuario.Text,
                cmbSexo.Text,
                lbEspecialidades.SelectedItems,
                Convert.ToInt32(nLimit.Value));

            //--Llena dgv
            foreach (Profesional prof in profs.items) {
                dgvProfesionales.Rows.Add(prof.id, (prof.matricula == -1)? "Falta cargar": prof.matricula.ToString(),
                    prof.usuario.nombre, prof.usuario.apellido,
                    (prof.usuario.tipoDocumento == "") ? "Faltar cargar" : prof.usuario.tipoDocumento, prof.usuario.numeroDocumento,
                    prof.usuario.direccion, prof.usuario.telefono, prof.usuario.mail, prof.usuario.fechaNacimiento,
                    (prof.usuario.sexo == "") ? "Faltar cargar" : prof.usuario.sexo, prof.usuario.nombreUsuario,
                    prof.especialidades);
            }

        }
        
        //--Click en el botón de agregar
        private void bAgregar_Click(object sender, EventArgs e) {

            //--Abrir ventana para agregar afiliado
            EditProfesional editForm = new EditProfesional();
            editForm.ShowDialog();

            //--Si el diálogo tiene resultado OK, volver a llenar dgv
            if (editForm.DialogResult == DialogResult.OK) {
                FillDgv();
            }
        }


        private void dgvAfiliados_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            //--Abrir ventana para editar afiliado
            if (dgvProfesionales.Columns[e.ColumnIndex].HeaderText == "Seleccionar") {
                EditProfesional formEdit = new EditProfesional(profs[dgvProfesionales["id", e.RowIndex].Value.ToString()]);
                formEdit.ShowDialog();

                //--Si el diálogo tiene resultado OK, volver a llenar dgv
                if (formEdit.DialogResult == DialogResult.OK) {
                    FillDgv();
                }
            }
        }

        private void bEliminar_Click(object sender, EventArgs e) {

            //--Elimina los profesionales seleccionados
            if (MessageBox.Show("Está seguro de que desea eliminar los " + dgvProfesionales.SelectedRows.Count + " elementos seleccionados?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                profs.DeleteSelected(dgvProfesionales);
        }

        private void button1_Click(object sender, EventArgs e) {
            //Limpiar las cosa para buscar
            foreach (Control ctrl in gbFiltros.Controls) {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = "";
                if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedIndex = -1;
                if (ctrl is MaskedTextBox)
                    ((MaskedTextBox)ctrl).Text = "";
                if (ctrl is ListBox)
                    ((ListBox)ctrl).ClearSelected();
            }
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiar las cosa para buscar
            foreach (Control ctrl in gbFiltros.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = "";
                if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedIndex = -1;
                if (ctrl is MaskedTextBox)
                    ((MaskedTextBox)ctrl).Text = "";
                if (ctrl is ListBox)
                    ((ListBox)ctrl).ClearSelected();
            }
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