using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class Agenda {

        public int id;
        public int proid;
        public string profesional;
        public DateTime desde;
        public DateTime hasta;

        public Agenda(DataRow dr) {
            id = (int)dr["age_id"];
            profesional = (string)dr["profesional"]; //Es la concatencaion que la trae la vista directamente
            proid = (int)dr["age_profesional"];
            desde = (DateTime)dr["age_desde"];
            hasta = (DateTime)dr["age_hasta"];
        }

        public Agenda(int _id, int _proid, string _profesional, DateTime _desde, DateTime _hasta) {
            id = _id;
            proid = _proid;
            profesional = _profesional;
            desde = _desde;
            hasta = _hasta;
        }

        public override string ToString() {
            return id.ToString();
        }

        public override bool Equals(object agenda) {
            return (agenda != System.DBNull.Value && ((Agenda)agenda).id == id && ((Agenda)agenda).profesional == profesional && ((Agenda)agenda).desde == desde && ((Agenda)agenda).hasta == hasta && ((Agenda)agenda).proid == proid);
        }
        
        public override int GetHashCode() {
            return base.GetHashCode();
        }

    }
}
