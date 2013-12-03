namespace Clinica_Frba.Cancelar_Atencion {
    partial class Botonera {
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
            this.bAfiliado = new System.Windows.Forms.Button();
            this.bProfesional = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAfiliado
            // 
            this.bAfiliado.Location = new System.Drawing.Point(37, 12);
            this.bAfiliado.Name = "bAfiliado";
            this.bAfiliado.Size = new System.Drawing.Size(97, 23);
            this.bAfiliado.TabIndex = 0;
            this.bAfiliado.Text = "Afiliado";
            this.bAfiliado.UseVisualStyleBackColor = true;
            this.bAfiliado.Click += new System.EventHandler(this.bAfiliado_Click);
            // 
            // bProfesional
            // 
            this.bProfesional.Location = new System.Drawing.Point(165, 12);
            this.bProfesional.Name = "bProfesional";
            this.bProfesional.Size = new System.Drawing.Size(97, 23);
            this.bProfesional.TabIndex = 1;
            this.bProfesional.Text = "Profesional";
            this.bProfesional.UseVisualStyleBackColor = true;
            this.bProfesional.Click += new System.EventHandler(this.bProfesional_Click);
            // 
            // Botonera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 48);
            this.Controls.Add(this.bProfesional);
            this.Controls.Add(this.bAfiliado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Botonera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione el rol";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAfiliado;
        private System.Windows.Forms.Button bProfesional;
    }
}