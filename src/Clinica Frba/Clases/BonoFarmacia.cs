using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class BonoFarmacia {

        public int id;
        public Afiliado afiliado;
        public Afiliado comprador;
        public DateTime fechaImpresion;
        public DateTime fechaVencimiento;

        public BonoFarmacia (DataRow dr) {
            id = (int)dr["bfa_id"];
            afiliado = new Afiliado((int)dr["bfa_afiliado"]);
            fechaImpresion = (DateTime)dr["[bfa_fechaImpresion]"];
            fechaVencimiento = (DateTime)dr["bfa_fechaVencimiento"];
        }

        public BonoFarmacia(int _id, Afiliado _comprador, DateTime _fechaImpresion, DateTime _fechaVencimiento) {
            id = _id;
            comprador = _comprador;
            fechaImpresion = _fechaImpresion;
            fechaVencimiento = _fechaVencimiento;
        }

        public BonoFarmacia(int _id) {
            //El habilitado funciona a su vez de consumido o no consumido
            DataTable dt = DB.ExecuteReader("SELECT * FROM " + DB.schema + "bonoFarmacia JOIN " + DB.schema + "vAfiliado ON afi_id=bfa_comprador WHERE bfa_habilitado=1 AND bfa_id=" + _id);

            if (dt.Rows.Count == 0) //Como es PK y FK tiene que existir, y solo 1
                throw new NoTrajoNadaExcep();
            DataRow dr = dt.Rows[0];

            //FIXME tendira que llamar a el BonoFarmacia() de arriba
            id = (int)dr["bfa_id"];
            comprador = new Afiliado(dr);
            fechaImpresion = (DateTime)dr["bfa_fechaImpresion"];
            fechaVencimiento = (DateTime)dr["bfa_fechaVencimiento"];
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
