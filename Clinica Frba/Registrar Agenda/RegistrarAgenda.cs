using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.RegistrarAgendas
{
    public partial class RegistrarAgendas : Form
    {
        Agendas agendas = new Agendas();

        public RegistrarAgendas()
        {
            InitializeComponent();
        }

        private void RegistrarAgendas_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;

            //La primera carga se hace a mano
            agendas.FillWithAll();
            foreach (Agenda agenda in agendas.items)
                dgvAgenda.Rows.Add(agenda.id, agenda.profesional, agenda.desde, agenda.hasta);
        }

        private void FillDgv()
        {
            dgvAgenda.Rows.Clear();
            //1 --> (cbProfesional.SelectedItem)
            agendas.FillWithFilter(1, dtpDesde.Value, dtpHasta.Value);

            foreach (Agenda agenda in agendas.items)
                dgvAgenda.Rows.Add(agenda.profesional, agenda.desde, agenda.hasta);

        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            agendas.DeleteSelected(dgvRoles, dgvRoles.SelectedRows);
            FillDgv();
        }
    }
}
