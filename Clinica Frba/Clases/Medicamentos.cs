using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Clinica_Frba.Clases;

namespace Clinica_Frba.Clases {
    class Medicamentos: ListaEntidad {
        //--------------HOMOGENEO A TODAS LAS ENTIDADES------
        #region homogeneo
        public Medicamentos()
            : base("medicamento") {
        }

        public void FillWithAll() {
            Fill(SelectAll());
        }

        private void Fill(DataTable dt) {
            foreach (DataRow dr in dt.Rows) {
                items.Add(new Medicamento(dr));
            }
        }

        public Medicamento this[int index] {
            get {
                return (Medicamento)items[index];
            }

            set {
                items[index] = (object)value;
            }
        }

        #endregion
        //--------------FIN HOMOGENEO A TODAS LAS ENTIDADES------

        internal void FillWithFilter(string p) {
            Fill(DB.ExecuteReader("SELECT * FROM " + DB.schema + "medicamento WHERE med_nombre LIKE '%" + p + "%';"));
        }
    }
}
