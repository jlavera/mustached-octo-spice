using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Clinica_Frba.Clases;

namespace Clinica_Frba.Clases {
    class PlanesMedicos: ListaEntidad {
        //--------------HOMOGENEO A TODAS LAS ENTIDADES------
        #region homogeneo
        public PlanesMedicos()
            : base("planMedico") {
        }

        public void FillWithAll() {
            Fill(SelectAll());
        }

        private void Fill(DataTable dt) {
            foreach (DataRow dr in dt.Rows) {
                items.Add(new PlanMedico(dr));
            }
        }

        public PlanMedico this[int index] {
            get {
                return (PlanMedico)items[index];
            }

            set {
                items[index] = (object)value;
            }
        }

        #endregion
        //--------------FIN HOMOGENEO A TODAS LAS ENTIDADES------
    }
}
