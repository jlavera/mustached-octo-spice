﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.Comprar_Bono
{
    public partial class ComprarBono : Form
    {
        public Afiliado afiliado;
        public bool cerrar = false;

        public ComprarBono(Usuario _usuario, Rol _rol) {
            InitializeComponent();
            int tmp = DB.ExecuteCardinal("SELECT TOP 1 afi_id FROM " + DB.schema + "vAfiliado WHERE usu_id=" + _usuario.id);
            if (tmp != -1) {
                afiliado = new Afiliado(tmp);
            } else {
                //Si fallo al traer afiliados, es que el usuario no es un afiliado
                MessageBox.Show("Este usuario no tiene un afiliado.\nElija un afiliado que efectuara la compra");
                miniAfiliado mini = new miniAfiliado();
                if (mini.ShowDialog() != DialogResult.OK)
                    cerrar = true;
                afiliado = mini.afiliado;
            }
        }

        private void ComprarBono_Load(object sender, EventArgs e) {
        }

        private void actualizarPrecio(object sender, EventArgs e) {
            tbPrecio.Text = ((int)nFarmacia.Value * afiliado.planMedico.precioBonoFarmacia +
                            (int)nConsulta.Value * afiliado.planMedico.precioBonoConsulta).ToString();
        }

        private void bComprar_Click(object sender, EventArgs e) {
            string query = "";
            int idCompra=0;
            int idFarmacia = -1; //@@IDENTITY da el ultimo ID insertado, para saber cuales fueron, restas nFarmacia
            int idConsulta = -1;

            if ((nFarmacia.Value + nConsulta.Value) >= 1)
                idCompra = DB.ExecuteCardinal("INSERT INTO " + DB.schema + "compra(cmp_monto, cmp_afiliado, cmp_fechaCompra) VALUES (" + tbPrecio.Text + ", " + afiliado.id + ", '" + FuncionesBoludas.GetDateTime().ToString() + "')" + "; SELECT @@IDENTITY");


            if (nFarmacia.Value >= 1) {
                query += "INSERT INTO " + DB.schema + "bonoFarmacia(bfa_fechaImpresion, bfa_fechaVencimiento, bfa_compra) VALUES ";
                //Cargar los N bonso Famracia
                for (int i = 0; i < nFarmacia.Value; i++)
                    query += "('" + FuncionesBoludas.GetDateTime() + "', '" +
                                  FuncionesBoludas.GetDateTime().AddDays(60) + "', " +
                                  idCompra + "), ";
                query = query.Substring(0, query.Length - 2); //Sacar la ultima coma
                idFarmacia = DB.ExecuteCardinal(query + "; SELECT @@IDENTITY");
            }


            //Lo mismo, con Consulta
            if (nConsulta.Value >= 1) {
                query = "INSERT INTO " + DB.schema + "bonoConsulta(bco_compra) VALUES ";
                //Cargar los N bonso Famracia
                for (int i = 0; i < nConsulta.Value; i++)
                    query += "(" + idCompra + "), ";
                query = query.Substring(0, query.Length - 2); //Sacar la ultima coma
                idConsulta = DB.ExecuteCardinal(query + "; SELECT @@IDENTITY");
            }
            //Arma el mensaje
            string mensaje = "";

            if (idFarmacia != -1) {
                mensaje += "Se compraron los bonos Farmacia: \n\t";
                for (int i = 0; i < nFarmacia.Value; i++)
                    mensaje += (idFarmacia - i).ToString() + ", ";
            }

            if (idCompra != -1) {
                mensaje += "\nSe compraron los bonos Consulta: \n\t";
                for (int i = 0; i < nConsulta.Value; i++)
                    mensaje += (idConsulta - i).ToString() + ", ";
            }

            MessageBox.Show("ID de compra: " + idCompra +  "\n" + mensaje);

            DialogResult = DialogResult.OK;
        }
    }
}
