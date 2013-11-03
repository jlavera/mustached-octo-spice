namespace Clinica_Frba.AbmAfiliados
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
            this.label15 = new System.Windows.Forms.Label();
            this.nLimit = new System.Windows.Forms.NumericUpDown();
            this.tbOrden = new System.Windows.Forms.MaskedTextBox();
            this.tbFamiliaresACargo = new System.Windows.Forms.MaskedTextBox();
            this.tbNumeroDni = new System.Windows.Forms.MaskedTextBox();
            this.tbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lbPlanMedico = new System.Windows.Forms.ListBox();
            this.lbEstadoCivil = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoDNI = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbGrupoFamiliar = new System.Windows.Forms.ListBox();
            this.dgvAfiliados = new System.Windows.Forms.DataGridView();
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
            this.estadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiaresACargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfiliados)).BeginInit();
            this.SuspendLayout();
            // 
            // bEliminar
            // 
            this.bEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bEliminar.Location = new System.Drawing.Point(189, 186);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(175, 29);
            this.bEliminar.TabIndex = 3;
            this.bEliminar.Text = "Eliminar seleccionados (SUPR)";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bAgregar.Location = new System.Drawing.Point(12, 186);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(134, 29);
            this.bAgregar.TabIndex = 2;
            this.bAgregar.Text = "Agregar titular (A)";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bBuscar.Location = new System.Drawing.Point(993, 186);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(146, 29);
            this.bBuscar.TabIndex = 0;
            this.bBuscar.Text = "Buscar (ENTER)";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltros.Controls.Add(this.label15);
            this.gbFiltros.Controls.Add(this.nLimit);
            this.gbFiltros.Controls.Add(this.tbOrden);
            this.gbFiltros.Controls.Add(this.tbFamiliaresACargo);
            this.gbFiltros.Controls.Add(this.tbNumeroDni);
            this.gbFiltros.Controls.Add(this.tbTelefono);
            this.gbFiltros.Controls.Add(this.lbPlanMedico);
            this.gbFiltros.Controls.Add(this.lbEstadoCivil);
            this.gbFiltros.Controls.Add(this.label14);
            this.gbFiltros.Controls.Add(this.label13);
            this.gbFiltros.Controls.Add(this.label12);
            this.gbFiltros.Controls.Add(this.cmbSexo);
            this.gbFiltros.Controls.Add(this.label11);
            this.gbFiltros.Controls.Add(this.label10);
            this.gbFiltros.Controls.Add(this.tbNombreUsuario);
            this.gbFiltros.Controls.Add(this.label9);
            this.gbFiltros.Controls.Add(this.tbMail);
            this.gbFiltros.Controls.Add(this.label8);
            this.gbFiltros.Controls.Add(this.label7);
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
            this.gbFiltros.Controls.Add(this.lbGrupoFamiliar);
            this.gbFiltros.Location = new System.Drawing.Point(12, 12);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(1127, 168);
            this.gbFiltros.TabIndex = 6;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1015, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Cantidad a mostrar:";
            // 
            // nLimit
            // 
            this.nLimit.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nLimit.Location = new System.Drawing.Point(1031, 127);
            this.nLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nLimit.Name = "nLimit";
            this.nLimit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nLimit.Size = new System.Drawing.Size(54, 20);
            this.nLimit.TabIndex = 14;
            this.nLimit.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // tbOrden
            // 
            this.tbOrden.Location = new System.Drawing.Point(1031, 36);
            this.tbOrden.Mask = "00";
            this.tbOrden.Name = "tbOrden";
            this.tbOrden.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbOrden.Size = new System.Drawing.Size(54, 20);
            this.tbOrden.TabIndex = 12;
            // 
            // tbFamiliaresACargo
            // 
            this.tbFamiliaresACargo.Location = new System.Drawing.Point(1031, 83);
            this.tbFamiliaresACargo.Mask = "00";
            this.tbFamiliaresACargo.Name = "tbFamiliaresACargo";
            this.tbFamiliaresACargo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbFamiliaresACargo.Size = new System.Drawing.Size(54, 20);
            this.tbFamiliaresACargo.TabIndex = 13;
            // 
            // tbNumeroDni
            // 
            this.tbNumeroDni.Location = new System.Drawing.Point(177, 79);
            this.tbNumeroDni.Mask = "000000000000000000";
            this.tbNumeroDni.Name = "tbNumeroDni";
            this.tbNumeroDni.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbNumeroDni.Size = new System.Drawing.Size(127, 20);
            this.tbNumeroDni.TabIndex = 4;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(177, 128);
            this.tbTelefono.Mask = "000000000000000000";
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbTelefono.Size = new System.Drawing.Size(127, 20);
            this.tbTelefono.TabIndex = 5;
            // 
            // lbPlanMedico
            // 
            this.lbPlanMedico.FormattingEnabled = true;
            this.lbPlanMedico.Location = new System.Drawing.Point(849, 40);
            this.lbPlanMedico.Name = "lbPlanMedico";
            this.lbPlanMedico.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbPlanMedico.Size = new System.Drawing.Size(120, 108);
            this.lbPlanMedico.TabIndex = 11;
            // 
            // lbEstadoCivil
            // 
            this.lbEstadoCivil.DisplayMember = "id";
            this.lbEstadoCivil.FormattingEnabled = true;
            this.lbEstadoCivil.Location = new System.Drawing.Point(686, 40);
            this.lbEstadoCivil.Name = "lbEstadoCivil";
            this.lbEstadoCivil.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbEstadoCivil.Size = new System.Drawing.Size(113, 108);
            this.lbEstadoCivil.TabIndex = 10;
            this.lbEstadoCivil.ValueMember = "id";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(835, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Plan médico:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1015, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Familiares a cargo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(671, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Estado civil:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(362, 126);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(138, 21);
            this.cmbSexo.TabIndex = 8;
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
            this.tbNombreUsuario.TabIndex = 7;
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
            this.tbMail.TabIndex = 6;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Número de documento:";
            // 
            // cmbTipoDNI
            // 
            this.cmbTipoDNI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDNI.FormattingEnabled = true;
            this.cmbTipoDNI.Items.AddRange(new object[] {
            "DNI",
            "LE",
            "LC"});
            this.cmbTipoDNI.Location = new System.Drawing.Point(177, 39);
            this.cmbTipoDNI.Name = "cmbTipoDNI";
            this.cmbTipoDNI.Size = new System.Drawing.Size(61, 21);
            this.cmbTipoDNI.TabIndex = 3;
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
            this.tbDireccion.TabIndex = 2;
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
            this.tbApellido.TabIndex = 1;
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
            this.tbNombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1015, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Orden:";
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
            // lbGrupoFamiliar
            // 
            this.lbGrupoFamiliar.DisplayMember = "id";
            this.lbGrupoFamiliar.FormattingEnabled = true;
            this.lbGrupoFamiliar.Location = new System.Drawing.Point(531, 40);
            this.lbGrupoFamiliar.Name = "lbGrupoFamiliar";
            this.lbGrupoFamiliar.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbGrupoFamiliar.Size = new System.Drawing.Size(113, 108);
            this.lbGrupoFamiliar.TabIndex = 9;
            this.lbGrupoFamiliar.ValueMember = "id";
            // 
            // dgvAfiliados
            // 
            this.dgvAfiliados.AllowUserToAddRows = false;
            this.dgvAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAfiliados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.estadoCivil,
            this.familiaresACargo,
            this.planMedico,
            this.seleccionar});
            this.dgvAfiliados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAfiliados.Location = new System.Drawing.Point(0, 221);
            this.dgvAfiliados.Name = "dgvAfiliados";
            this.dgvAfiliados.Size = new System.Drawing.Size(1149, 431);
            this.dgvAfiliados.TabIndex = 4;
            this.dgvAfiliados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAfiliados_CellContentClick);
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
            // seleccionar
            // 
            this.seleccionar.HeaderText = "Seleccionar";
            this.seleccionar.Name = "seleccionar";
            // 
            // bLimpiar
            // 
            this.bLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bLimpiar.Location = new System.Drawing.Point(859, 186);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(93, 29);
            this.bLimpiar.TabIndex = 1;
            this.bLimpiar.Text = "Limpiar (L)";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // AbmAfiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 652);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.dgvAfiliados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AbmAfiliados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abm de afiliados";
            this.Load += new System.EventHandler(this.AbmAfiliados_Load);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfiliados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.ListBox lbGrupoFamiliar;
        private System.Windows.Forms.DataGridView dgvAfiliados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiaresACargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn planMedico;
        private System.Windows.Forms.DataGridViewButtonColumn seleccionar;
        private System.Windows.Forms.ListBox lbEstadoCivil;
        private System.Windows.Forms.ListBox lbPlanMedico;
        private System.Windows.Forms.MaskedTextBox tbTelefono;
        private System.Windows.Forms.MaskedTextBox tbNumeroDni;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.MaskedTextBox tbOrden;
        private System.Windows.Forms.MaskedTextBox tbFamiliaresACargo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nLimit;
        private System.Windows.Forms.Button bLimpiar;
    }
}