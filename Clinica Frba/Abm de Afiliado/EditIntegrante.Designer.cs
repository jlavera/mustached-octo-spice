namespace Clinica_Frba.AbmAfiliados {
    partial class EditIntegrante {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbContrasegna = new System.Windows.Forms.TextBox();
            this.tbNumeroDni = new System.Windows.Forms.MaskedTextBox();
            this.tbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbConyuge = new System.Windows.Forms.CheckBox();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
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
            this.bGuardar = new System.Windows.Forms.Button();
            this.nFamiliares = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFamiliares)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.nFamiliares);
            this.gbDatos.Controls.Add(this.label16);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.tbContrasegna);
            this.gbDatos.Controls.Add(this.tbNumeroDni);
            this.gbDatos.Controls.Add(this.tbTelefono);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.dtpFechaNacimiento);
            this.gbDatos.Controls.Add(this.cbConyuge);
            this.gbDatos.Controls.Add(this.cmbEstadoCivil);
            this.gbDatos.Controls.Add(this.label12);
            this.gbDatos.Controls.Add(this.cmbSexo);
            this.gbDatos.Controls.Add(this.label11);
            this.gbDatos.Controls.Add(this.label10);
            this.gbDatos.Controls.Add(this.tbNombreUsuario);
            this.gbDatos.Controls.Add(this.label9);
            this.gbDatos.Controls.Add(this.tbMail);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.cmbTipoDNI);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.tbDireccion);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.tbApellido);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.tbNombre);
            this.gbDatos.Controls.Add(this.bGuardar);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(407, 342);
            this.gbDatos.TabIndex = 1;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Contraseña:";
            // 
            // tbContrasegna
            // 
            this.tbContrasegna.Location = new System.Drawing.Point(248, 264);
            this.tbContrasegna.Name = "tbContrasegna";
            this.tbContrasegna.PasswordChar = '*';
            this.tbContrasegna.Size = new System.Drawing.Size(140, 20);
            this.tbContrasegna.TabIndex = 12;
            // 
            // tbNumeroDni
            // 
            this.tbNumeroDni.Location = new System.Drawing.Point(248, 90);
            this.tbNumeroDni.Mask = "000000000000000000";
            this.tbNumeroDni.Name = "tbNumeroDni";
            this.tbNumeroDni.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbNumeroDni.Size = new System.Drawing.Size(122, 20);
            this.tbNumeroDni.TabIndex = 8;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(248, 129);
            this.tbTelefono.Mask = "000000000000000000";
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbTelefono.Size = new System.Drawing.Size(122, 20);
            this.tbTelefono.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Fecha de nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(48, 303);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 6;
            this.dtpFechaNacimiento.Value = new System.DateTime(2013, 11, 1, 0, 0, 0, 0);
            // 
            // cbConyuge
            // 
            this.cbConyuge.AutoSize = true;
            this.cbConyuge.Location = new System.Drawing.Point(33, 254);
            this.cbConyuge.Name = "cbConyuge";
            this.cbConyuge.Size = new System.Drawing.Size(68, 17);
            this.cbConyuge.TabIndex = 5;
            this.cbConyuge.Text = "Conyuge";
            this.cbConyuge.UseVisualStyleBackColor = true;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(46, 172);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(140, 21);
            this.cmbEstadoCivil.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Estado civil:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(48, 219);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(138, 21);
            this.cmbSexo.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Sexo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Nombre de usuario:";
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.Location = new System.Drawing.Point(248, 219);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(140, 20);
            this.tbNombreUsuario.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Mail:";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(248, 176);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(140, 20);
            this.tbMail.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Número de documento:";
            // 
            // cmbTipoDNI
            // 
            this.cmbTipoDNI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDNI.FormattingEnabled = true;
            this.cmbTipoDNI.Items.AddRange(new object[] {
            "DNI",
            "LE ",
            "LC "});
            this.cmbTipoDNI.Location = new System.Drawing.Point(250, 47);
            this.cmbTipoDNI.Name = "cmbTipoDNI";
            this.cmbTipoDNI.Size = new System.Drawing.Size(61, 21);
            this.cmbTipoDNI.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Tipo de documento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Dirección:";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(46, 133);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(140, 20);
            this.tbDireccion.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Apellido:";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(46, 90);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(140, 20);
            this.tbApellido.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(46, 47);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(140, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(254, 290);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(134, 33);
            this.bGuardar.TabIndex = 13;
            this.bGuardar.Text = "Agregar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // nFamiliares
            // 
            this.nFamiliares.Location = new System.Drawing.Point(146, 264);
            this.nFamiliares.Name = "nFamiliares";
            this.nFamiliares.Size = new System.Drawing.Size(40, 20);
            this.nFamiliares.TabIndex = 82;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(127, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 13);
            this.label16.TabIndex = 81;
            this.label16.Text = "Familiares a cargo:";
            // 
            // EditIntegrante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 366);
            this.Controls.Add(this.gbDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditIntegrante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editción de integrante";
            this.Load += new System.EventHandler(this.EditIntegrante_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFamiliares)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNombreUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbMail;
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
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.CheckBox cbConyuge;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbNumeroDni;
        private System.Windows.Forms.MaskedTextBox tbTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbContrasegna;
        private System.Windows.Forms.NumericUpDown nFamiliares;
        private System.Windows.Forms.Label label16;
    }
}