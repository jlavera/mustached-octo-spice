namespace Clinica_Frba.Registrar_Agenda
{
    partial class EditAgenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.cbProfesional = new System.Windows.Forms.ComboBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.lbSemanal = new System.Windows.Forms.ListBox();
            this.bAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profesional:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Desde:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.CustomFormat = "dd/mm/yyyy";
            this.dtpHasta.Location = new System.Drawing.Point(86, 67);
            this.dtpHasta.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 7;
            this.dtpHasta.Value = new System.DateTime(2013, 10, 29, 0, 0, 0, 0);
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "dd/mm/yyyy";
            this.dtpDesde.Location = new System.Drawing.Point(86, 40);
            this.dtpDesde.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 6;
            this.dtpDesde.Value = new System.DateTime(2013, 10, 29, 0, 0, 0, 0);
            // 
            // cbProfesional
            // 
            this.cbProfesional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfesional.FormattingEnabled = true;
            this.cbProfesional.Location = new System.Drawing.Point(107, 10);
            this.cbProfesional.Name = "cbProfesional";
            this.cbProfesional.Size = new System.Drawing.Size(177, 21);
            this.cbProfesional.TabIndex = 18;
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(292, 12);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(103, 73);
            this.bGuardar.TabIndex = 19;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // lbSemanal
            // 
            this.lbSemanal.FormattingEnabled = true;
            this.lbSemanal.Location = new System.Drawing.Point(42, 107);
            this.lbSemanal.Name = "lbSemanal";
            this.lbSemanal.Size = new System.Drawing.Size(353, 134);
            this.lbSemanal.TabIndex = 20;
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(42, 248);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(353, 23);
            this.bAgregar.TabIndex = 21;
            this.bAgregar.Text = "Agregar horario";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click_1);
            // 
            // EditAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 283);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.lbSemanal);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.cbProfesional);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Agenda";
            this.Load += new System.EventHandler(this.EditAgenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.ComboBox cbProfesional;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.ListBox lbSemanal;
        private System.Windows.Forms.Button bAgregar;
    }
}