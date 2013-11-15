﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.Generar_Receta
{
    public partial class GenerarReceta : Form
    {
        public String reporte;
        public BonoFarmacia bono;

        private Afiliados afiliados = new Afiliados();
        private Afiliado afiliado;

        public GenerarReceta(Usuario _usuario)
        {
            InitializeComponent();
            int tmp = DB.ExecuteCardinal("SELECT TOP 1 afi_id FROM " + DB.schema + "vAfiliado WHERE usu_id=" + _usuario.id);
            if (tmp != -1) {
                afiliado = new Afiliado(tmp);
            } else {
                //Si fallo al traer afiliados, es que el usuario no es un afiliado
                MessageBox.Show("Este usuario no tiene un afiliado asociado,\na modo de debug, le vamos a dejar elejir un afiliado");
                miniAfiliado mini = new miniAfiliado();
                while (mini.DialogResult != DialogResult.OK)
                    mini.ShowDialog();
                afiliado = mini.afiliado;
            }
        }
        
        public GenerarReceta(BonoFarmacia bono){
            tbBono.Text = Convert.ToString(bono.id);
            tbBono.Enabled = false;
        }

        private void bAgregar_Click(object sender, EventArgs e) {
            Generar_Receta.CargarMedicamentos form = new Generar_Receta.CargarMedicamentos();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK) {
                if (lbMedicamentos.Items.Contains(form.medicamento))
                    MessageBox.Show("Ya estaba cargado ese medicamento");
                else
                    lbMedicamentos.Items.Add(form.medicamento);
            }
            if (lbMedicamentos.Items.Count >= 5) { //Validacion redundante, porque esta en la DB
                MessageBox.Show("Solo pueden haber 5 medicamentos por receta,\nconsidere consumir otro bono farmacia");
                bAgregar.Enabled = false;
            }
        }

        private void bQuitar_Click(object sender, EventArgs e) {
            if(lbMedicamentos.SelectedIndex != -1)
                lbMedicamentos.Items.Remove(lbMedicamentos.SelectedItem);
            if (lbMedicamentos.Items.Count < 5) //"Anti" validacion
               bAgregar.Enabled = true;
        }

        private void bGrabar_Click(object sender, EventArgs e) {
            if (tbBono.Text != "" && lbMedicamentos.Items.Count >= 1 ) {

                bono = new BonoFarmacia(Convert.ToInt32(tbBono.Text));
                //Si el comprador del bono, tiene el mismo grupo familiar que el que esta logeado
                if (DB.ExecuteCardinal("SELECT COUNT(1) FROM " + DB.schema + "bonoFarmacia JOIN " + DB.schema + "vAfiliado ON bfa_comprador=afi_id" +
                                            " WHERE bfa_id=" + tbBono.Text + " AND afi_grupoFamiliar=(SELECT afi_grupoFamiliar FROM "+DB.schema+"vAfiliado WHERE afi_id=" + afiliado.id + ");") < 0) {
                    MessageBox.Show("Este bono no pertenece al grupo familiar de '" + afiliado.ToString() + "'");
                    return;
                }

                //Generar el reporte
                ////////REPORTE//////////
                reporte += "<HTML>";
                reporte += "<BODY>";
                reporte += "Clinicas Mustache<br/><hr>";
                reporte += "<br/>	Bono consulta: " + tbBono.Text;
                reporte += "<br/>	Afiliado que comrpo el bono: " + bono.comprador.ToString();
                reporte += "<br/>	Receta a nombre de: " + afiliado.ToString();
                reporte += "<br/>	<TABLE>";
                reporte += "		<TR><TD>Medicamento</TD><TD>Cantidad</TD><TD>Expiracion</TD></TR>";
                ////////REPORTE//////////

                string subQuery = "";
                //Ciclar por los medicamentos cargados
                foreach (Medicamento m in lbMedicamentos.Items) {
                    subQuery += "(" + tbBono.Text + ", " + m.id + ", " + m.cantidad + ", '" + m.prescripcion.ToString("yyy-MM-dd") + "'), ";
                    reporte += "		<TR><TD>" + m.nombre + "</TD><TD>" + m.cantidad + "</TD><TD>" + m.prescripcion.ToString("yyy-MM-dd") + "</TD></TR>";
                }
                subQuery = subQuery.Substring(0, subQuery.Length - 2); //Sacar la ultima coma
                if (DB.ExecuteNonQuery("INSERT INTO " + DB.schema + "medicamento_x_bonoFarmacia(mxb_bonoFarmacia, mxb_medicamento, mxb_unidades, mxb_prescripcion) VALUES" + subQuery +
                    "UPDATE " + DB.schema + "bonoFarmacia SET bfa_afiliado=" + afiliado.id + "WHERE bfa_id=" + bono.id //y actualiza el boon para poner quein lo consumio
                    ) == -1)
                    MessageBox.Show("Error en la creacion de la receta");
                else {

                    ////////REPORTE//////////
                    reporte += "	<TABLE>";
                    reporte += "</BODY>";
                    reporte += "</HTML>";
                    ////////REPORTE//////////

                    DialogResult = DialogResult.OK;
                }
            } else
                MessageBox.Show("Faltan cargar datos");
        }

        private void GenerarReceta_Load(object sender, EventArgs e) {

        }
    }
}