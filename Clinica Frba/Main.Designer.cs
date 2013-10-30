namespace Clinica_Frba
{
    partial class Main
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
            this.Abm_Afiliado = new System.Windows.Forms.Button();
            this.Abm_Especialidades_Medicas = new System.Windows.Forms.Button();
            this.Abm_Planes_Medicos = new System.Windows.Forms.Button();
            this.Abm_Profesional = new System.Windows.Forms.Button();
            this.Abm_Rol = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flp1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Abm_Usuario = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flp2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Agendas = new System.Windows.Forms.Button();
            this.Bonos = new System.Windows.Forms.Button();
            this.Turnos = new System.Windows.Forms.Button();
            this.Registro_de_Llegada = new System.Windows.Forms.Button();
            this.Registro_de_Resultado = new System.Windows.Forms.Button();
            this.Cancelar_atencion = new System.Windows.Forms.Button();
            this.Receta = new System.Windows.Forms.Button();
            this.Estadisticas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flp1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Abm_Afiliado
            // 
            this.Abm_Afiliado.Location = new System.Drawing.Point(3, 3);
            this.Abm_Afiliado.Name = "Abm_Afiliado";
            this.Abm_Afiliado.Size = new System.Drawing.Size(207, 41);
            this.Abm_Afiliado.TabIndex = 0;
            this.Abm_Afiliado.Text = "Afiliados";
            this.Abm_Afiliado.UseVisualStyleBackColor = true;
            this.Abm_Afiliado.Visible = false;
            this.Abm_Afiliado.Click += new System.EventHandler(this.Abm_Afiliado_Click);
            // 
            // Abm_Especialidades_Medicas
            // 
            this.Abm_Especialidades_Medicas.Location = new System.Drawing.Point(3, 136);
            this.Abm_Especialidades_Medicas.Name = "Abm_Especialidades_Medicas";
            this.Abm_Especialidades_Medicas.Size = new System.Drawing.Size(207, 37);
            this.Abm_Especialidades_Medicas.TabIndex = 3;
            this.Abm_Especialidades_Medicas.Text = "Especialidades Médicas";
            this.Abm_Especialidades_Medicas.UseVisualStyleBackColor = true;
            this.Abm_Especialidades_Medicas.Visible = false;
            this.Abm_Especialidades_Medicas.Click += new System.EventHandler(this.Abm_Especialidades_Medicas_Click);
            // 
            // Abm_Planes_Medicos
            // 
            this.Abm_Planes_Medicos.Location = new System.Drawing.Point(3, 50);
            this.Abm_Planes_Medicos.Name = "Abm_Planes_Medicos";
            this.Abm_Planes_Medicos.Size = new System.Drawing.Size(207, 37);
            this.Abm_Planes_Medicos.TabIndex = 1;
            this.Abm_Planes_Medicos.Text = "Planes";
            this.Abm_Planes_Medicos.UseVisualStyleBackColor = true;
            this.Abm_Planes_Medicos.Visible = false;
            this.Abm_Planes_Medicos.Click += new System.EventHandler(this.Abm_Planes_Medicos_Click);
            // 
            // Abm_Profesional
            // 
            this.Abm_Profesional.Location = new System.Drawing.Point(3, 93);
            this.Abm_Profesional.Name = "Abm_Profesional";
            this.Abm_Profesional.Size = new System.Drawing.Size(207, 37);
            this.Abm_Profesional.TabIndex = 2;
            this.Abm_Profesional.Text = "Profesionales";
            this.Abm_Profesional.UseVisualStyleBackColor = true;
            this.Abm_Profesional.Visible = false;
            this.Abm_Profesional.Click += new System.EventHandler(this.Abm_Profesional_Click);
            // 
            // Abm_Rol
            // 
            this.Abm_Rol.Location = new System.Drawing.Point(3, 179);
            this.Abm_Rol.Name = "Abm_Rol";
            this.Abm_Rol.Size = new System.Drawing.Size(207, 37);
            this.Abm_Rol.TabIndex = 4;
            this.Abm_Rol.Text = "Roles";
            this.Abm_Rol.UseVisualStyleBackColor = true;
            this.Abm_Rol.Visible = false;
            this.Abm_Rol.Click += new System.EventHandler(this.Abm_Roles_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flp1);
            this.groupBox1.Location = new System.Drawing.Point(599, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 296);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ABMs";
            // 
            // flp1
            // 
            this.flp1.Controls.Add(this.Abm_Afiliado);
            this.flp1.Controls.Add(this.Abm_Planes_Medicos);
            this.flp1.Controls.Add(this.Abm_Profesional);
            this.flp1.Controls.Add(this.Abm_Especialidades_Medicas);
            this.flp1.Controls.Add(this.Abm_Rol);
            this.flp1.Controls.Add(this.Abm_Usuario);
            this.flp1.Location = new System.Drawing.Point(56, 17);
            this.flp1.Name = "flp1";
            this.flp1.Size = new System.Drawing.Size(214, 266);
            this.flp1.TabIndex = 6;
            // 
            // Abm_Usuario
            // 
            this.Abm_Usuario.Location = new System.Drawing.Point(3, 222);
            this.Abm_Usuario.Name = "Abm_Usuario";
            this.Abm_Usuario.Size = new System.Drawing.Size(207, 35);
            this.Abm_Usuario.TabIndex = 5;
            this.Abm_Usuario.Text = "Usuarios";
            this.Abm_Usuario.UseVisualStyleBackColor = true;
            this.Abm_Usuario.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flp2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 296);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionalidades";
            // 
            // flp2
            // 
            this.flp2.Controls.Add(this.Agendas);
            this.flp2.Controls.Add(this.Bonos);
            this.flp2.Controls.Add(this.Turnos);
            this.flp2.Controls.Add(this.Registro_de_Llegada);
            this.flp2.Controls.Add(this.Registro_de_Resultado);
            this.flp2.Controls.Add(this.Cancelar_atencion);
            this.flp2.Controls.Add(this.Receta);
            this.flp2.Controls.Add(this.Estadisticas);
            this.flp2.Location = new System.Drawing.Point(95, 19);
            this.flp2.Name = "flp2";
            this.flp2.Size = new System.Drawing.Size(464, 271);
            this.flp2.TabIndex = 0;
            // 
            // Agendas
            // 
            this.Agendas.Location = new System.Drawing.Point(3, 3);
            this.Agendas.Name = "Agendas";
            this.Agendas.Size = new System.Drawing.Size(75, 23);
            this.Agendas.TabIndex = 0;
            this.Agendas.Text = "Agendas";
            this.Agendas.UseVisualStyleBackColor = true;
            this.Agendas.Visible = false;
            // 
            // Bonos
            // 
            this.Bonos.Location = new System.Drawing.Point(84, 3);
            this.Bonos.Name = "Bonos";
            this.Bonos.Size = new System.Drawing.Size(75, 23);
            this.Bonos.TabIndex = 1;
            this.Bonos.Text = "Bonos";
            this.Bonos.UseVisualStyleBackColor = true;
            this.Bonos.Visible = false;
            // 
            // Turnos
            // 
            this.Turnos.Location = new System.Drawing.Point(165, 3);
            this.Turnos.Name = "Turnos";
            this.Turnos.Size = new System.Drawing.Size(75, 23);
            this.Turnos.TabIndex = 2;
            this.Turnos.Text = "Turnos";
            this.Turnos.UseVisualStyleBackColor = true;
            this.Turnos.Visible = false;
            // 
            // Registro_de_Llegada
            // 
            this.Registro_de_Llegada.Location = new System.Drawing.Point(246, 3);
            this.Registro_de_Llegada.Name = "Registro_de_Llegada";
            this.Registro_de_Llegada.Size = new System.Drawing.Size(75, 23);
            this.Registro_de_Llegada.TabIndex = 3;
            this.Registro_de_Llegada.Text = "Registro de llegada";
            this.Registro_de_Llegada.UseVisualStyleBackColor = true;
            this.Registro_de_Llegada.Visible = false;
            // 
            // Registro_de_Resultado
            // 
            this.Registro_de_Resultado.Location = new System.Drawing.Point(327, 3);
            this.Registro_de_Resultado.Name = "Registro_de_Resultado";
            this.Registro_de_Resultado.Size = new System.Drawing.Size(75, 23);
            this.Registro_de_Resultado.TabIndex = 4;
            this.Registro_de_Resultado.Text = "Registro de Resultado";
            this.Registro_de_Resultado.UseVisualStyleBackColor = true;
            this.Registro_de_Resultado.Visible = false;
            // 
            // Cancelar_atencion
            // 
            this.Cancelar_atencion.Location = new System.Drawing.Point(3, 32);
            this.Cancelar_atencion.Name = "Cancelar_atencion";
            this.Cancelar_atencion.Size = new System.Drawing.Size(75, 23);
            this.Cancelar_atencion.TabIndex = 5;
            this.Cancelar_atencion.Text = "Cancelar atención";
            this.Cancelar_atencion.UseVisualStyleBackColor = true;
            this.Cancelar_atencion.Visible = false;
            // 
            // Receta
            // 
            this.Receta.Location = new System.Drawing.Point(84, 32);
            this.Receta.Name = "Receta";
            this.Receta.Size = new System.Drawing.Size(75, 23);
            this.Receta.TabIndex = 6;
            this.Receta.Text = "Receta";
            this.Receta.UseVisualStyleBackColor = true;
            this.Receta.Visible = false;
            // 
            // Estadisticas
            // 
            this.Estadisticas.Location = new System.Drawing.Point(165, 32);
            this.Estadisticas.Name = "Estadisticas";
            this.Estadisticas.Size = new System.Drawing.Size(75, 23);
            this.Estadisticas.TabIndex = 7;
            this.Estadisticas.Text = "Estadísticas";
            this.Estadisticas.UseVisualStyleBackColor = true;
            this.Estadisticas.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 317);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.flp1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flp2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Abm_Afiliado;
        private System.Windows.Forms.Button Abm_Especialidades_Medicas;
        private System.Windows.Forms.Button Abm_Planes_Medicos;
        private System.Windows.Forms.Button Abm_Profesional;
        private System.Windows.Forms.Button Abm_Rol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flp1;
        private System.Windows.Forms.Button Abm_Usuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flp2;
        private System.Windows.Forms.Button Agendas;
        private System.Windows.Forms.Button Bonos;
        private System.Windows.Forms.Button Turnos;
        private System.Windows.Forms.Button Registro_de_Llegada;
        private System.Windows.Forms.Button Registro_de_Resultado;
        private System.Windows.Forms.Button Cancelar_atencion;
        private System.Windows.Forms.Button Receta;
        private System.Windows.Forms.Button Estadisticas;


    }
}

