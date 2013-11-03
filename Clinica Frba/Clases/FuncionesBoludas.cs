using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

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

    }
}