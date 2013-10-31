using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.AbmAfiliados {
    public partial class AbmAfiliados : Form {
        Afiliados afiliados = new Afiliados();
        EstadosCiviles estadosCiviles = new EstadosCiviles();
        GruposFamiliares grupos = new GruposFamiliares();
        PlanesMedicos planes = new PlanesMedicos();

        public AbmAfiliados() {
            InitializeComponent();
        }

        private void AbmAfiliados_Load(object sender, EventArgs e) {            

            FillDgv();

            estadosCiviles.FillWithAll();
            lbEstadoCivil.Items.AddRange(estadosCiviles.ToList());

            grupos.FillWithAll();
            lbGrupoFamiliar.Items.AddRange(grupos.ToList());

            planes.FillWithAll();
            cmbPlanMedico.Items.AddRange(planes.ToList());

        }

        private void cmbTipoDNI_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void FillDgv() {

            afiliados.FillWithAll();

            foreach (Afiliado afiliado in afiliados.items) {
                dgvAfiliados.Rows.Add(afiliado.grupoFamiliar.ToString("D5") + "-" + afiliado.orden.ToString("D2"),
                    afiliado.usuario.nombre, afiliado.usuario.apellido,
                    (afiliado.usuario.tipoDocumento == "") ? "Faltar cargar" : afiliado.usuario.tipoDocumento, afiliado.usuario.numeroDocumento,
                    afiliado.usuario.direccion, afiliado.usuario.telefono, afiliado.usuario.mail, afiliado.usuario.fechaNacimiento,
                    (afiliado.usuario.sexo == "") ? "Faltar cargar" : afiliado.usuario.sexo, afiliado.usuario.nombreUsuario,
                    (afiliado.estadoCivil.nombre == "")? "Falta cargar": afiliado.estadoCivil.ToString(),
                    (afiliado.familiaresACargo == -1)? "Falta cargar": afiliado.familiaresACargo.ToString(), afiliado.planMedico.nombre);
            }

        }

        private void bBuscar_Click(object sender, EventArgs e) {
            dgvAfiliados.Rows.Clear();

        }
    }
}