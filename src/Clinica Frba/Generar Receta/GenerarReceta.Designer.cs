﻿namespace Clinica_Frba.Generar_Receta
{
    partial class GenerarReceta
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
            this.tbBono = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bQuitar = new System.Windows.Forms.Button();
            this.lbMedicamentos = new System.Windows.Forms.ListBox();
            this.bgMedicamentos = new System.Windows.Forms.GroupBox();
            this.bGrabar = new System.Windows.Forms.Button();
            this.lbTurnos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bgMedicamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBono
            // 
            this.tbBono.Location = new System.Drawing.Point(103, 19);
            this.tbBono.Mask = "0000000";
            this.tbBono.Name = "tbBono";
            this.tbBono.Size = new System.Drawing.Size(93, 20);
            this.tbBono.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bono Farmacia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "(Maximo 5)";
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(6, 144);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(108, 23);
            this.bAgregar.TabIndex = 4;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bQuitar
            // 
            this.bQuitar.Location = new System.Drawing.Point(220, 144);
            this.bQuitar.Name = "bQuitar";
            this.bQuitar.Size = new System.Drawing.Size(96, 23);
            this.bQuitar.TabIndex = 5;
            this.bQuitar.Text = "Quitar";
            this.bQuitar.UseVisualStyleBackColor = true;
            this.bQuitar.Click += new System.EventHandler(this.bQuitar_Click);
            // 
            // lbMedicamentos
            // 
            this.lbMedicamentos.FormattingEnabled = true;
            this.lbMedicamentos.Location = new System.Drawing.Point(6, 43);
            this.lbMedicamentos.Name = "lbMedicamentos";
            this.lbMedicamentos.Size = new System.Drawing.Size(310, 95);
            this.lbMedicamentos.TabIndex = 6;
            // 
            // bgMedicamentos
            // 
            this.bgMedicamentos.Controls.Add(this.lbMedicamentos);
            this.bgMedicamentos.Controls.Add(this.bQuitar);
            this.bgMedicamentos.Controls.Add(this.label2);
            this.bgMedicamentos.Controls.Add(this.bAgregar);
            this.bgMedicamentos.Location = new System.Drawing.Point(417, 54);
            this.bgMedicamentos.Name = "bgMedicamentos";
            this.bgMedicamentos.Size = new System.Drawing.Size(322, 182);
            this.bgMedicamentos.TabIndex = 7;
            this.bgMedicamentos.TabStop = false;
            this.bgMedicamentos.Text = "Medicamentos";
            // 
            // bGrabar
            // 
            this.bGrabar.Location = new System.Drawing.Point(417, 263);
            this.bGrabar.Name = "bGrabar";
            this.bGrabar.Size = new System.Drawing.Size(322, 39);
            this.bGrabar.TabIndex = 8;
            this.bGrabar.Text = "Grabar";
            this.bGrabar.UseVisualStyleBackColor = true;
            this.bGrabar.Click += new System.EventHandler(this.bGrabar_Click);
            // 
            // lbTurnos
            // 
            this.lbTurnos.FormattingEnabled = true;
            this.lbTurnos.Location = new System.Drawing.Point(12, 70);
            this.lbTurnos.Name = "lbTurnos";
            this.lbTurnos.Size = new System.Drawing.Size(385, 251);
            this.lbTurnos.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seleccione el turno";
            // 
            // GenerarReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 332);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTurnos);
            this.Controls.Add(this.bGrabar);
            this.Controls.Add(this.bgMedicamentos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GenerarReceta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Receta";
            this.Load += new System.EventHandler(this.GenerarReceta_Load);
            this.bgMedicamentos.ResumeLayout(false);
            this.bgMedicamentos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tbBono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bQuitar;
        private System.Windows.Forms.ListBox lbMedicamentos;
        private System.Windows.Forms.GroupBox bgMedicamentos;
        private System.Windows.Forms.Button bGrabar;
        private System.Windows.Forms.ListBox lbTurnos;
        private System.Windows.Forms.Label label3;
    }
}