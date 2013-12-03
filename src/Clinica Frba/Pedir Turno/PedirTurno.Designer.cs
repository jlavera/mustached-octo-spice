namespace Clinica_Frba.PedirTurno
{
    partial class PedirTurno
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
            this.gbProf = new System.Windows.Forms.GroupBox();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.bBuscar = new System.Windows.Forms.Button();
            this.nLimit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEspecialidades = new System.Windows.Forms.ListBox();
            this.tbMatricula = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.dgvProfesionales = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.especialidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDia = new System.Windows.Forms.GroupBox();
            this.bVolverDia = new System.Windows.Forms.Button();
            this.bSiguienteDia = new System.Windows.Forms.Button();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.gbHorario = new System.Windows.Forms.GroupBox();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.bFinalizar = new System.Windows.Forms.Button();
            this.bVolverHorario = new System.Windows.Forms.Button();
            this.gbEspecialidad = new System.Windows.Forms.GroupBox();
            this.cmbEspecialidades = new System.Windows.Forms.ComboBox();
            this.bVolverEsp = new System.Windows.Forms.Button();
            this.bSiguienteEsp = new System.Windows.Forms.Button();
            this.lbTurnos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbProf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesionales)).BeginInit();
            this.gbDia.SuspendLayout();
            this.gbHorario.SuspendLayout();
            this.gbEspecialidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProf
            // 
            this.gbProf.Controls.Add(this.bLimpiar);
            this.gbProf.Controls.Add(this.label15);
            this.gbProf.Controls.Add(this.bBuscar);
            this.gbProf.Controls.Add(this.nLimit);
            this.gbProf.Controls.Add(this.label1);
            this.gbProf.Controls.Add(this.lbEspecialidades);
            this.gbProf.Controls.Add(this.tbMatricula);
            this.gbProf.Controls.Add(this.label12);
            this.gbProf.Controls.Add(this.label4);
            this.gbProf.Controls.Add(this.tbApellido);
            this.gbProf.Controls.Add(this.label3);
            this.gbProf.Controls.Add(this.tbNombre);
            this.gbProf.Controls.Add(this.dgvProfesionales);
            this.gbProf.Location = new System.Drawing.Point(12, 12);
            this.gbProf.Name = "gbProf";
            this.gbProf.Size = new System.Drawing.Size(612, 344);
            this.gbProf.TabIndex = 0;
            this.gbProf.TabStop = false;
            this.gbProf.Text = "Seleccionar profesional";
            // 
            // bLimpiar
            // 
            this.bLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bLimpiar.Location = new System.Drawing.Point(464, 117);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(118, 29);
            this.bLimpiar.TabIndex = 15;
            this.bLimpiar.Text = "Limpiar (L)";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(499, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Cantidad a mostrar:";
            // 
            // bBuscar
            // 
            this.bBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bBuscar.Location = new System.Drawing.Point(462, 79);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(120, 29);
            this.bBuscar.TabIndex = 14;
            this.bBuscar.Text = "Buscar (ENTER)";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // nLimit
            // 
            this.nLimit.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nLimit.Location = new System.Drawing.Point(523, 35);
            this.nLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nLimit.Name = "nLimit";
            this.nLimit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nLimit.Size = new System.Drawing.Size(57, 20);
            this.nLimit.TabIndex = 51;
            this.nLimit.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Especialidades:";
            // 
            // lbEspecialidades
            // 
            this.lbEspecialidades.DisplayMember = "id";
            this.lbEspecialidades.FormattingEnabled = true;
            this.lbEspecialidades.Location = new System.Drawing.Point(274, 34);
            this.lbEspecialidades.Name = "lbEspecialidades";
            this.lbEspecialidades.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbEspecialidades.Size = new System.Drawing.Size(140, 108);
            this.lbEspecialidades.TabIndex = 50;
            this.lbEspecialidades.ValueMember = "id";
            // 
            // tbMatricula
            // 
            this.tbMatricula.Location = new System.Drawing.Point(39, 34);
            this.tbMatricula.Mask = "0000000000";
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbMatricula.Size = new System.Drawing.Size(76, 20);
            this.tbMatricula.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Matrícula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Apellido:";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(39, 122);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(140, 20);
            this.tbApellido.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(39, 79);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(140, 20);
            this.tbNombre.TabIndex = 44;
            // 
            // dgvProfesionales
            // 
            this.dgvProfesionales.AllowUserToAddRows = false;
            this.dgvProfesionales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProfesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesionales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.matricula,
            this.profesional,
            this.Seleccionar,
            this.especialidades});
            this.dgvProfesionales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProfesionales.Location = new System.Drawing.Point(3, 159);
            this.dgvProfesionales.MultiSelect = false;
            this.dgvProfesionales.Name = "dgvProfesionales";
            this.dgvProfesionales.Size = new System.Drawing.Size(606, 182);
            this.dgvProfesionales.TabIndex = 0;
            this.dgvProfesionales.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProfesionales_KeyDown);
            this.dgvProfesionales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesionales_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 41;
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Matricula";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            this.matricula.Width = 75;
            // 
            // profesional
            // 
            this.profesional.HeaderText = "Profesional";
            this.profesional.Name = "profesional";
            this.profesional.ReadOnly = true;
            this.profesional.Width = 84;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Elegir";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Width = 39;
            // 
            // especialidades
            // 
            this.especialidades.HeaderText = "Especialidades";
            this.especialidades.Name = "especialidades";
            this.especialidades.ReadOnly = true;
            this.especialidades.Width = 103;
            // 
            // gbDia
            // 
            this.gbDia.Controls.Add(this.bVolverDia);
            this.gbDia.Controls.Add(this.bSiguienteDia);
            this.gbDia.Controls.Add(this.dtpDia);
            this.gbDia.Enabled = false;
            this.gbDia.Location = new System.Drawing.Point(12, 490);
            this.gbDia.Name = "gbDia";
            this.gbDia.Size = new System.Drawing.Size(265, 108);
            this.gbDia.TabIndex = 1;
            this.gbDia.TabStop = false;
            this.gbDia.Text = "Seleccionar día";
            // 
            // bVolverDia
            // 
            this.bVolverDia.Location = new System.Drawing.Point(19, 70);
            this.bVolverDia.Name = "bVolverDia";
            this.bVolverDia.Size = new System.Drawing.Size(91, 23);
            this.bVolverDia.TabIndex = 2;
            this.bVolverDia.Text = "Volver";
            this.bVolverDia.UseVisualStyleBackColor = true;
            this.bVolverDia.Click += new System.EventHandler(this.bVolverDia_Click);
            // 
            // bSiguienteDia
            // 
            this.bSiguienteDia.Location = new System.Drawing.Point(159, 70);
            this.bSiguienteDia.Name = "bSiguienteDia";
            this.bSiguienteDia.Size = new System.Drawing.Size(91, 23);
            this.bSiguienteDia.TabIndex = 1;
            this.bSiguienteDia.Text = "Siguiente";
            this.bSiguienteDia.UseVisualStyleBackColor = true;
            this.bSiguienteDia.Click += new System.EventHandler(this.bSiguienteDia_Click);
            // 
            // dtpDia
            // 
            this.dtpDia.Location = new System.Drawing.Point(19, 27);
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.Size = new System.Drawing.Size(231, 20);
            this.dtpDia.TabIndex = 0;
            // 
            // gbHorario
            // 
            this.gbHorario.Controls.Add(this.label2);
            this.gbHorario.Controls.Add(this.lbTurnos);
            this.gbHorario.Controls.Add(this.dtpHora);
            this.gbHorario.Controls.Add(this.bFinalizar);
            this.gbHorario.Controls.Add(this.bVolverHorario);
            this.gbHorario.Enabled = false;
            this.gbHorario.Location = new System.Drawing.Point(286, 374);
            this.gbHorario.Name = "gbHorario";
            this.gbHorario.Size = new System.Drawing.Size(338, 224);
            this.gbHorario.TabIndex = 2;
            this.gbHorario.TabStop = false;
            this.gbHorario.Text = "Seleccionar horario";
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(35, 33);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(114, 20);
            this.dtpHora.TabIndex = 4;
            // 
            // bFinalizar
            // 
            this.bFinalizar.Location = new System.Drawing.Point(35, 170);
            this.bFinalizar.Name = "bFinalizar";
            this.bFinalizar.Size = new System.Drawing.Size(114, 39);
            this.bFinalizar.TabIndex = 3;
            this.bFinalizar.Text = "Finalizar";
            this.bFinalizar.UseVisualStyleBackColor = true;
            this.bFinalizar.Click += new System.EventHandler(this.bFinalizar_Click);
            // 
            // bVolverHorario
            // 
            this.bVolverHorario.Location = new System.Drawing.Point(35, 116);
            this.bVolverHorario.Name = "bVolverHorario";
            this.bVolverHorario.Size = new System.Drawing.Size(114, 23);
            this.bVolverHorario.TabIndex = 3;
            this.bVolverHorario.Text = "Volver";
            this.bVolverHorario.UseVisualStyleBackColor = true;
            this.bVolverHorario.Click += new System.EventHandler(this.bVolverHorario_Click);
            // 
            // gbEspecialidad
            // 
            this.gbEspecialidad.Controls.Add(this.cmbEspecialidades);
            this.gbEspecialidad.Controls.Add(this.bVolverEsp);
            this.gbEspecialidad.Controls.Add(this.bSiguienteEsp);
            this.gbEspecialidad.Enabled = false;
            this.gbEspecialidad.Location = new System.Drawing.Point(15, 374);
            this.gbEspecialidad.Name = "gbEspecialidad";
            this.gbEspecialidad.Size = new System.Drawing.Size(265, 110);
            this.gbEspecialidad.TabIndex = 3;
            this.gbEspecialidad.TabStop = false;
            this.gbEspecialidad.Text = "Seleccionar especialidad";
            // 
            // cmbEspecialidades
            // 
            this.cmbEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidades.FormattingEnabled = true;
            this.cmbEspecialidades.Location = new System.Drawing.Point(19, 27);
            this.cmbEspecialidades.Name = "cmbEspecialidades";
            this.cmbEspecialidades.Size = new System.Drawing.Size(231, 21);
            this.cmbEspecialidades.TabIndex = 3;
            // 
            // bVolverEsp
            // 
            this.bVolverEsp.Location = new System.Drawing.Point(19, 70);
            this.bVolverEsp.Name = "bVolverEsp";
            this.bVolverEsp.Size = new System.Drawing.Size(91, 23);
            this.bVolverEsp.TabIndex = 2;
            this.bVolverEsp.Text = "Volver";
            this.bVolverEsp.UseVisualStyleBackColor = true;
            this.bVolverEsp.Click += new System.EventHandler(this.bVolverEsp_Click);
            // 
            // bSiguienteEsp
            // 
            this.bSiguienteEsp.Location = new System.Drawing.Point(159, 70);
            this.bSiguienteEsp.Name = "bSiguienteEsp";
            this.bSiguienteEsp.Size = new System.Drawing.Size(91, 23);
            this.bSiguienteEsp.TabIndex = 1;
            this.bSiguienteEsp.Text = "Siguiente";
            this.bSiguienteEsp.UseVisualStyleBackColor = true;
            this.bSiguienteEsp.Click += new System.EventHandler(this.bSiguienteEsp_Click);
            // 
            // lbTurnos
            // 
            this.lbTurnos.FormattingEnabled = true;
            this.lbTurnos.Location = new System.Drawing.Point(176, 53);
            this.lbTurnos.Name = "lbTurnos";
            this.lbTurnos.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbTurnos.Size = new System.Drawing.Size(147, 160);
            this.lbTurnos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Turnos ocupados:";
            // 
            // PedirTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 611);
            this.Controls.Add(this.gbEspecialidad);
            this.Controls.Add(this.gbHorario);
            this.Controls.Add(this.gbDia);
            this.Controls.Add(this.gbProf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PedirTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedir turno";
            this.Load += new System.EventHandler(this.Turno_Load);
            this.gbProf.ResumeLayout(false);
            this.gbProf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesionales)).EndInit();
            this.gbDia.ResumeLayout(false);
            this.gbHorario.ResumeLayout(false);
            this.gbHorario.PerformLayout();
            this.gbEspecialidad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProf;
        private System.Windows.Forms.GroupBox gbDia;
        private System.Windows.Forms.GroupBox gbHorario;
        private System.Windows.Forms.DataGridView dgvProfesionales;
        private System.Windows.Forms.MaskedTextBox tbMatricula;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbEspecialidades;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.DateTimePicker dtpDia;
        private System.Windows.Forms.Button bVolverDia;
        private System.Windows.Forms.Button bSiguienteDia;
        private System.Windows.Forms.GroupBox gbEspecialidad;
        private System.Windows.Forms.Button bVolverEsp;
        private System.Windows.Forms.Button bSiguienteEsp;
        private System.Windows.Forms.ComboBox cmbEspecialidades;
        private System.Windows.Forms.Button bFinalizar;
        private System.Windows.Forms.Button bVolverHorario;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesional;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidades;
        private System.Windows.Forms.ListBox lbTurnos;
        private System.Windows.Forms.Label label2;


    }
}