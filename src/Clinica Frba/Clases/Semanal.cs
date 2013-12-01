using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class Semanal {

        public int dia;
        public DateTime desde;
        public DateTime hasta;

        public Semanal(int _dia, DateTime _desde, DateTime _hasta) {
            dia = _dia;
            desde = _desde;
            hasta = _hasta;
        }

        public Semanal(DataRow dr) {
            dia = Convert.ToInt32(dr["sem_dia"]);
            desde = DateTime.Parse(dr["sem_desde"].ToString());
            hasta = DateTime.Parse(dr["sem_hasta"].ToString());
        }


        public override string ToString() {
            return FuncionesBoludas.intToDate(dia) + ": \t" + (desde.Hour).ToString("00") + ":" + (desde.Minute).ToString("00") +
                    " - " +
                    (hasta.Hour).ToString("00") + ":" + (hasta.Minute).ToString("00");
        }
    }
}
