using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Clinica_Frba.Clases {
    public class BonosFarmacia : ListaEntidad {


        //--------------HOMOGENEO A TODAS LAS ENTIDADES------
        #region homogeneo
        public BonosFarmacia()
            : base("bonoFarmacia") {
        }

        public void FillWithAll() {
            Fill(SelectAll());
        }

        private void Fill(DataTable dt) {
            foreach (DataRow dr in dt.Rows) {
                items.Add(new BonoFarmacia(dr));
            }
        }

        public BonoFarmacia this[int index] {
            get {
                return (BonoFarmacia)items[index];
            }

            set {
                items[index] = (object)value;
            }
        }

        #endregion
        //--------------FIN HOMOGENEO A TODAS LAS ENTIDADES------
    }
}
