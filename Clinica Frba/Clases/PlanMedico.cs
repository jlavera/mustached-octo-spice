using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class PlanMedico {

        public int id;
        public string nombre;
        public long codigo;
        public int precioBonoConsulta;
        public int precioBonoFarmacia;

        public PlanMedico(DataRow dr) {
            id = Convert.ToInt32(dr["id"]);
            nombre = dr["nombre"].ToString();
            codigo = Convert.ToInt64(dr["codigo"]);
            precioBonoConsulta = Convert.ToInt32(dr["precioBonoConsulta"]);
            precioBonoFarmacia = Convert.ToInt32(dr["precioBonoFarmacia"]);
        }

        public PlanMedico(int p_id) {

            //--Integritud referencística! 1.0.1s
            DataRow dr = DB.ExecuteReader("SELECT TOP 1 * FROM " + DB.schema + "planMedico pm WHERE pm.id = " + p_id).Rows[0];

            id = Convert.ToInt32(dr["id"]);
            nombre = dr["nombre"].ToString();
            codigo = Convert.ToInt64(dr["codigo"]);
            precioBonoConsulta = Convert.ToInt32(dr["precioBonoConsulta"]);
            precioBonoFarmacia = Convert.ToInt32(dr["precioBonoFarmacia"]);

        }

    }
}
