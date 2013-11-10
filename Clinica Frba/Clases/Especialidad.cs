using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class Especialidad {

        public int id;
        public string nombre;
        public TipoEspecialidad tipo;

        public Especialidad(int p_id) {
            DataRow dr = DB.ExecuteReader("SELECT * FROM " + DB.schema + "especialidad WHERE esp_id = " + id).Rows[0];

            id = Convert.ToInt32(dr["esp_id"]);
            nombre = dr["esp_nombre"].ToString();
            tipo = new TipoEspecialidad(Convert.ToInt32(dr["esp_tipo"]));
        }

        public Especialidad(DataRow dr) {
            if (dr["esp_id"] != DBNull.Value) {
                id = Convert.ToInt32(dr["esp_id"]);
                nombre = dr["esp_descripcion"].ToString();
                tipo = new TipoEspecialidad(Convert.ToInt32(dr["esp_tipo"]));
            } else {
                id = -1;
                nombre = "No tiene";
            }
        }

        public override string ToString() {
            return nombre;
        }

        public override bool Equals(object obj) {
            return obj != DBNull.Value && ((Especialidad)obj).id == id && ((Especialidad)obj).nombre == nombre && ((Especialidad)obj).tipo.Equals(tipo);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

    }
}