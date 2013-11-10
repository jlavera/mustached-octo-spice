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
        public int proximoOrden;

        public GrupoFamiliar(DataRow dr) {

            grupo = (dr["afi_grupoFamiliar"] == System.DBNull.Value)? -1: Convert.ToInt32(dr["afi_grupoFamiliar"]);
            titularId = (dr["afi_id"] == System.DBNull.Value) ? -1 : Convert.ToInt32(dr["afi_id"]);
            titular = dr["usu_apellido"].ToString() + ", " + dr["usu_nombre"].ToString();
            proximoOrden = (dr.Table.Columns.Contains("grp_proximoOrden")) ?  Convert.ToInt32(dr["grp_proximoOrden"]) : -1;

        }

        public override string ToString() {
            return titular.ToString();
        }

    }
}
