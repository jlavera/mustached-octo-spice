using System;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Drawing;

namespace Clinica_Frba.Clases {
    static class FuncionesBoludas {


        /// <summary>
        /// Devuelve la fecha del archivo en "Cosas/fecha.txt"
        /// </summary>
        /// <returns></returns>
        static public DateTime GetDateTime() {
            string path = "";

#if DEBUG
            path += "../../";
#endif
            
            StreamReader sr = new StreamReader(path + "Cosas/fecha.txt");
            DateTime aux = Convert.ToDateTime(sr.ReadLine());

            sr.Close();
            sr.Dispose();

            return aux;
        }


        /// <summary>
        /// Graba la fecha en el archivo "Cosas/fecha.txt"
        /// </summary>
        /// <param name="dt"></param>
        static public void SetDateTime(DateTime dt) {
            string path = "";

#if DEBUG
            path += "../../";
#endif

            StreamWriter sw = new StreamWriter(path + "Cosas/fecha.txt"); 
            sw.Write(dt);

            sw.Close();
            sw.Dispose();
        }

        /// <summary>
        /// Devuelve la cadena encriptada en Sha256
        /// </summary>
        /// <param name="text">Cadena a encriptar</param>
        /// <returns></returns>
        public static string getHashSha256(string text) {

            SHA256Managed hashstring = new SHA256Managed();

            byte[] bytes = Encoding.Unicode.GetBytes(text);
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;

            foreach (byte x in hash) {
                hashString += String.Format("{0:x2}", x);
            }

            return hashString;
        }

        public static bool policia(Control.ControlCollection ctrls){
        bool invalidez = false;
            foreach (Control ctrl in ctrls) {
                if ((ctrl.Visible && ctrl is TextBox && ((TextBox)ctrl).Text == "") ||
                    (ctrl is MaskedTextBox && ((MaskedTextBox)ctrl).Text == "") ||
                    (ctrl is ComboBox && ((ComboBox)ctrl).Text == "")) {
                    invalidez = true;
                    ctrl.BackColor = Color.RosyBrown;
                }
            }
            if (invalidez)
                MessageBox.Show("Falta completar campos");
            return !invalidez;
        }

        internal static int diaCereal(string _dia)
        {
            switch (_dia){
                case "Lunes":
                    return 2;
                case "Martes":
                    return 3;
                case "Miercoles":
                    return 4;
                case "Jueves":
                    return 5;
                case "Viernes":
                    return 6;
                case "Sabado":
                    return 7;
                case "Domingo":
                    return 1;

            }
            return -1;
        }

    }
}