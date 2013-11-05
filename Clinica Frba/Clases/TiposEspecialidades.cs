using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Clinica_Frba.Clases;

namespace Clinica_Frba.Clases {
    class TiposEspecialidades : ListaEntidad {

        //--------------HOMOGENEO A TODAS LAS ENTIDADES------
        #region homogeneo
        public TiposEspecialidades()
            : base("tipoEspecialidad") {
        }

        public void FillWithAll() {
            Fill(SelectAll());
        }

        private void Fill(DataTable dt) {
            foreach (DataRow dr in dt.Rows) {
                items.Add(new TipoEspecialidad(dr));
            }
        }

        public TipoEspecialidad this[int index] {
            get {
                return (TipoEspecialidad)items[index];
            }

            set {
                items[index] = (object)value;
            }
        }

        #endregion
        //--------------FIN HOMOGENEO A TODAS LAS ENTIDADES------

    }
}
