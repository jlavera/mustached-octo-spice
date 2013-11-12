namespace Clinica_Frba.Generar_Receta {
    partial class CargarMedicamentos {
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
            this.components = new System.ComponentModel.Container();
            this.lbMedicamento = new System.Windows.Forms.ListBox();
            this.bFiltrar = new System.Windows.Forms.Button();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.bAgregar = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.nCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPrescripcion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMedicamento
            // 
            this.lbMedicamento.FormattingEnabled = true;
            this.lbMedicamento.Location = new System.Drawing.Point(12, 41);
            this.lbMedicamento.Name = "lbMedicamento";
            this.lbMedicamento.Size = new System.Drawing.Size(518, 160);
            this.lbMedicamento.TabIndex = 0;
            // 
            // bFiltrar
            // 
            this.bFiltrar.Location = new System.Drawing.Point(455, 9);
            this.bFiltrar.Name = "bFiltrar";
            this.bFiltrar.Size = new System.Drawing.Size(75, 23);
            this.bFiltrar.TabIndex = 1;
            this.bFiltrar.Text = "Filtrar";
            this.bFiltrar.UseVisualStyleBackColor = true;
            this.bFiltrar.Click += new System.EventHandler(this.bFiltrar_Click);
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(99, 12);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(350, 20);
            this.tbFiltro.TabIndex = 2;
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(410, 207);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(120, 31);
            this.bAgregar.TabIndex = 3;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // nCantidad
            // 
            this.nCantidad.Location = new System.Drawing.Point(354, 214);
            this.nCantidad.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nCantidad.Name = "nCantidad";
            this.nCantidad.Size = new System.Drawing.Size(50, 20);
            this.nCantidad.TabIndex = 4;
            this.nCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre parcial:";
            // 
            // dtpPrescripcion
            // 
            this.dtpPrescripcion.Location = new System.Drawing.Point(86, 218);
            this.dtpPrescripcion.Name = "dtpPrescripcion";
            this.dtpPrescripcion.Size = new System.Drawing.Size(200, 20);
            this.dtpPrescripcion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prescripcion:";
            // 
            // CargarMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 252);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpPrescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nCantidad);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.bFiltrar);
            this.Controls.Add(this.lbMedicamento);
            this.Name = "CargarMedicamentos";
            this.Text = "Medicamentos";
            this.Load += new System.EventHandler(this.Medicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMedicamento;
        private System.Windows.Forms.Button bFiltrar;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NumericUpDown nCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPrescripcion;
        private System.Windows.Forms.Label label2;
    }
}