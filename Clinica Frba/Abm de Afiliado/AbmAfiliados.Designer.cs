﻿namespace Clinica_Frba.AbmAfiliados
{
    partial class AbmAfiliados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bEliminar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.lbGrupoFamiliar = new System.Windows.Forms.ListBox();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.tbOrden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoDNI = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNumeroDni = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbFamiliaresACargo = new System.Windows.Forms.TextBox();
            this.cmbPlanMedico = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoFamiliar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiaresACargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(189, 198);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(134, 29);
            this.bEliminar.TabIndex = 9;
            this.bEliminar.Text = "Eliminar seleccionados";
            this.bEliminar.UseVisualStyleBackColor = true;
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(12, 198);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(134, 29);
            this.bAgregar.TabIndex = 8;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            // 
            // bBuscar
            // 
            this.bBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bBuscar.Location = new System.Drawing.Point(1111, 198);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(91, 29);
            this.bBuscar.TabIndex = 7;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltros.Controls.Add(this.cmbPlanMedico);
            this.gbFiltros.Controls.Add(this.label14);
            this.gbFiltros.Controls.Add(this.label13);
            this.gbFiltros.Controls.Add(this.tbFamiliaresACargo);
            this.gbFiltros.Controls.Add(this.cmbEstadoCivil);
            this.gbFiltros.Controls.Add(this.label12);
            this.gbFiltros.Controls.Add(this.cmbSexo);
            this.gbFiltros.Controls.Add(this.label11);
            this.gbFiltros.Controls.Add(this.label10);
            this.gbFiltros.Controls.Add(this.tbNombreUsuario);
            this.gbFiltros.Controls.Add(this.label9);
            this.gbFiltros.Controls.Add(this.tbMail);
            this.gbFiltros.Controls.Add(this.label8);
            this.gbFiltros.Controls.Add(this.textBox6);
            this.gbFiltros.Controls.Add(this.label7);
            this.gbFiltros.Controls.Add(this.tbNumeroDni);
            this.gbFiltros.Controls.Add(this.cmbTipoDNI);
            this.gbFiltros.Controls.Add(this.label6);
            this.gbFiltros.Controls.Add(this.label5);
            this.gbFiltros.Controls.Add(this.tbDireccion);
            this.gbFiltros.Controls.Add(this.label4);
            this.gbFiltros.Controls.Add(this.tbApellido);
            this.gbFiltros.Controls.Add(this.label3);
            this.gbFiltros.Controls.Add(this.tbNombre);
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Controls.Add(this.tbOrden);
            this.gbFiltros.Controls.Add(this.lbGrupoFamiliar);
            this.gbFiltros.Location = new System.Drawing.Point(12, 12);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(1190, 180);
            this.gbFiltros.TabIndex = 6;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // lbGrupoFamiliar
            // 
            this.lbGrupoFamiliar.DisplayMember = "id";
            this.lbGrupoFamiliar.FormattingEnabled = true;
            this.lbGrupoFamiliar.Location = new System.Drawing.Point(531, 40);
            this.lbGrupoFamiliar.Name = "lbGrupoFamiliar";
            this.lbGrupoFamiliar.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbGrupoFamiliar.Size = new System.Drawing.Size(113, 121);
            this.lbGrupoFamiliar.TabIndex = 3;
            this.lbGrupoFamiliar.ValueMember = "id";
            // 
            // dgvRoles
            // 
            this.dgvRoles.AllowUserToAddRows = false;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.tipoDocumento,
            this.numeroDocumento,
            this.direccion,
            this.telefono,
            this.mail,
            this.fechaNacimiento,
            this.sexo,
            this.nombreUsuario,
            this.grupoFamiliar,
            this.orden,
            this.estadoCivil,
            this.familiaresACargo,
            this.planMedico});
            this.dgvRoles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRoles.Location = new System.Drawing.Point(0, 233);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.Size = new System.Drawing.Size(1212, 356);
            this.dgvRoles.TabIndex = 5;
            // 
            // tbOrden
            // 
            this.tbOrden.Location = new System.Drawing.Point(688, 40);
            this.tbOrden.Name = "tbOrden";
            this.tbOrden.Size = new System.Drawing.Size(140, 20);
            this.tbOrden.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grupo familiar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Orden:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(22, 40);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(140, 20);
            this.tbNombre.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Apellido:";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(22, 83);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(140, 20);
            this.tbApellido.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dirección:";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(22, 126);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(140, 20);
            this.tbDireccion.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tipo de documento:";
            // 
            // cmbTipoDNI
            // 
            this.cmbTipoDNI.FormattingEnabled = true;
            this.cmbTipoDNI.Items.AddRange(new object[] {
            "DNI",
            "LE",
            "LC"});
            this.cmbTipoDNI.Location = new System.Drawing.Point(192, 40);
            this.cmbTipoDNI.Name = "cmbTipoDNI";
            this.cmbTipoDNI.Size = new System.Drawing.Size(42, 21);
            this.cmbTipoDNI.TabIndex = 14;
            this.cmbTipoDNI.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDNI_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Número de documento:";
            // 
            // tbNumeroDni
            // 
            this.tbNumeroDni.Location = new System.Drawing.Point(190, 83);
            this.tbNumeroDni.Name = "tbNumeroDni";
            this.tbNumeroDni.Size = new System.Drawing.Size(140, 20);
            this.tbNumeroDni.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Teléfono:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(190, 126);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(140, 20);
            this.textBox6.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Mail:";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(360, 40);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(140, 20);
            this.tbMail.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(344, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Nombre de usuario:";
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.Location = new System.Drawing.Point(360, 83);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(140, 20);
            this.tbNombreUsuario.TabIndex = 21;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(362, 126);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(86, 21);
            this.cmbSexo.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(344, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Sexo:";
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(690, 83);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(98, 21);
            this.cmbEstadoCivil.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(672, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Estado civil:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(672, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Familiares a cargo:";
            // 
            // tbFamiliaresACargo
            // 
            this.tbFamiliaresACargo.Location = new System.Drawing.Point(688, 126);
            this.tbFamiliaresACargo.Name = "tbFamiliaresACargo";
            this.tbFamiliaresACargo.Size = new System.Drawing.Size(140, 20);
            this.tbFamiliaresACargo.TabIndex = 27;
            // 
            // cmbPlanMedico
            // 
            this.cmbPlanMedico.FormattingEnabled = true;
            this.cmbPlanMedico.Location = new System.Drawing.Point(872, 40);
            this.cmbPlanMedico.Name = "cmbPlanMedico";
            this.cmbPlanMedico.Size = new System.Drawing.Size(132, 21);
            this.cmbPlanMedico.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(854, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Plan médico:";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.HeaderText = "Tipo de documento";
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.ReadOnly = true;
            // 
            // numeroDocumento
            // 
            this.numeroDocumento.HeaderText = "Número de documento";
            this.numeroDocumento.Name = "numeroDocumento";
            this.numeroDocumento.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // mail
            // 
            this.mail.HeaderText = "Mail";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.HeaderText = "Fecha de nacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.HeaderText = "Nombre de Usuario";
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.ReadOnly = true;
            // 
            // grupoFamiliar
            // 
            this.grupoFamiliar.HeaderText = "Grupo familiar";
            this.grupoFamiliar.Name = "grupoFamiliar";
            this.grupoFamiliar.ReadOnly = true;
            // 
            // orden
            // 
            this.orden.HeaderText = "Orden";
            this.orden.Name = "orden";
            this.orden.ReadOnly = true;
            // 
            // estadoCivil
            // 
            this.estadoCivil.HeaderText = "Estado civil";
            this.estadoCivil.Name = "estadoCivil";
            this.estadoCivil.ReadOnly = true;
            // 
            // familiaresACargo
            // 
            this.familiaresACargo.HeaderText = "Familiares a cargo";
            this.familiaresACargo.Name = "familiaresACargo";
            this.familiaresACargo.ReadOnly = true;
            // 
            // planMedico
            // 
            this.planMedico.HeaderText = "Plan Medico";
            this.planMedico.Name = "planMedico";
            this.planMedico.ReadOnly = true;
            // 
            // AbmAfiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 589);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.dgvRoles);
            this.Name = "AbmAfiliados";
            this.Text = "Abm de afiliados";
            this.Load += new System.EventHandler(this.AbmAfiliados_Load);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.ListBox lbGrupoFamiliar;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOrden;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNumeroDni;
        private System.Windows.Forms.ComboBox cmbTipoDNI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNombreUsuario;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbPlanMedico;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbFamiliaresACargo;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoFamiliar;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiaresACargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn planMedico;
    }
}