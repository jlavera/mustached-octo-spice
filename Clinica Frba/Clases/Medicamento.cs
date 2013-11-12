using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class Medicamento {

        public int id;
        public string nombre;
        public int cantidad;
        public DateTime prescripcion;

        //Generador para cargar medicamentos
        public Medicamento(int _id, string _nombre, int _cantidad, DateTime _prescripcion) {
            id = _id;
            nombre = _nombre;
            cantidad = _cantidad;
            prescripcion = _prescripcion;
        }

        public Medicamento(DataRow dr) {
            id = (int)dr["med_id"];
            nombre = dr["med_nombre"].ToString();
            if (dr.Table.Columns.Contains("mxb_unidades"))
                cantidad = (int)dr["mxb_unidades"];
            else
                cantidad = 0;
            if (dr.Table.Columns.Contains("mxb_prescripcion"))
                prescripcion = (DateTime)dr["mxb_prescripcion"];            
        }

        public override string ToString() {
            return nombre;
        }

        public override bool Equals(object obj) {
            return (obj != DBNull.Value && ((Medicamento)obj).nombre == nombre);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }
}
