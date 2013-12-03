namespace Clinica_Frba.RegistrarLlegada
{
    partial class RegistrarLlegada
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
            this.gbAfiliado = new System.Windows.Forms.GroupBox();
            this.tbAfiliado = new System.Windows.Forms.MaskedTextBox();
            this.bVolvereAfi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bSiguienteAfi = new System.Windows.Forms.Button();
            this.gbTurno = new System.Windows.Forms.GroupBox();
            this.bVolverTurno = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bSiguienteTurno = new System.Windows.Forms.Button();
            this.lbTurnos = new System.Windows.Forms.ListBox();
            this.gbBono = new System.Windows.Forms.GroupBox();
            this.bVolverBono = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBono = new System.Windows.Forms.TextBox();
            this.bSiguienteBono = new System.Windows.Forms.Button();
            this.gbProf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesionales)).BeginInit();
            this.gbAfiliado.SuspendLayout();
            this.gbTurno.SuspendLayout();
            this.gbBono.SuspendLayout();
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
            this.gbProf.Size = new System.Drawing.Size(750, 344);
            this.gbProf.TabIndex = 1;
            this.gbProf.TabStop = false;
            this.gbProf.Text = "Seleccionar profesional";
            // 
            // bLimpiar
            // 
            this.bLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bLimpiar.Location = new System.Drawing.Point(602, 117);
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
            this.label15.Location = new System.Drawing.Point(401, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Cantidad a mostrar:";
            // 
            // bBuscar
            // 
            this.bBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bBuscar.Location = new System.Drawing.Point(600, 79);
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
            this.nLimit.Location = new System.Drawing.Point(425, 35);
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
            this.label1.Location = new System.Drawing.Point(217, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Especialidades:";
            // 
            // lbEspecialidades
            // 
            this.lbEspecialidades.DisplayMember = "id";
            this.lbEspecialidades.FormattingEnabled = true;
            this.lbEspecialidades.Location = new System.Drawing.Point(240, 34);
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
            this.dgvProfesionales.Size = new System.Drawing.Size(744, 182);
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
            // gbAfiliado
            // 
            this.gbAfiliado.Controls.Add(this.tbAfiliado);
            this.gbAfiliado.Controls.Add(this.bVolvereAfi);
            this.gbAfiliado.Controls.Add(this.label2);
            this.gbAfiliado.Controls.Add(this.bSiguienteAfi);
            this.gbAfiliado.Enabled = false;
            this.gbAfiliado.Location = new System.Drawing.Point(500, 362);
            this.gbAfiliado.Name = "gbAfiliado";
            this.gbAfiliado.Size = new System.Drawing.Size(262, 163);
            this.gbAfiliado.TabIndex = 2;
            this.gbAfiliado.TabStop = false;
            this.gbAfiliado.Text = "Afiliado";
            // 
            // tbAfiliado
            // 
            this.tbAfiliado.Location = new System.Drawing.Point(151, 47);
            this.tbAfiliado.Mask = "000000";
            this.tbAfiliado.Name = "tbAfiliado";
            this.tbAfiliado.Size = new System.Drawing.Size(89, 20);
            this.tbAfiliado.TabIndex = 57;
            this.tbAfiliado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAfiliado_KeyPress);
            // 
            // bVolvereAfi
            // 
            this.bVolvereAfi.Location = new System.Drawing.Point(20, 96);
            this.bVolvereAfi.Name = "bVolvereAfi";
            this.bVolvereAfi.Size = new System.Drawing.Size(87, 23);
            this.bVolvereAfi.TabIndex = 55;
            this.bVolvereAfi.Text = "Volver";
            this.bVolvereAfi.UseVisualStyleBackColor = true;
            this.bVolvereAfi.Click += new System.EventHandler(this.bVolvereAfi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de afiliado:";
            // 
            // bSiguienteAfi
            // 
            this.bSiguienteAfi.Location = new System.Drawing.Point(151, 96);
            this.bSiguienteAfi.Name = "bSiguienteAfi";
            this.bSiguienteAfi.Size = new System.Drawing.Size(87, 23);
            this.bSiguienteAfi.TabIndex = 0;
            this.bSiguienteAfi.Text = "Siguiente";
            this.bSiguienteAfi.UseVisualStyleBackColor = true;
            this.bSiguienteAfi.Click += new System.EventHandler(this.bSiguienteAfi_Click);
            // 
            // gbTurno
            // 
            this.gbTurno.Controls.Add(this.bVolverTurno);
            this.gbTurno.Controls.Add(this.label5);
            this.gbTurno.Controls.Add(this.bSiguienteTurno);
            this.gbTurno.Controls.Add(this.lbTurnos);
            this.gbTurno.Enabled = false;
            this.gbTurno.Location = new System.Drawing.Point(15, 362);
            this.gbTurno.Name = "gbTurno";
            this.gbTurno.Size = new System.Drawing.Size(479, 344);
            this.gbTurno.TabIndex = 3;
            this.gbTurno.TabStop = false;
            this.gbTurno.Text = "Seleccionar turno";
            // 
            // bVolverTurno
            // 
            this.bVolverTurno.Location = new System.Drawing.Point(30, 315);
            this.bVolverTurno.Name = "bVolverTurno";
            this.bVolverTurno.Size = new System.Drawing.Size(87, 23);
            this.bVolverTurno.TabIndex = 54;
            this.bVolverTurno.Text = "Volver";
            this.bVolverTurno.UseVisualStyleBackColor = true;
            this.bVolverTurno.Click += new System.EventHandler(this.bVolverTurno_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Turnos del profesional:";
            // 
            // bSiguienteTurno
            // 
            this.bSiguienteTurno.Location = new System.Drawing.Point(370, 315);
            this.bSiguienteTurno.Name = "bSiguienteTurno";
            this.bSiguienteTurno.Size = new System.Drawing.Size(87, 23);
            this.bSiguienteTurno.TabIndex = 3;
            this.bSiguienteTurno.Text = "Siguiente";
            this.bSiguienteTurno.UseVisualStyleBackColor = true;
            this.bSiguienteTurno.Click += new System.EventHandler(this.bSiguienteTurno_Click);
            // 
            // lbTurnos
            // 
            this.lbTurnos.FormattingEnabled = true;
            this.lbTurnos.Location = new System.Drawing.Point(30, 34);
            this.lbTurnos.Name = "lbTurnos";
            this.lbTurnos.Size = new System.Drawing.Size(427, 277);
            this.lbTurnos.TabIndex = 0;
            this.lbTurnos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbTurnos_KeyPress);
            // 
            // gbBono
            // 
            this.gbBono.Controls.Add(this.bVolverBono);
            this.gbBono.Controls.Add(this.label6);
            this.gbBono.Controls.Add(this.tbBono);
            this.gbBono.Controls.Add(this.bSiguienteBono);
            this.gbBono.Enabled = false;
            this.gbBono.Location = new System.Drawing.Point(500, 531);
            this.gbBono.Name = "gbBono";
            this.gbBono.Size = new System.Drawing.Size(262, 175);
            this.gbBono.TabIndex = 56;
            this.gbBono.TabStop = false;
            this.gbBono.Text = "Bono consulta";
            // 
            // bVolverBono
            // 
            this.bVolverBono.Location = new System.Drawing.Point(20, 116);
            this.bVolverBono.Name = "bVolverBono";
            this.bVolverBono.Size = new System.Drawing.Size(87, 23);
            this.bVolverBono.TabIndex = 55;
            this.bVolverBono.Text = "Volver";
            this.bVolverBono.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Número de bono:";
            // 
            // tbBono
            // 
            this.tbBono.Location = new System.Drawing.Point(152, 47);
            this.tbBono.Name = "tbBono";
            this.tbBono.Size = new System.Drawing.Size(89, 20);
            this.tbBono.TabIndex = 1;
            this.tbBono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBono_KeyPress);
            // 
            // bSiguienteBono
            // 
            this.bSiguienteBono.Location = new System.Drawing.Point(153, 116);
            this.bSiguienteBono.Name = "bSiguienteBono";
            this.bSiguienteBono.Size = new System.Drawing.Size(87, 23);
            this.bSiguienteBono.TabIndex = 0;
            this.bSiguienteBono.Text = "Finalizar";
            this.bSiguienteBono.UseVisualStyleBackColor = true;
            this.bSiguienteBono.Click += new System.EventHandler(this.bSiguienteBono_Click);
            // 
            // RegistrarLlegada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 715);
            this.Controls.Add(this.gbBono);
            this.Controls.Add(this.gbTurno);
            this.Controls.Add(this.gbAfiliado);
            this.Controls.Add(this.gbProf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegistrarLlegada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Llegada";
            this.Load += new System.EventHandler(this.RegistrarLlegada_Load);
            this.gbProf.ResumeLayout(false);
            this.gbProf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesionales)).EndInit();
            this.gbAfiliado.ResumeLayout(false);
            this.gbAfiliado.PerformLayout();
            this.gbTurno.ResumeLayout(false);
            this.gbTurno.PerformLayout();
            this.gbBono.ResumeLayout(false);
            this.gbBono.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProf;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.NumericUpDown nLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbEspecialidades;
        private System.Windows.Forms.MaskedTextBox tbMatricula;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.DataGridView dgvProfesionales;
        private System.Windows.Forms.GroupBox gbAfiliado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSiguienteAfi;
        private System.Windows.Forms.GroupBox gbTurno;
        private System.Windows.Forms.Button bSiguienteTurno;
        private System.Windows.Forms.ListBox lbTurnos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bVolverTurno;
        private System.Windows.Forms.Button bVolvereAfi;
        private System.Windows.Forms.GroupBox gbBono;
        private System.Windows.Forms.Button bVolverBono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBono;
        private System.Windows.Forms.Button bSiguienteBono;
        private System.Windows.Forms.MaskedTextBox tbAfiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesional;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidades;
    }
}