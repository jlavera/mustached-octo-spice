using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Clinica_Frba.Clases;
using System.Windows.Forms;

namespace Clinica_Frba.Clases {
    class Especialidades : ListaEntidad {
        //--------------HOMOGENEO A TODAS LAS ENTIDADES------
        #region homogeneo
        public Especialidades()
            : base("especialidad") {
        }

        public void FillWithAll() {
            Fill(SelectAll());
        }

        private void Fill(DataTable dt) {
            foreach (DataRow dr in dt.Rows) {
                items.Add(new Especialidad(dr));
            }
        }

        public Especialidad this[int index] {
            get {
                return (Especialidad)items[index];
            }

            set {
                items[index] = (object)value;
            }
        }

        #endregion
        //--------------FIN HOMOGENEO A TODAS LAS ENTIDADES------



    }
}
