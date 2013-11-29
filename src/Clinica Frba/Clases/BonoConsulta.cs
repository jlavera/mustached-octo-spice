using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class BonoConsulta {

        public int id;
        public Afiliado afiliado;
        public DateTime fecha;
        public DateTime fechaCompra;
        public Compra compra;

        public BonoConsulta(DataRow dr) {
            id = (int)dr["bco_id"];
            afiliado = new Afiliado(dr);
            fecha = (DateTime)dr["bco_fecha"];
            fechaCompra = (DateTime)dr["bco_fechaCompa"];
            compra = new Compra((int)dr["bfa_compra"]);
        }

        public BonoConsulta(int _id) {
            //El habilitado funciona a su vez de consumido o no consumido
            DataTable dt = DB.ExecuteReader("SELECT * FROM " + DB.schema + "bonoConsulta "+
                                                        "JOIN " + DB.schema + "compra ON cmp_id=bco_compra " +
                                                        "JOIN " + DB.schema + "vAfiliado ON afi_id=cmp_afiliado WHERE bco_habilitado=1 AND bco_id=" + _id);

            if (dt.Rows.Count == 0) //Como es PK y FK tiene que existir, y solo 1
                throw new NoTrajoNadaExcep();
            DataRow dr = dt.Rows[0];

            id = (int)dr["bco_id"];
            if(dr["bco_afiliado"] != DBNull.Value)
                afiliado = new Afiliado((int)dr["bco_afiliado"]);
            if (dr["bco_fecha"] != DBNull.Value) 
                fecha = (DateTime)dr["bco_fecha"];
            fechaCompra = (DateTime)dr["bco_fechaCompa"];
            if (dr["bco_compra"] != DBNull.Value)
                compra = new Compra((int)dr["bfa_compra"]);
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
