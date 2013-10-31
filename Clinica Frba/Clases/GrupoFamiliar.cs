using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class GrupoFamiliar {

        public int grupo;
        public int titularId;
        public string titular;

        public GrupoFamiliar(DataRow dr) {

            grupo = (dr["afi_grupoFamiliar"] == System.DBNull.Value)? -1: Convert.ToInt32(dr["afi_grupoFamiliar"]);
            titularId = (dr["afi_id"] == System.DBNull.Value) ? -1 : Convert.ToInt32(dr["afi_id"]);
            titular = (dr["afi_titular"] == System.DBNull.Value) ? "" : dr["afi_titular"].ToString();

        }

        public override string ToString() {
            return titular.ToString();
        }

    }
}
