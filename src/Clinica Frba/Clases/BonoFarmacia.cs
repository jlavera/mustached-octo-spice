using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class BonoFarmacia {

        public int id;
        public Afiliado afiliado;
        public int turno;
        public DateTime fechaImpresion;
        public DateTime fechaVencimiento;
        public Compra compra;

        public BonoFarmacia (DataRow dr) {
            id = (int)dr["bfa_id"];
            turno = (dr["bfa_turno"] == DBNull.Value) ? -1 : (int)dr["bfa_turno"];
            afiliado = (dr["bfa_afiliado"] == DBNull.Value) ? null : new Afiliado((int)dr["bfa_afiliado"]);
            fechaImpresion = (DateTime)dr["[bfa_fechaImpresion]"];
            fechaVencimiento = (DateTime)dr["bfa_fechaVencimiento"];
            compra = new Compra((int)dr["bfa_compra"]);
        }

        public BonoFarmacia(int _id, DateTime _fechaImpresion, DateTime _fechaVencimiento) {
            id = _id;
            fechaImpresion = _fechaImpresion;
            fechaVencimiento = _fechaVencimiento;
        }

        public BonoFarmacia(int _id) {
            //El habilitado funciona a su vez de consumido o no consumido
            DataTable dt = DB.ExecuteReader("SELECT * FROM " + DB.schema + "bonoFarmacia "+
                                                     "JOIN " + DB.schema + "compra ON cmp_id=bfa_compra " +
                                                     "JOIN " + DB.schema + "vAfiliado ON afi_id=cmp_afiliado WHERE bfa_habilitado=1 AND bfa_id=" + _id);

            if (dt.Rows.Count == 0) //Como es PK y FK tiene que existir, y solo 1
                throw new NoTrajoNadaExcep();
            DataRow dr = dt.Rows[0];

            id = (int)dr["bfa_id"];
            turno = (dr["bfa_turno"] == DBNull.Value) ? -1 : (int)dr["bfa_turno"];
            afiliado = (dr["bfa_afiliado"] == DBNull.Value) ? null : new Afiliado((int)dr["bfa_afiliado"]);
            fechaImpresion = (DateTime)dr["bfa_fechaImpresion"];
            fechaVencimiento = (DateTime)dr["bfa_fechaVencimiento"];
            compra = new Compra(dr);
        }

        public override string ToString() {
            return id.ToString();
        }

        public override bool Equals(object bono) {
            return (bono != System.DBNull.Value && ((BonoFarmacia)bono).id == id);
        }
        
        public override int GetHashCode() {
            return base.GetHashCode();
        }

    }
}
