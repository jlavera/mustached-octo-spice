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
            id = Convert.ToInt32(dr["pla_id"]);
            nombre = dr["pla_nombre"].ToString();
            codigo = Convert.ToInt64(dr["pla_codigo"]);
            precioBonoConsulta = Convert.ToInt32(dr["pla_precioBonoConsulta"]);
            precioBonoFarmacia = Convert.ToInt32(dr["pla_precioBonoFarmacia"]);
        }

    }
}
