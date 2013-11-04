﻿namespace Clinica_Frba.Turno
{
    partial class Turno
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
            this.especialidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbDia = new System.Windows.Forms.GroupBox();
            this.bVolver = new System.Windows.Forms.Button();
            this.bSiguiente = new System.Windows.Forms.Button();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.gbHorario = new System.Windows.Forms.GroupBox();
            this.lbDia6 = new System.Windows.Forms.ListBox();
            this.gbEspecialidad = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.gbProf.Size = new System.Drawing.Size(552, 616);
            this.gbProf.TabIndex = 0;
            this.gbProf.TabStop = false;
            this.gbProf.Text = "Seleccionar profesional";
            // 
            // bLimpiar
            // 
            this.bLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bLimpiar.Location = new System.Drawing.Point(400, 81);
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
            this.label15.Location = new System.Drawing.Point(397, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Cantidad a mostrar:";
            // 
            // bBuscar
            // 
            this.bBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bBuscar.Location = new System.Drawing.Point(398, 124);
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
            this.nLimit.Location = new System.Drawing.Point(421, 46);
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
            this.label1.Location = new System.Drawing.Point(201, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Especialidades:";
            // 
            // lbEspecialidades
            // 
            this.lbEspecialidades.DisplayMember = "id";
            this.lbEspecialidades.FormattingEnabled = true;
            this.lbEspecialidades.Location = new System.Drawing.Point(224, 45);
            this.lbEspecialidades.Name = "lbEspecialidades";
            this.lbEspecialidades.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbEspecialidades.Size = new System.Drawing.Size(140, 108);
            this.lbEspecialidades.TabIndex = 50;
            this.lbEspecialidades.ValueMember = "id";
            // 
            // tbMatricula
            // 
            this.tbMatricula.Location = new System.Drawing.Point(47, 45);
            this.tbMatricula.Mask = "0000000000";
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbMatricula.Size = new System.Drawing.Size(76, 20);
            this.tbMatricula.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Matrícula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Apellido:";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(47, 133);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(140, 20);
            this.tbApellido.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(47, 90);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(140, 20);
            this.tbNombre.TabIndex = 44;
            // 
            // dgvProfesionales
            // 
            this.dgvProfesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesionales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.matricula,
            this.profesional,
            this.especialidades,
            this.Seleccionar});
            this.dgvProfesionales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProfesionales.Location = new System.Drawing.Point(3, 176);
            this.dgvProfesionales.Name = "dgvProfesionales";
            this.dgvProfesionales.Size = new System.Drawing.Size(546, 437);
            this.dgvProfesionales.TabIndex = 0;
            this.dgvProfesionales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesionales_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Matricula";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            // 
            // profesional
            // 
            this.profesional.HeaderText = "Profesional";
            this.profesional.Name = "profesional";
            this.profesional.ReadOnly = true;
            // 
            // especialidades
            // 
            this.especialidades.HeaderText = "Especialidades";
            this.especialidades.Name = "especialidades";
            this.especialidades.ReadOnly = true;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Elegir";
            this.Seleccionar.Name = "Seleccionar";
            // 
            // gbDia
            // 
            this.gbDia.Controls.Add(this.bVolver);
            this.gbDia.Controls.Add(this.bSiguiente);
            this.gbDia.Controls.Add(this.dtpDia);
            this.gbDia.Enabled = false;
            this.gbDia.Location = new System.Drawing.Point(575, 145);
            this.gbDia.Name = "gbDia";
            this.gbDia.Size = new System.Drawing.Size(265, 108);
            this.gbDia.TabIndex = 1;
            this.gbDia.TabStop = false;
            this.gbDia.Text = "Seleccionar día";
            // 
            // bVolver
            // 
            this.bVolver.Location = new System.Drawing.Point(19, 70);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(91, 23);
            this.bVolver.TabIndex = 2;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bSiguiente
            // 
            this.bSiguiente.Location = new System.Drawing.Point(159, 70);
            this.bSiguiente.Name = "bSiguiente";
            this.bSiguiente.Size = new System.Drawing.Size(91, 23);
            this.bSiguiente.TabIndex = 1;
            this.bSiguiente.Text = "Siguiente";
            this.bSiguiente.UseVisualStyleBackColor = true;
            this.bSiguiente.Click += new System.EventHandler(this.bSiguiente_Click);
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
            this.gbHorario.Controls.Add(this.lbDia6);
            this.gbHorario.Enabled = false;
            this.gbHorario.Location = new System.Drawing.Point(575, 259);
            this.gbHorario.Name = "gbHorario";
            this.gbHorario.Size = new System.Drawing.Size(265, 369);
            this.gbHorario.TabIndex = 2;
            this.gbHorario.TabStop = false;
            this.gbHorario.Text = "Seleccionar horario";
            // 
            // lbDia6
            // 
            this.lbDia6.FormattingEnabled = true;
            this.lbDia6.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30"});
            this.lbDia6.Location = new System.Drawing.Point(117, 19);
            this.lbDia6.Name = "lbDia6";
            this.lbDia6.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbDia6.Size = new System.Drawing.Size(37, 342);
            this.lbDia6.TabIndex = 25;
            // 
            // gbEspecialidad
            // 
            this.gbEspecialidad.Controls.Add(this.comboBox1);
            this.gbEspecialidad.Controls.Add(this.button1);
            this.gbEspecialidad.Controls.Add(this.button2);
            this.gbEspecialidad.Enabled = false;
            this.gbEspecialidad.Location = new System.Drawing.Point(575, 12);
            this.gbEspecialidad.Name = "gbEspecialidad";
            this.gbEspecialidad.Size = new System.Drawing.Size(265, 126);
            this.gbEspecialidad.TabIndex = 3;
            this.gbEspecialidad.TabStop = false;
            this.gbEspecialidad.Text = "Seleccionar especialidad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Siguiente";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // Turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 637);
            this.Controls.Add(this.gbEspecialidad);
            this.Controls.Add(this.gbHorario);
            this.Controls.Add(this.gbDia);
            this.Controls.Add(this.gbProf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Turno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedir turno";
            this.Load += new System.EventHandler(this.Turno_Load);
            this.gbProf.ResumeLayout(false);
            this.gbProf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesionales)).EndInit();
            this.gbDia.ResumeLayout(false);
            this.gbHorario.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidades;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bSiguiente;
        private System.Windows.Forms.ListBox lbDia6;
        private System.Windows.Forms.GroupBox gbEspecialidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;


    }
}