using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.Registrar_Agenda {
    public partial class EditAgenda : Form {
        public bool nueva = false;
        private Agenda vieja;

        Profesionales pros = new Profesionales();

        public EditAgenda(Agenda _agenda) {
            InitializeComponent();
            vieja = _agenda;
        }
        public EditAgenda() {
            InitializeComponent();
            nueva = true;
        }

        private void EditAgenda_Load(object sender, EventArgs e) {
            //--Si la agenda es nueva
            if (nueva) {
                //--Llenar los profesionales en el listBox
                pros.FillWithAll();
                cbProfesional.Items.AddRange(pros.ToList());
                dtpDesde.Value = DateTime.Today;
                dtpHasta.Value = DateTime.Today.AddDays(120);
            } else {
                cbProfesional.Enabled = false;
                cbProfesional.Items.Add(vieja.profesional);
                cbProfesional.SelectedIndex = 0;
                dtpDesde.Value = vieja.desde;
                dtpHasta.Value = vieja.hasta;


                foreach (Control lb in this.Controls)
                {
                    if (lb is ListBox)
                    {
                        lb.Enabled = false;
                        /////////////////Cargar los semanales
                        DataTable dt = DB.ExecuteReader("SELECT * FROM " + DB.schema + "semanal WHERE sem_habilitado=1 AND sem_agenda=" + vieja.id);

                        foreach (DataRow dr in dt.Rows) {
                            ListBox tmp = ((ListBox)this.Controls["lbDia" + (dr["sem_dia"]).ToString()]);
                            //Busca para seleccionarlo
                            for(int i=0; i<tmp.Items.Count; i++)
                            {
                                if (tmp.Items[i].ToString() == dr["sem_hora"].ToString().Substring(0, 5))
                                {
                                    tmp.SetSelected(i, true);
                                    break; //Cuando lo encuentra pasa al proximo registro
                                }
                            }
                        }
                    }
                }
            }
        }

        private void bGuardar_Click(object sender, EventArgs e) {
            if (cbProfesional.SelectedIndex == -1)
                MessageBox.Show("No se selecciono un profesional");
            else if (dtpHasta.Value.Ticks < dtpDesde.Value.Ticks)
                MessageBox.Show("Las fechas estan alrevez");
            else if ((dtpHasta.Value - dtpDesde.Value).Ticks > (DateTime.Now.AddDays(120) - DateTime.Now).Ticks)
                MessageBox.Show("La diferencia supera los 120 dias");
            else
            {

                string query = "";
                if (nueva)
                {
                    query += "INSERT INTO " + DB.schema + "agenda(age_desde, age_hasta, age_profesional) VALUES('" + dtpDesde.Value.ToString("yyyy-MM-dd") + "', '" + dtpHasta.Value.ToString("yyyy-MM-dd") + "', " + ((Profesional)cbProfesional.SelectedItem).id + "); ";

                    string subQuery = "";
                    bool alguno = false;
                    foreach (Control lb in this.Controls)
                    {
                        if (lb is ListBox)
                        {
                            foreach (Object hora in ((ListBox)lb).SelectedItems)
                            {
                                alguno = true;
                                subQuery += "(IDENT_CURRENT('" + DB.schema + "agenda') , " + lb.Name.ToString().Substring(5) + ", '" + hora.ToString() + "' ),";
                            }
                        }
                    }
                    //Sacar la ultima coma
                    if (alguno)
                    {
                        subQuery = subQuery.Substring(0, subQuery.Length - 1);
                        query += "INSERT INTO " + DB.schema + "semanal(sem_agenda, sem_dia, sem_hora) VALUES " + subQuery;
                    }
                    if (DB.ExecuteNonQuery(query) == -1)
                        MessageBox.Show("Error en la creacion de agenda");
                }
                else
                {
                    query = "UPDATE " + DB.schema + "agenda SET age_desde='" + dtpDesde.Value.ToString("yyyy-MM-dd") + "', age_hasta='" + dtpHasta.Value.ToString("yyyy-MM-dd") + "' WHERE age_id=" + vieja.id;
                    if (DB.ExecuteNonQuery(query) == -1)
                        MessageBox.Show("Error en la modificacion de agenda");
                }

                //DB.ExecuteNonQuery(query);
                this.Close();
                DialogResult = DialogResult.OK;
            }
        }
    }
}