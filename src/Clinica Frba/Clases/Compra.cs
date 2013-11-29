using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class Compra {

        public int id;
        public int monto;
        public Afiliado afiliado;
        public DateTime fechaCompra;

        public Compra(DataRow dr) {
            id = (int) dr["cmp_id"];
            monto = (int)dr["cmp_monto"];
            afiliado = new Afiliado((int)dr["cmp_afiliado"]);
            fechaCompra = Convert.ToDateTime(dr["cmp_fechaCompra"]);
        }

        public Compra(int _id) {
            DataTable dt = DB.ExecuteReader("SELECT * FROM " + DB.schema + "compra WHERE cmp_id=" + _id);

            if (dt.Rows.Count == 0) //Como es PK y FK tiene que existir, y solo 1
                throw new NoTrajoNadaExcep();
            DataRow dr = dt.Rows[0];

            id = (int)dr["cmp_id"];
            monto = (int)dr["cmp_monto"];
            afiliado = new Afiliado((int)dr["cmp_afiliado"]);
            fechaCompra = Convert.ToDateTime(dr["cmp_fechaCompra"]);
        }

    }
}
