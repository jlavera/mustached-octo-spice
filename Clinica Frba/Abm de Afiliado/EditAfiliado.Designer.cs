namespace Clinica_Frba.AbmAfiliados {
    partial class EditAfiliado {
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
            this.bGuardar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNumeroDni = new System.Windows.Forms.TextBox();
            this.cmbTipoDNI = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOrden = new System.Windows.Forms.TextBox();
            this.cmbGrupoFamiliar = new System.Windows.Forms.ComboBox();
            this.cmbPlanMedico = new System.Windows.Forms.ComboBox();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.rbNuevo = new System.Windows.Forms.RadioButton();
            this.rbExistente = new System.Windows.Forms.RadioButton();
            this.gbGrupo = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bAgregarACargo = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            this.gbGrupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.bAgregarACargo);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.listBox1);
            this.gbDatos.Controls.Add(this.gbGrupo);
            this.gbDatos.Controls.Add(this.cmbEstadoCivil);
            this.gbDatos.Controls.Add(this.cmbPlanMedico);
            this.gbDatos.Controls.Add(this.label14);
            this.gbDatos.Controls.Add(this.label12);
            this.gbDatos.Controls.Add(this.cmbSexo);
            this.gbDatos.Controls.Add(this.label11);
            this.gbDatos.Controls.Add(this.label10);
            this.gbDatos.Controls.Add(this.tbNombreUsuario);
            this.gbDatos.Controls.Add(this.label9);
            this.gbDatos.Controls.Add(this.tbMail);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.tbTelefono);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.tbNumeroDni);
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
            this.gbDatos.Size = new System.Drawing.Size(702, 354);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos:";
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(33, 297);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(153, 37);
            this.bGuardar.TabIndex = 0;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 58;
            this.label14.Text = "Plan médico:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Estado civil:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(501, 133);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(138, 21);
            this.cmbSexo.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(483, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Sexo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(483, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Nombre de usuario:";
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.Location = new System.Drawing.Point(499, 90);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(140, 20);
            this.tbNombreUsuario.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(483, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Mail:";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(499, 47);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(140, 20);
            this.tbMail.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Teléfono:";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(274, 133);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(140, 20);
            this.tbTelefono.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Número de documento:";
            // 
            // tbNumeroDni
            // 
            this.tbNumeroDni.Location = new System.Drawing.Point(274, 90);
            this.tbNumeroDni.Name = "tbNumeroDni";
            this.tbNumeroDni.Size = new System.Drawing.Size(140, 20);
            this.tbNumeroDni.TabIndex = 45;
            // 
            // cmbTipoDNI
            // 
            this.cmbTipoDNI.FormattingEnabled = true;
            this.cmbTipoDNI.Items.AddRange(new object[] {
            "DNI",
            "LE",
            "LC"});
            this.cmbTipoDNI.Location = new System.Drawing.Point(276, 47);
            this.cmbTipoDNI.Name = "cmbTipoDNI";
            this.cmbTipoDNI.Size = new System.Drawing.Size(61, 21);
            this.cmbTipoDNI.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 27);
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
            this.tbDireccion.TabIndex = 41;
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
            this.tbApellido.TabIndex = 39;
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
            this.tbNombre.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Orden:";
            // 
            // tbOrden
            // 
            this.tbOrden.Enabled = false;
            this.tbOrden.Location = new System.Drawing.Point(47, 130);
            this.tbOrden.Name = "tbOrden";
            this.tbOrden.Size = new System.Drawing.Size(140, 20);
            this.tbOrden.TabIndex = 34;
            // 
            // cmbGrupoFamiliar
            // 
            this.cmbGrupoFamiliar.FormattingEnabled = true;
            this.cmbGrupoFamiliar.Location = new System.Drawing.Point(47, 53);
            this.cmbGrupoFamiliar.Name = "cmbGrupoFamiliar";
            this.cmbGrupoFamiliar.Size = new System.Drawing.Size(140, 21);
            this.cmbGrupoFamiliar.TabIndex = 59;
            // 
            // cmbPlanMedico
            // 
            this.cmbPlanMedico.FormattingEnabled = true;
            this.cmbPlanMedico.Location = new System.Drawing.Point(48, 248);
            this.cmbPlanMedico.Name = "cmbPlanMedico";
            this.cmbPlanMedico.Size = new System.Drawing.Size(140, 21);
            this.cmbPlanMedico.TabIndex = 60;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(46, 192);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(140, 21);
            this.cmbEstadoCivil.TabIndex = 61;
            // 
            // rbNuevo
            // 
            this.rbNuevo.AutoSize = true;
            this.rbNuevo.Location = new System.Drawing.Point(24, 80);
            this.rbNuevo.Name = "rbNuevo";
            this.rbNuevo.Size = new System.Drawing.Size(60, 17);
            this.rbNuevo.TabIndex = 63;
            this.rbNuevo.Text = "Nuevo:";
            this.rbNuevo.UseVisualStyleBackColor = true;
            // 
            // rbExistente
            // 
            this.rbExistente.AutoSize = true;
            this.rbExistente.Checked = true;
            this.rbExistente.Location = new System.Drawing.Point(24, 30);
            this.rbExistente.Name = "rbExistente";
            this.rbExistente.Size = new System.Drawing.Size(71, 17);
            this.rbExistente.TabIndex = 64;
            this.rbExistente.TabStop = true;
            this.rbExistente.Text = "Existente:";
            this.rbExistente.UseVisualStyleBackColor = true;
            this.rbExistente.CheckedChanged += new System.EventHandler(this.rbExistente_CheckedChanged);
            // 
            // gbGrupo
            // 
            this.gbGrupo.Controls.Add(this.rbExistente);
            this.gbGrupo.Controls.Add(this.tbOrden);
            this.gbGrupo.Controls.Add(this.label2);
            this.gbGrupo.Controls.Add(this.rbNuevo);
            this.gbGrupo.Controls.Add(this.cmbGrupoFamiliar);
            this.gbGrupo.Location = new System.Drawing.Point(214, 176);
            this.gbGrupo.Name = "gbGrupo";
            this.gbGrupo.Size = new System.Drawing.Size(217, 164);
            this.gbGrupo.TabIndex = 66;
            this.gbGrupo.TabStop = false;
            this.gbGrupo.Text = "Grupo familiar:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(473, 192);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 121);
            this.listBox1.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Integrantes del grupo:";
            // 
            // bAgregarACargo
            // 
            this.bAgregarACargo.Location = new System.Drawing.Point(473, 319);
            this.bAgregarACargo.Name = "bAgregarACargo";
            this.bAgregarACargo.Size = new System.Drawing.Size(223, 21);
            this.bAgregarACargo.TabIndex = 70;
            this.bAgregarACargo.Text = "Agregar integrante";
            this.bAgregarACargo.UseVisualStyleBackColor = true;
            this.bAgregarACargo.Click += new System.EventHandler(this.bAgregarACargo_Click);
            // 
            // EditAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 374);
            this.Controls.Add(this.gbDatos);
            this.Name = "EditAfiliado";
            this.Text = "EditAfiliado";
            this.Load += new System.EventHandler(this.EditAfiliado_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbGrupo.ResumeLayout(false);
            this.gbGrupo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.ComboBox cmbGrupoFamiliar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNombreUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTelefono;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOrden;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.ComboBox cmbPlanMedico;
        private System.Windows.Forms.RadioButton rbExistente;
        private System.Windows.Forms.RadioButton rbNuevo;
        private System.Windows.Forms.GroupBox gbGrupo;
        private System.Windows.Forms.Button bAgregarACargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}