using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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
    }
}