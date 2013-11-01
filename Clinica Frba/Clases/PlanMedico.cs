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

        public override string ToString() {
            return nombre;
        }

        public override bool Equals(object obj) {
            return ( obj != DBNull.Value && ((PlanMedico)obj).id == id && ((PlanMedico)obj).nombre == nombre && ((PlanMedico)obj).codigo == codigo && ((PlanMedico)obj).precioBonoConsulta == precioBonoConsulta && ((PlanMedico)obj).precioBonoFarmacia == precioBonoFarmacia);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }
}
