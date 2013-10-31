using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class EstadoCivil {

        public int id;
        public string nombre;

        public EstadoCivil(DataRow dr) {

            id = (dr["est_id"] == System.DBNull.Value) ? -1 : Convert.ToInt32(dr["est_id"]);
            nombre = (dr["est_estado"] == System.DBNull.Value) ? "" : dr["est_estado"].ToString();

        }

    }
}
