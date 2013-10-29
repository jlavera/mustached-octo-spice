namespace Clinica_Frba
{
    partial class Form1
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
            this.bAfiliados = new System.Windows.Forms.Button();
            this.bEspeMed = new System.Windows.Forms.Button();
            this.bPlanes = new System.Windows.Forms.Button();
            this.bProfe = new System.Windows.Forms.Button();
            this.bRoles = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAfiliados
            // 
            this.bAfiliados.Location = new System.Drawing.Point(6, 19);
            this.bAfiliados.Name = "bAfiliados";
            this.bAfiliados.Size = new System.Drawing.Size(207, 41);
            this.bAfiliados.TabIndex = 0;
            this.bAfiliados.Text = "Afiliados";
            this.bAfiliados.UseVisualStyleBackColor = true;
            // 
            // bEspeMed
            // 
            this.bEspeMed.Location = new System.Drawing.Point(6, 82);
            this.bEspeMed.Name = "bEspeMed";
            this.bEspeMed.Size = new System.Drawing.Size(207, 37);
            this.bEspeMed.TabIndex = 1;
            this.bEspeMed.Text = "Especialidades Médicas";
            this.bEspeMed.UseVisualStyleBackColor = true;
            // 
            // bPlanes
            // 
            this.bPlanes.Location = new System.Drawing.Point(6, 144);
            this.bPlanes.Name = "bPlanes";
            this.bPlanes.Size = new System.Drawing.Size(207, 37);
            this.bPlanes.TabIndex = 2;
            this.bPlanes.Text = "Planes";
            this.bPlanes.UseVisualStyleBackColor = true;
            // 
            // bProfe
            // 
            this.bProfe.Location = new System.Drawing.Point(6, 209);
            this.bProfe.Name = "bProfe";
            this.bProfe.Size = new System.Drawing.Size(207, 37);
            this.bProfe.TabIndex = 3;
            this.bProfe.Text = "Profesionales";
            this.bProfe.UseVisualStyleBackColor = true;
            // 
            // bRoles
            // 
            this.bRoles.Location = new System.Drawing.Point(6, 270);
            this.bRoles.Name = "bRoles";
            this.bRoles.Size = new System.Drawing.Size(207, 37);
            this.bRoles.TabIndex = 4;
            this.bRoles.Text = "Roles";
            this.bRoles.UseVisualStyleBackColor = true;
            this.bRoles.Click += new System.EventHandler(this.bRoles_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bAfiliados);
            this.groupBox1.Controls.Add(this.bRoles);
            this.groupBox1.Controls.Add(this.bEspeMed);
            this.groupBox1.Controls.Add(this.bProfe);
            this.groupBox1.Controls.Add(this.bPlanes);
            this.groupBox1.Location = new System.Drawing.Point(277, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 321);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ABMs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 351);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAfiliados;
        private System.Windows.Forms.Button bEspeMed;
        private System.Windows.Forms.Button bPlanes;
        private System.Windows.Forms.Button bProfe;
        private System.Windows.Forms.Button bRoles;
        private System.Windows.Forms.GroupBox groupBox1;


    }
}

