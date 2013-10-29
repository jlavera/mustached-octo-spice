using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class Rol {

        public int id { get; set; }
        public string nombre { get; set; }
        public bool habilitado { get; set; }

        public Rol(DataRow dr) {
            id = (int)dr["id"];
            nombre = (string)dr["nombre"];
            habilitado = Convert.ToBoolean(dr["habilitado"]);
        }

        public override string ToString() {
            return nombre;
        }

    }
}
