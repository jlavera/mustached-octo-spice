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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbProfesional = new System.Windows.Forms.ComboBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.lbDia2 = new System.Windows.Forms.ListBox();
            this.lbDia3 = new System.Windows.Forms.ListBox();
            this.lbDia4 = new System.Windows.Forms.ListBox();
            this.lbDia5 = new System.Windows.Forms.ListBox();
            this.lbDia6 = new System.Windows.Forms.ListBox();
            this.lbDia7 = new System.Windows.Forms.ListBox();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lunes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Martes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Miercoles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Jueves";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Viernes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(349, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Sabado";
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
            this.bGuardar.Location = new System.Drawing.Point(305, 13);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(103, 73);
            this.bGuardar.TabIndex = 19;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // lbDia2
            // 
            this.lbDia2.FormattingEnabled = true;
            this.lbDia2.Items.AddRange(new object[] {
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30"});
            this.lbDia2.Location = new System.Drawing.Point(45, 119);
            this.lbDia2.Name = "lbDia2";
            this.lbDia2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbDia2.Size = new System.Drawing.Size(56, 342);
            this.lbDia2.TabIndex = 20;
            // 
            // lbDia3
            // 
            this.lbDia3.FormattingEnabled = true;
            this.lbDia3.Items.AddRange(new object[] {
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30"});
            this.lbDia3.Location = new System.Drawing.Point(104, 119);
            this.lbDia3.Name = "lbDia3";
            this.lbDia3.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbDia3.Size = new System.Drawing.Size(56, 342);
            this.lbDia3.TabIndex = 21;
            // 
            // lbDia4
            // 
            this.lbDia4.FormattingEnabled = true;
            this.lbDia4.Items.AddRange(new object[] {
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30"});
            this.lbDia4.Location = new System.Drawing.Point(166, 119);
            this.lbDia4.Name = "lbDia4";
            this.lbDia4.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbDia4.Size = new System.Drawing.Size(56, 342);
            this.lbDia4.TabIndex = 22;
            // 
            // lbDia5
            // 
            this.lbDia5.FormattingEnabled = true;
            this.lbDia5.Items.AddRange(new object[] {
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30"});
            this.lbDia5.Location = new System.Drawing.Point(228, 119);
            this.lbDia5.Name = "lbDia5";
            this.lbDia5.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbDia5.Size = new System.Drawing.Size(56, 342);
            this.lbDia5.TabIndex = 23;
            // 
            // lbDia6
            // 
            this.lbDia6.FormattingEnabled = true;
            this.lbDia6.Items.AddRange(new object[] {
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30"});
            this.lbDia6.Location = new System.Drawing.Point(290, 119);
            this.lbDia6.Name = "lbDia6";
            this.lbDia6.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbDia6.Size = new System.Drawing.Size(56, 342);
            this.lbDia6.TabIndex = 24;
            // 
            // lbDia7
            // 
            this.lbDia7.FormattingEnabled = true;
            this.lbDia7.Items.AddRange(new object[] {
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30"});
            this.lbDia7.Location = new System.Drawing.Point(352, 197);
            this.lbDia7.Name = "lbDia7";
            this.lbDia7.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbDia7.Size = new System.Drawing.Size(56, 134);
            this.lbDia7.TabIndex = 25;
            // 
            // EditAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 473);
            this.Controls.Add(this.lbDia7);
            this.Controls.Add(this.lbDia6);
            this.Controls.Add(this.lbDia5);
            this.Controls.Add(this.lbDia4);
            this.Controls.Add(this.lbDia3);
            this.Controls.Add(this.lbDia2);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.cbProfesional);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbProfesional;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.ListBox lbDia2;
        private System.Windows.Forms.ListBox lbDia3;
        private System.Windows.Forms.ListBox lbDia4;
        private System.Windows.Forms.ListBox lbDia5;
        private System.Windows.Forms.ListBox lbDia6;
        private System.Windows.Forms.ListBox lbDia7;
    }
}