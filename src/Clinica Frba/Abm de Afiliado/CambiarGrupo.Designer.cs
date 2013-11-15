namespace Clinica_Frba.AbmAfiliados {
    partial class CambiarGrupo {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bFiltrar = new System.Windows.Forms.Button();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.lFiltro = new System.Windows.Forms.Label();
            this.cmbGrupos = new System.Windows.Forms.ComboBox();
            this.rbExistente = new System.Windows.Forms.RadioButton();
            this.rbNueva = new System.Windows.Forms.RadioButton();
            this.bGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bFiltrar);
            this.groupBox1.Controls.Add(this.tbFiltro);
            this.groupBox1.Controls.Add(this.lFiltro);
            this.groupBox1.Controls.Add(this.cmbGrupos);
            this.groupBox1.Controls.Add(this.rbExistente);
            this.groupBox1.Controls.Add(this.rbNueva);
            this.groupBox1.Controls.Add(this.bGuardar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // bFiltrar
            // 
            this.bFiltrar.Enabled = false;
            this.bFiltrar.Location = new System.Drawing.Point(99, 61);
            this.bFiltrar.Name = "bFiltrar";
            this.bFiltrar.Size = new System.Drawing.Size(147, 25);
            this.bFiltrar.TabIndex = 4;
            this.bFiltrar.Text = "Filtrar";
            this.bFiltrar.UseVisualStyleBackColor = true;
            this.bFiltrar.Click += new System.EventHandler(this.bFiltrar_Click);
            // 
            // tbFiltro
            // 
            this.tbFiltro.Enabled = false;
            this.tbFiltro.Location = new System.Drawing.Point(99, 35);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(147, 20);
            this.tbFiltro.TabIndex = 3;
            // 
            // lFiltro
            // 
            this.lFiltro.AutoSize = true;
            this.lFiltro.Enabled = false;
            this.lFiltro.Location = new System.Drawing.Point(96, 16);
            this.lFiltro.Name = "lFiltro";
            this.lFiltro.Size = new System.Drawing.Size(32, 13);
            this.lFiltro.TabIndex = 6;
            this.lFiltro.Text = "Filtro:";
            // 
            // cmbGrupos
            // 
            this.cmbGrupos.Enabled = false;
            this.cmbGrupos.FormattingEnabled = true;
            this.cmbGrupos.Location = new System.Drawing.Point(99, 92);
            this.cmbGrupos.Name = "cmbGrupos";
            this.cmbGrupos.Size = new System.Drawing.Size(147, 21);
            this.cmbGrupos.TabIndex = 5;
            // 
            // rbExistente
            // 
            this.rbExistente.AutoSize = true;
            this.rbExistente.Location = new System.Drawing.Point(9, 68);
            this.rbExistente.Name = "rbExistente";
            this.rbExistente.Size = new System.Drawing.Size(68, 17);
            this.rbExistente.TabIndex = 2;
            this.rbExistente.Text = "Existente";
            this.rbExistente.UseVisualStyleBackColor = true;
            this.rbExistente.CheckedChanged += new System.EventHandler(this.rbExistente_CheckedChanged);
            // 
            // rbNueva
            // 
            this.rbNueva.AutoSize = true;
            this.rbNueva.Checked = true;
            this.rbNueva.Location = new System.Drawing.Point(9, 35);
            this.rbNueva.Name = "rbNueva";
            this.rbNueva.Size = new System.Drawing.Size(57, 17);
            this.rbNueva.TabIndex = 1;
            this.rbNueva.TabStop = true;
            this.rbNueva.Text = "Nueva";
            this.rbNueva.UseVisualStyleBackColor = true;
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(127, 132);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 31);
            this.bGuardar.TabIndex = 6;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // CambiarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 205);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CambiarGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar de grupo familiar";
            this.Load += new System.EventHandler(this.CambiarGrupo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbExistente;
        private System.Windows.Forms.RadioButton rbNueva;
        private System.Windows.Forms.Label lFiltro;
        private System.Windows.Forms.ComboBox cmbGrupos;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Button bFiltrar;
        private System.Windows.Forms.Button bGuardar;
    }
}