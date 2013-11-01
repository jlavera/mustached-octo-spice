using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.Registrar_Agenda
{
    public partial class EditAgenda : Form
    {
        public bool nueva = false;

        public EditAgenda(Agenda _agenda)
        {
            InitializeComponent();
            cbProfesional.Enabled = false;
            cbProfesional.Items.Add(_agenda.profesional);
            dtpDesde.Value = _agenda.desde;
            dtpHasta.Value = _agenda.hasta;
        }
        public EditAgenda()
        {
            InitializeComponent();
            nueva = true;
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
        }

        private void EditAgenda_Load(object sender, EventArgs e)
        {
            CheckBox agregador = new CheckBox();
            agregador.Size = new Size(36, 12);
            agregador.Text = "16:30";
            //flpSemanal.Controls.Add(agregador);
        }
    }
}
