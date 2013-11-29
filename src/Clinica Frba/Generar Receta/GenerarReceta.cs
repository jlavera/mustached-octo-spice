using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.Generar_Receta {
    public partial class GenerarReceta : Form {
        public String reporte;
        public BonoFarmacia bono;

        private Profesional profesional;
        private Afiliado afiliado;
        private Turnos turnos = new Turnos();
        private Turno turno;

        public bool cerrar = false;

        public GenerarReceta(Usuario _usuario) {
            InitializeComponent();
            int tmp = DB.ExecuteCardinal("SELECT TOP 1 afi_id FROM " + DB.schema + "vProfesional WHERE usu_id=" + _usuario.id);
            if (tmp != -1) {
                profesional = new Profesional(tmp);
            } else {
                //Si fallo al traer afiliados, es que el usuario no es un afiliado
                MessageBox.Show("Este usuario no tiene un profecional asociado,\na modo de debug, le vamos a dejar elejir un afiliado");
                miniProfesional mini = new miniProfesional();
                if (mini.ShowDialog() != DialogResult.OK)
                    cerrar = true;
                profesional = mini.profesional;
            }
        }

        public GenerarReceta(BonoFarmacia bono) {
            tbBono.Text = Convert.ToString(bono.id);
            tbBono.Enabled = false;
        }

        private void GenerarReceta_Load(object sender, EventArgs e) {
            turnos.FillForProf2(profesional, true, true);
            lbTurnos.Items.AddRange(turnos.ToList());
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
            if (lbMedicamentos.SelectedIndex != -1)
                lbMedicamentos.Items.Remove(lbMedicamentos.SelectedItem);
            if (lbMedicamentos.Items.Count < 5) //"Anti" validacion
                bAgregar.Enabled = true;
        }

        private void bGrabar_Click(object sender, EventArgs e) {
            if (tbBono.Text != "" && lbMedicamentos.Items.Count >= 1 && lbTurnos.SelectedItems.Count == 1) {

                //--Guardar el afiliado del turno seleccionado
                turno = (Turno)lbTurnos.SelectedItem;
                afiliado = turno.afiliado;

                try {
                    bono = new BonoFarmacia(Convert.ToInt32(tbBono.Text));
                    //Si el comprador del bono, tiene el mismo grupo familiar que el que esta logeado
                    if (DB.ExecuteCardinal("SELECT COUNT(1) FROM " + DB.schema + "bonoFarmacia " +
                                                            "JOIN " + DB.schema + "compra ON cmp_id=bfa_compra " +
                                                            "JOIN " + DB.schema + "vAfiliado ON afi_id=cmp_afiliado" +
                                                " WHERE bfa_id=" + tbBono.Text +
                                                " AND bfa_fechaVencimiento > CAST('" + FuncionesBoludas.GetDateTime() +"' AS DATETIME)"+
                                                //" AND bfa_habilitado = 1" + FIXIT
                                                " AND afi_grupoFamiliar=(SELECT afi_grupoFamiliar FROM "+ DB.schema 
                                                                        + "vAfiliado WHERE afi_id=" + afiliado.id + ");") < 0) {
                        MessageBox.Show("Este bono no pertenece al grupo familiar de '" + afiliado.ToString() + "'");
                        return;
                    }
                }catch(NoTrajoNadaExcep){
                    MessageBox.Show("Ese bono no existe o está vencido, ingrese otro.");
                    return;
                }

                //Generar el reporte
                ////////REPORTE//////////
                reporte += "<HTML>";
                reporte += "<BODY>";
                reporte += "Clinicas Mustache<br/><hr>";
                reporte += "<br/>	Bono consulta: " + tbBono.Text;
                reporte += "<br/>	Afiliado que comrpo el bono: " + bono.afiliado.ToString();
                reporte += "<br/>	Receta a nombre de: " + afiliado.ToString();
                reporte += "<br/>	<TABLE>";
                reporte += "		<TR><TD>Medicamento</TD><TD>Cantidad</TD><TD>Expiracion</TD></TR>";
                ////////REPORTE//////////

                string subQuery = "";
                //Ciclar por los medicamentos cargados
                foreach (Medicamento m in lbMedicamentos.Items) {
                    subQuery += "(" + tbBono.Text + ", " + m.id + ", " + m.cantidad + ", \'" + m.prescripcion.ToString("yyy-MM-dd") + "\'), ";
                    reporte += "		<TR><TD>" + m.nombre + "</TD><TD>" + m.cantidad + "</TD><TD>" + m.prescripcion.ToString("yyy-MM-dd") + "</TD></TR>";
                }
                subQuery = subQuery.Substring(0, subQuery.Length - 2); //Sacar la ultima coma
                if (DB.ExecuteNonQuery("INSERT INTO " + DB.schema + "medicamento_x_bonoFarmacia(mxb_bonoFarmacia, mxb_medicamento, mxb_unidades, mxb_prescripcion) VALUES" + subQuery +
                    "; UPDATE " + DB.schema + "bonoFarmacia SET bfa_afiliado=" + afiliado.id + ", bfa_turno= "+turno.id+" WHERE bfa_id=" + bono.id //y actualiza el boon para poner quein lo consumio
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
    }
}
