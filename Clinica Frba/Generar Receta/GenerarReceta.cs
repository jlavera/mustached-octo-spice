using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.GenerarReceta
{
    public partial class GenerarReceta : Form
    {
        public String reporte;
        public BonoFarmacia bono;

        public GenerarReceta()
        {
            InitializeComponent();
        }
        
        public GenerarReceta(BonoFarmacia bono){
            tbBono.Text = Convert.ToString(bono.id);
            tbBono.Enabled = false;
        }

        private void GenerarReceta_Load(object sender, EventArgs e) {

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
            if (tbBono.Text != "" && lbMedicamentos.Items.Count >= 1) {

                bono = new BonoFarmacia(Convert.ToInt32(tbBono.Text));

                //Generar el reporte
                ////////REPORTE//////////
                reporte += "<HTML>";
                reporte += "<BODY>";
                reporte += "Clinicas Mustache<br/><hr>";
                reporte += "<br/>	Bono consulta: " + tbBono.Text;
                reporte += "<br/>	Afiliado: " + bono.afiliado.ToString();
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
                if (DB.ExecuteNonQuery("INSERT INTO " + DB.schema + "medicamento_x_bonoFarmacia(mxb_bonoFarmacia, mxb_medicamento, mxb_unidades, mxb_prescripcion) VALUES" + subQuery) == -1)
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
    }
}
