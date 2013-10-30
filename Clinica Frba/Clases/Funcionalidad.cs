using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class Funcionalidad: Entidad {

        public int id;
        public string nombre;

        public Funcionalidad(DataRow dr) {
            id = Convert.ToInt32(dr["id"]);
            nombre = dr["nombre"].ToString();

        }

        public override string ToString() {
            return nombre;
        }

        public override bool Equals(object func) {
            return ((func != System.DBNull.Value) &&((Funcionalidad)func).id == id) && (((Funcionalidad)func).nombre == nombre);
        }
    }
}
