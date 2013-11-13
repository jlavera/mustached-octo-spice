namespace Clinica_Frba.Cancelar_Atencion {
    partial class CancelarAfiliado {
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
            this.lbTurnos = new System.Windows.Forms.ListBox();
            this.gbSeleccion = new System.Windows.Forms.GroupBox();
            this.bSeleccionar = new System.Windows.Forms.Button();
            this.gbMotivo = new System.Windows.Forms.GroupBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bVolver = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDetalle = new System.Windows.Forms.TextBox();
            this.gbSeleccion.SuspendLayout();
            this.gbMotivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTurnos
            // 
            this.lbTurnos.FormattingEnabled = true;
            this.lbTurnos.Location = new System.Drawing.Point(22, 24);
            this.lbTurnos.Name = "lbTurnos";
            this.lbTurnos.Size = new System.Drawing.Size(373, 186);
            this.lbTurnos.TabIndex = 0;
            // 
            // gbSeleccion
            // 
            this.gbSeleccion.Controls.Add(this.bSeleccionar);
            this.gbSeleccion.Controls.Add(this.lbTurnos);
            this.gbSeleccion.Location = new System.Drawing.Point(12, 12);
            this.gbSeleccion.Name = "gbSeleccion";
            this.gbSeleccion.Size = new System.Drawing.Size(415, 246);
            this.gbSeleccion.TabIndex = 1;
            this.gbSeleccion.TabStop = false;
            this.gbSeleccion.Text = "Selección de turnos";
            // 
            // bSeleccionar
            // 
            this.bSeleccionar.Location = new System.Drawing.Point(22, 217);
            this.bSeleccionar.Name = "bSeleccionar";
            this.bSeleccionar.Size = new System.Drawing.Size(373, 23);
            this.bSeleccionar.TabIndex = 2;
            this.bSeleccionar.Text = "Seleccionar turno";
            this.bSeleccionar.UseVisualStyleBackColor = true;
            this.bSeleccionar.Click += new System.EventHandler(this.bSeleccionar_Click);
            // 
            // gbMotivo
            // 
            this.gbMotivo.Controls.Add(this.cbTipo);
            this.gbMotivo.Controls.Add(this.label2);
            this.gbMotivo.Controls.Add(this.bVolver);
            this.gbMotivo.Controls.Add(this.bAceptar);
            this.gbMotivo.Controls.Add(this.label1);
            this.gbMotivo.Controls.Add(this.tbDetalle);
            this.gbMotivo.Enabled = false;
            this.gbMotivo.Location = new System.Drawing.Point(433, 12);
            this.gbMotivo.Name = "gbMotivo";
            this.gbMotivo.Size = new System.Drawing.Size(271, 246);
            this.gbMotivo.TabIndex = 2;
            this.gbMotivo.TabStop = false;
            this.gbMotivo.Text = "Motivo de cancelación";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Enfermedad",
            "Licencia",
            "Personal"});
            this.cbTipo.Location = new System.Drawing.Point(23, 41);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(230, 21);
            this.cbTipo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo de cancelacion:";
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
            this.label1.Location = new System.Drawing.Point(20, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Detalle:";
            // 
            // tbDetalle
            // 
            this.tbDetalle.Location = new System.Drawing.Point(23, 77);
            this.tbDetalle.MaxLength = 255;
            this.tbDetalle.Multiline = true;
            this.tbDetalle.Name = "tbDetalle";
            this.tbDetalle.Size = new System.Drawing.Size(230, 133);
            this.tbDetalle.TabIndex = 1;
            // 
            // CancelarAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 269);
            this.Controls.Add(this.gbMotivo);
            this.Controls.Add(this.gbSeleccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CancelarAfiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar atención";
            this.Load += new System.EventHandler(this.CancelarAfiliado_Load);
            this.gbSeleccion.ResumeLayout(false);
            this.gbMotivo.ResumeLayout(false);
            this.gbMotivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTurnos;
        private System.Windows.Forms.GroupBox gbSeleccion;
        private System.Windows.Forms.Button bSeleccionar;
        private System.Windows.Forms.GroupBox gbMotivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDetalle;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label2;
    }
}