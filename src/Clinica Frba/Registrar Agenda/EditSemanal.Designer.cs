namespace Clinica_Frba.Registrar_Agenda {
    partial class EditSemanal {
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
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.bAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cDia = new System.Windows.Forms.ComboBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHasta.Location = new System.Drawing.Point(54, 65);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.ShowUpDown = true;
            this.dtpHasta.Size = new System.Drawing.Size(102, 20);
            this.dtpHasta.TabIndex = 0;
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(12, 91);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(144, 23);
            this.bAceptar.TabIndex = 1;
            this.bAceptar.Text = "Agregar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde";
            // 
            // cDia
            // 
            this.cDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cDia.FormattingEnabled = true;
            this.cDia.Items.AddRange(new object[] {
            "Domingo",
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado"});
            this.cDia.Location = new System.Drawing.Point(54, 12);
            this.cDia.Name = "cDia";
            this.cDia.Size = new System.Drawing.Size(102, 21);
            this.cDia.TabIndex = 3;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDesde.Location = new System.Drawing.Point(54, 39);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.ShowUpDown = true;
            this.dtpDesde.Size = new System.Drawing.Size(102, 20);
            this.dtpDesde.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasta";
            // 
            // EditSemanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 132);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.cDia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.dtpHasta);
            this.Name = "EditSemanal";
            this.Text = "EditSemanal";
            this.Load += new System.EventHandler(this.EditSemanal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cDia;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}