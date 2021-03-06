﻿using System;
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
        Semanales semanales = new Semanales();

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

                semanales.FillForAgenda(vieja);
                lbSemanal.Items.AddRange(semanales.ToList());
                bAgregar.Enabled = false;
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


                    //Sacar la ultima coma
                    if (lbSemanal.Items.Count>0)
                    {
                        query += "INSERT INTO " + DB.schema + "semanal(sem_agenda, sem_dia, sem_desde, sem_hasta) VALUES ";
                        foreach (Semanal s in lbSemanal.Items)
                            query += "(IDENT_CURRENT('" + DB.schema + "agenda') , " + s.dia + ", '" + s.desde.ToString("HH:mm") + "', '" + s.hasta.ToString("HH:mm") + "' ),";
                        query = query.Substring(0, query.Length - 1);
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

        private void bAgregar_Click_1(object sender, EventArgs e) {
            EditSemanal form = new EditSemanal();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
                lbSemanal.Items.Add(form.semanal);
        }
    }
}