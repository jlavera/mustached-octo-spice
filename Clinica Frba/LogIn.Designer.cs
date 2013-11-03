namespace Clinica_Frba {
    partial class LogIn {
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
            this.bEntrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbRoles = new System.Windows.Forms.ListBox();
            this.bValidar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bEntrar
            // 
            this.bEntrar.Enabled = false;
            this.bEntrar.Location = new System.Drawing.Point(107, 274);
            this.bEntrar.Name = "bEntrar";
            this.bEntrar.Size = new System.Drawing.Size(142, 44);
            this.bEntrar.TabIndex = 4;
            this.bEntrar.Text = "Entrar";
            this.bEntrar.UseVisualStyleBackColor = true;
            this.bEntrar.Click += new System.EventHandler(this.bEntrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(25, 34);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(121, 20);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.Text = "admin";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(200, 34);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(142, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Text = "w23e";
            // 
            // lbRoles
            // 
            this.lbRoles.Enabled = false;
            this.lbRoles.FormattingEnabled = true;
            this.lbRoles.Location = new System.Drawing.Point(107, 125);
            this.lbRoles.Name = "lbRoles";
            this.lbRoles.Size = new System.Drawing.Size(142, 134);
            this.lbRoles.TabIndex = 3;
            // 
            // bValidar
            // 
            this.bValidar.Location = new System.Drawing.Point(107, 66);
            this.bValidar.Name = "bValidar";
            this.bValidar.Size = new System.Drawing.Size(142, 44);
            this.bValidar.TabIndex = 2;
            this.bValidar.Text = "Validar";
            this.bValidar.UseVisualStyleBackColor = true;
            this.bValidar.Click += new System.EventHandler(this.bValidar_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 330);
            this.Controls.Add(this.bValidar);
            this.Controls.Add(this.lbRoles);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ListBox lbRoles;
        private System.Windows.Forms.Button bValidar;
    }
}