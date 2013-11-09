namespace Clinica_Frba.Cancelar_Atencion {
    partial class CancelarProfesional {
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
            this.gbMotivo = new System.Windows.Forms.GroupBox();
            this.bVolver = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDetalle = new System.Windows.Forms.TextBox();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.gbSeleccion = new System.Windows.Forms.GroupBox();
            this.bSeleccionar = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.gbMotivo.SuspendLayout();
            this.gbSeleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMotivo
            // 
            this.gbMotivo.Controls.Add(this.bVolver);
            this.gbMotivo.Controls.Add(this.bAceptar);
            this.gbMotivo.Controls.Add(this.label1);
            this.gbMotivo.Controls.Add(this.tbDetalle);
            this.gbMotivo.Controls.Add(this.cmbMotivo);
            this.gbMotivo.Enabled = false;
            this.gbMotivo.Location = new System.Drawing.Point(285, 12);
            this.gbMotivo.Name = "gbMotivo";
            this.gbMotivo.Size = new System.Drawing.Size(271, 246);
            this.gbMotivo.TabIndex = 4;
            this.gbMotivo.TabStop = false;
            this.gbMotivo.Text = "Motivo de cancelación";
            // 
            // bVolver
            // 
            this.bVolver.Location = new System.Drawing.Point(23, 217);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(111, 23);
            this.bVolver.TabIndex = 4;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(142, 217);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(111, 23);
            this.bAceptar.TabIndex = 3;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Detalle:";
            // 
            // tbDetalle
            // 
            this.tbDetalle.Location = new System.Drawing.Point(23, 68);
            this.tbDetalle.Multiline = true;
            this.tbDetalle.Name = "tbDetalle";
            this.tbDetalle.Size = new System.Drawing.Size(230, 142);
            this.tbDetalle.TabIndex = 1;
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Location = new System.Drawing.Point(23, 24);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(230, 21);
            this.cmbMotivo.TabIndex = 0;
            // 
            // gbSeleccion
            // 
            this.gbSeleccion.Controls.Add(this.monthCalendar);
            this.gbSeleccion.Controls.Add(this.bSeleccionar);
            this.gbSeleccion.Location = new System.Drawing.Point(12, 12);
            this.gbSeleccion.Name = "gbSeleccion";
            this.gbSeleccion.Size = new System.Drawing.Size(267, 246);
            this.gbSeleccion.TabIndex = 3;
            this.gbSeleccion.TabStop = false;
            this.gbSeleccion.Text = "Selección de turnos";
            // 
            // bSeleccionar
            // 
            this.bSeleccionar.Location = new System.Drawing.Point(22, 217);
            this.bSeleccionar.Name = "bSeleccionar";
            this.bSeleccionar.Size = new System.Drawing.Size(227, 23);
            this.bSeleccionar.TabIndex = 2;
            this.bSeleccionar.Text = "Seleccionar dias";
            this.bSeleccionar.UseVisualStyleBackColor = true;
            this.bSeleccionar.Click += new System.EventHandler(this.bSeleccionar_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(22, 24);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 3;
            // 
            // CancelarProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 267);
            this.Controls.Add(this.gbMotivo);
            this.Controls.Add(this.gbSeleccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CancelarProfesional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar atención";
            this.Load += new System.EventHandler(this.CancelarProfesional_Load);
            this.gbMotivo.ResumeLayout(false);
            this.gbMotivo.PerformLayout();
            this.gbSeleccion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMotivo;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDetalle;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.GroupBox gbSeleccion;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button bSeleccionar;
    }
}