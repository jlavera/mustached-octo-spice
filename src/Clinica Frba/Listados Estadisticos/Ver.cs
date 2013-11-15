using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.Listados_Estadisticos {
    public partial class Ver : Form {

        private int semestre;
        private string tipo;
        private DataTable res;
        private int maximo = int.MaxValue;

        public Ver(int _sem, string _tipo) {
            InitializeComponent();
            semestre = _sem;
            tipo = _tipo;
        }

        private void Ver_Load(object sender, EventArgs e) {

            //--Ejecutar query según el listado que pidió
            switch (tipo) {
                case "b1":
                    res = DB.ExecuteReader("SELECT 1, 2, 4, 9 ,40"); // <--- POTATO
                    foreach (DataRow dr in res.Rows) {
                        if (Convert.ToInt32(dr[1]) > maximo)
                            maximo = Convert.ToInt32(dr[1]);
                    }
                    break;

                case "b2":
                    res = DB.ExecuteReader("SELECT 1000, 2000, 4000,9000 ,40000");
                    break;

                case "b3":
                    res = DB.ExecuteReader("SELECT 1, 2, 4,9 ,40");
                    break;

                case "b4":
                    res = DB.ExecuteReader("SELECT 1, 2, 4,9 ,40");
                    break;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

            Graphics formGraphics = panel1.CreateGraphics();
            Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Brown, Color.Orange, 
                                Color.Beige, Color.Black, Color.DarkViolet, Color.Yellow, Color.Tomato };
            SolidBrush brush;

            int padding = 10;
            int altoMax = 400;
            int anchoMax = 480;


            int coef = altoMax / maximo;
            int alto;
            int ancho;

            for (int i = 0; i < res.Rows.Count; i++) {
                brush = new SolidBrush(colors[i]);

                alto = 50;
                ancho = 50;


                formGraphics.FillRectangle(brush, new Rectangle(i * (ancho + padding), panel1.Height - padding - Convert.ToInt32(res.Rows[i][0]) * coef, ancho, alto));
                //formGraphics.DrawString("Op-" + (i+1).ToString(), Font, brush,
            }
            formGraphics.Dispose(); 
        }




    }
}
