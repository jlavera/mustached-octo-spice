namespace Clinica_Frba.Listados_Estadisticos {
    partial class ListadosEstadisticos {
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
            this.rbSegundo = new System.Windows.Forms.RadioButton();
            this.rbPrimer = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSegundo);
            this.groupBox1.Controls.Add(this.rbPrimer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.b4);
            this.groupBox1.Controls.Add(this.b3);
            this.groupBox1.Controls.Add(this.b2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.b1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 291);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultas estadísticas";
            // 
            // rbSegundo
            // 
            this.rbSegundo.AutoSize = true;
            this.rbSegundo.Location = new System.Drawing.Point(340, 31);
            this.rbSegundo.Name = "rbSegundo";
            this.rbSegundo.Size = new System.Drawing.Size(113, 17);
            this.rbSegundo.TabIndex = 10;
            this.rbSegundo.Text = "Segundo semestre";
            this.rbSegundo.UseVisualStyleBackColor = true;
            // 
            // rbPrimer
            // 
            this.rbPrimer.AutoSize = true;
            this.rbPrimer.Checked = true;
            this.rbPrimer.Location = new System.Drawing.Point(169, 31);
            this.rbPrimer.Name = "rbPrimer";
            this.rbPrimer.Size = new System.Drawing.Size(99, 17);
            this.rbPrimer.TabIndex = 9;
            this.rbPrimer.TabStop = true;
            this.rbPrimer.Text = "Primer semestre";
            this.rbPrimer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Top 10 de los afiliados que utilizaron bonos que ellos mismo no compraron.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(382, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Top 5 de las especialidades de médicos con más bonos de farmacia recetados.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Top 5 de la cantidad total de bonos farmacia vencidos por afiliado.";
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(586, 220);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 23);
            this.b4.TabIndex = 4;
            this.b4.Text = "Ver";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(586, 171);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 23);
            this.b3.TabIndex = 3;
            this.b3.Text = "Ver";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(586, 126);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 23);
            this.b2.TabIndex = 2;
            this.b2.Text = "Ver";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Top 5 de las especialidades que más se registraron cancelaciones, tanto de pacien" +
                "tes como de profesionales.";
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(586, 82);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 0;
            this.b1.Text = "Ver";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b_Click);
            // 
            // ListadosEstadisticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 312);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListadosEstadisticos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadosEstadisticos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSegundo;
        private System.Windows.Forms.RadioButton rbPrimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b1;
    }
}