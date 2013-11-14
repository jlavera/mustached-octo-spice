using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class BonoConsulta {

        public int id;
        public Afiliado afiliado;
        public Afiliado comprador;
        public DateTime fecha;
        public DateTime fechaCompa;

        public BonoConsulta(DataRow dr) {
            id = (int)dr["bco_id"];
            afiliado = new Afiliado(dr);
            comprador = new Afiliado((int)dr["bco_comprador"]);
            fecha = (DateTime)dr["bco_fecha"];
            fechaCompa = (DateTime)dr["bco_fechaCompa"];
        }

        public BonoConsulta(int _id) {
            //El habilitado funciona a su vez de consumido o no consumido
            DataTable dt = DB.ExecuteReader("SELECT * FROM " + DB.schema + "bonoConsulta JOIN " + DB.schema + "vAfiliado ON afi_id=bco_afiliado WHERE bco_habilitado=1 AND bco_id=" + _id);

            if (dt.Rows.Count == 0) //Como es PK y FK tiene que existir, y solo 1
                throw new NoTrajoNadaExcep();
            DataRow dr = dt.Rows[0];

            //FIXME tendira que llamar a el BonoFarmacia() de arriba
            id = (int)dr["bco_id"];
            comprador = new Afiliado(dr);
            if(dr["bco_afiliado"] != DBNull.Value)
                afiliado = new Afiliado((int)dr["bco_afiliado"]);
            fecha = (DateTime)dr["bco_fecha"];
            fechaCompa = (DateTime)dr["bco_fechaCompa"];
        }

        public override string ToString() {
            return id.ToString();
        }

        public override bool Equals(object bono) {
            return (bono != System.DBNull.Value && ((BonoConsulta)bono).id == id);
        }
        
        public override int GetHashCode() {
            return base.GetHashCode();
        }

    }
}
