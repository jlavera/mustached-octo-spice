﻿namespace Clinica_Frba.Comprar_Bono
{
    partial class ComprarBono
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
            this.label2 = new System.Windows.Forms.Label();
            this.bComprar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nFarmacia = new System.Windows.Forms.NumericUpDown();
            this.nConsulta = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nFarmacia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bonos comprados en esta session:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bono Farmacia";
            // 
            // bComprar
            // 
            this.bComprar.Location = new System.Drawing.Point(21, 116);
            this.bComprar.Name = "bComprar";
            this.bComprar.Size = new System.Drawing.Size(172, 39);
            this.bComprar.TabIndex = 5;
            this.bComprar.Text = "Comprar";
            this.bComprar.UseVisualStyleBackColor = true;
            this.bComprar.Click += new System.EventHandler(this.bComprar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bono Consulta";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Enabled = false;
            this.tbPrecio.Location = new System.Drawing.Point(101, 90);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPrecio.Size = new System.Drawing.Size(67, 20);
            this.tbPrecio.TabIndex = 8;
            this.tbPrecio.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Precio $";
            // 
            // nFarmacia
            // 
            this.nFarmacia.Location = new System.Drawing.Point(21, 48);
            this.nFarmacia.Name = "nFarmacia";
            this.nFarmacia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nFarmacia.Size = new System.Drawing.Size(75, 20);
            this.nFarmacia.TabIndex = 12;
            this.nFarmacia.ValueChanged += new System.EventHandler(this.actualizarPrecio);
            // 
            // nConsulta
            // 
            this.nConsulta.Location = new System.Drawing.Point(120, 48);
            this.nConsulta.Name = "nConsulta";
            this.nConsulta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nConsulta.Size = new System.Drawing.Size(73, 20);
            this.nConsulta.TabIndex = 13;
            this.nConsulta.ValueChanged += new System.EventHandler(this.actualizarPrecio);
            // 
            // ComprarBono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 162);
            this.Controls.Add(this.nConsulta);
            this.Controls.Add(this.nFarmacia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bComprar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ComprarBono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combrar Bonos";
            this.Load += new System.EventHandler(this.ComprarBono_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nFarmacia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bComprar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nFarmacia;
        private System.Windows.Forms.NumericUpDown nConsulta;
    }
}