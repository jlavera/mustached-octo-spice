using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Clinica_Frba.Clases;
using System.Windows.Forms;

namespace Clinica_Frba.Clases {
    public class Especialidades : ListaEntidad {
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
        public Especialidades(int p_id)
            : base("especialidad") {
            Fill(DB.ExecuteReader("SELECT e.esp_id, e.esp_descripcion, e.esp_tipo FROM " + DB.schema + "profesional_x_especialidad pxe JOIN " + DB.schema + "especialidad e ON e.esp_id = pxe_especialidad WHERE pxe.pxe_profesional = " + p_id));
        }

    }
}
