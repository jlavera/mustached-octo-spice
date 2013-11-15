using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class TipoEspecialidad {

        public int id;
        public string nombre;

        public TipoEspecialidad(DataRow dr) {
            id = Convert.ToInt32(dr["tip_id"]);
            nombre = dr["tip_nombre"].ToString();
        }

        public TipoEspecialidad(int p_id) {
            DataRow dr = DB.ExecuteReader("SELECT * FROM " + DB.schema + "tipoEspecialidad").Rows[0];

            id = Convert.ToInt32(dr["tip_id"]);
            nombre = dr["tip_nombre"].ToString();
        }

        public override string ToString() {
            return nombre;
        }

        public override bool Equals(object obj) {
            return (obj != DBNull.Value && ((TipoEspecialidad)obj).id == id && ((TipoEspecialidad)obj).nombre == nombre);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }
}
