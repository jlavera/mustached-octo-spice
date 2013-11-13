using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Clinica_Frba.Clases {
    public class BonosConsulta : ListaEntidad {


        //--------------HOMOGENEO A TODAS LAS ENTIDADES------
        #region homogeneo
        public BonosConsulta()
            : base("bonoConsulta") {
        }

        public void FillWithAll() {
            Fill(SelectAll());
        }

        private void Fill(DataTable dt) {
            foreach (DataRow dr in dt.Rows) {
                items.Add(new BonoConsulta(dr));
            }
        }

        public BonoConsulta this[int index] {
            get {
                return (BonoConsulta)items[index];
            }

            set {
                items[index] = (object)value;
            }
        }

        #endregion
        //--------------FIN HOMOGENEO A TODAS LAS ENTIDADES------
    }
}
