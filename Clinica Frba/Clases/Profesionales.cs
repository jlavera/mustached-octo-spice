using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Clinica_Frba.Clases;

namespace Clinica_Frba.Clases {
    class Profesionales:ListaEntidad {
        //--------------HOMOGENEO A TODAS LAS ENTIDADES------
        #region homogeneo
        public Profesionales()
            : base("profesional") {
        }

        public void FillWithAll() {
            Fill(SelectAll());
        }

        private void Fill(DataTable dt) {
            foreach (DataRow dr in dt.Rows) {
                items.Add(new Profesional(dr));
            }
        }

        public Profesional this[int index] {
            get {
                return (Profesional)items[index];
            }

            set {
                items[index] = (object)value;
            }
        }

        #endregion
        //--------------FIN HOMOGENEO A TODAS LAS ENTIDADES------


        /// <summary>
        /// Devuelve los profesionales junto con sus entidades FK desde la vista
        /// </summary>
        /// <returns></returns>
        public override DataTable SelectAll() {
            return DB.ExecuteReader("SELECT * FROM " + DB.schema + "vProfesional");
        }

    }
}
