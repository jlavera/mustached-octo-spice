namespace Clinica_Frba.RegistroResultado {
    partial class RegistrarResultado {
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
            this.gbTurno = new System.Windows.Forms.GroupBox();
            this.bSiguiente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTurnos = new System.Windows.Forms.ListBox();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.bVolver = new System.Windows.Forms.Button();
            this.bFinalizar = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDiagnostico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSintomas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.gbTurno.SuspendLayout();
            this.gbFecha.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTurno
            // 
            this.gbTurno.Controls.Add(this.bSiguiente);
            this.gbTurno.Controls.Add(this.label1);
            this.gbTurno.Controls.Add(this.lbTurnos);
            this.gbTurno.Location = new System.Drawing.Point(12, 12);
            this.gbTurno.Name = "gbTurno";
            this.gbTurno.Size = new System.Drawing.Size(436, 481);
            this.gbTurno.TabIndex = 0;
            this.gbTurno.TabStop = false;
            this.gbTurno.Text = "Seleccionar turnos";
            // 
            // bSiguiente
            // 
            this.bSiguiente.Location = new System.Drawing.Point(41, 452);
            this.bSiguiente.Name = "bSiguiente";
            this.bSiguiente.Size = new System.Drawing.Size(364, 23);
            this.bSiguiente.TabIndex = 2;
            this.bSiguiente.Text = "Siguiente";
            this.bSiguiente.UseVisualStyleBackColor = true;
            this.bSiguiente.Click += new System.EventHandler(this.bSiguiente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Turno para registrar:";
            // 
            // lbTurnos
            // 
            this.lbTurnos.FormattingEnabled = true;
            this.lbTurnos.Location = new System.Drawing.Point(41, 36);
            this.lbTurnos.Name = "lbTurnos";
            this.lbTurnos.Size = new System.Drawing.Size(364, 407);
            this.lbTurnos.TabIndex = 0;
            this.lbTurnos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbTurnos_KeyPress);
            // 
            // gbFecha
            // 
            this.gbFecha.Controls.Add(this.bVolver);
            this.gbFecha.Controls.Add(this.bFinalizar);
            this.gbFecha.Controls.Add(this.gbDatos);
            this.gbFecha.Controls.Add(this.rbSi);
            this.gbFecha.Controls.Add(this.rbNo);
            this.gbFecha.Enabled = false;
            this.gbFecha.Location = new System.Drawing.Point(454, 13);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Size = new System.Drawing.Size(559, 480);
            this.gbFecha.TabIndex = 1;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Seleccionar fecha del turno";
            // 
            // bVolver
            // 
            this.bVolver.Location = new System.Drawing.Point(49, 451);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(186, 23);
            this.bVolver.TabIndex = 8;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bFinalizar
            // 
            this.bFinalizar.Location = new System.Drawing.Point(361, 448);
            this.bFinalizar.Name = "bFinalizar";
            this.bFinalizar.Size = new System.Drawing.Size(186, 23);
            this.bFinalizar.TabIndex = 3;
            this.bFinalizar.Text = "Finalizar";
            this.bFinalizar.UseVisualStyleBackColor = true;
            this.bFinalizar.Click += new System.EventHandler(this.bFinalizar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.tbDiagnostico);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.tbSintomas);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.dtpDia);
            this.gbDatos.Controls.Add(this.dtpHora);
            this.gbDatos.Enabled = false;
            this.gbDatos.Location = new System.Drawing.Point(49, 100);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(504, 342);
            this.gbDatos.TabIndex = 7;
            this.gbDatos.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Diagnóstico";
            // 
            // tbDiagnostico
            // 
            this.tbDiagnostico.Location = new System.Drawing.Point(29, 247);
            this.tbDiagnostico.Multiline = true;
            this.tbDiagnostico.Name = "tbDiagnostico";
            this.tbDiagnostico.Size = new System.Drawing.Size(469, 89);
            this.tbDiagnostico.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Síntomas";
            // 
            // tbSintomas
            // 
            this.tbSintomas.Location = new System.Drawing.Point(29, 132);
            this.tbSintomas.Multiline = true;
            this.tbSintomas.Name = "tbSintomas";
            this.tbSintomas.Size = new System.Drawing.Size(469, 87);
            this.tbSintomas.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha realizada la atención:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hora realizada la atención:";
            // 
            // dtpDia
            // 
            this.dtpDia.Location = new System.Drawing.Point(29, 37);
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.Size = new System.Drawing.Size(200, 20);
            this.dtpDia.TabIndex = 4;
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(132, 81);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(97, 20);
            this.dtpHora.TabIndex = 5;
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Location = new System.Drawing.Point(37, 77);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(83, 17);
            this.rbSi.TabIndex = 3;
            this.rbSi.Text = "Se concretó";
            this.rbSi.UseVisualStyleBackColor = true;
            this.rbSi.CheckedChanged += new System.EventHandler(this.rbSi_CheckedChanged);
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Checked = true;
            this.rbNo.Location = new System.Drawing.Point(37, 35);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(98, 17);
            this.rbNo.TabIndex = 2;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No se concretó";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // RegistrarResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 505);
            this.Controls.Add(this.gbFecha);
            this.Controls.Add(this.gbTurno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegistrarResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar resultado de atención";
            this.Load += new System.EventHandler(this.RegistrarResultado_Load);
            this.gbTurno.ResumeLayout(false);
            this.gbTurno.PerformLayout();
            this.gbFecha.ResumeLayout(false);
            this.gbFecha.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTurno;
        private System.Windows.Forms.Button bSiguiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbTurnos;
        private System.Windows.Forms.GroupBox gbFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.DateTimePicker dtpDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDiagnostico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSintomas;
        private System.Windows.Forms.Button bFinalizar;
        private System.Windows.Forms.Button bVolver;
    }
}