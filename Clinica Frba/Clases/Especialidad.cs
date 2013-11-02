using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class Especialidad {

        public int id;
        public string nombre;
        public int tipo;

        public Especialidad(DataRow dr) {
            id = Convert.ToInt32(dr["esp_id"]);
            nombre = dr["esp_descripcion"].ToString();
            tipo = Convert.ToInt32(dr["esp_tipo"]);
        }

        public override string ToString() {
            return nombre;
        }

        public override bool Equals(object obj) {
            return obj != DBNull.Value && ((Especialidad)obj).id == id && ((Especialidad)obj).nombre == nombre && ((Especialidad)obj).tipo == tipo;
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

    }
}
