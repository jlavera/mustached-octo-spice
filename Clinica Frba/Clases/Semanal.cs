using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class Semanal {

        public int dia;
        public DateTime hora;

        public Semanal(DataRow dr) {
            dia = Convert.ToInt32(dr["sem_dia"]);
            hora = DateTime.Parse(dr["sem_hora"].ToString());
        }

        public override string ToString() {
            return hora.Hour + ":" + hora.Minute;
        }
    }
}
