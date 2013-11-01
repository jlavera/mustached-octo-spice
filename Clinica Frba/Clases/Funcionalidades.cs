using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace Clinica_Frba.Clases {
    public class Funcionalidades: ListaEntidad {

        //--------------HOMOGENEO A TODAS LAS ENTIDADES------
        #region homogeneo
        public Funcionalidades()
            : base("funcionalidad") {
        }

        public void FillWithAll() {
            Fill(SelectAll());
        }

        private void Fill(DataTable dt) {
            foreach (DataRow dr in dt.Rows) {
                items.Add(new Funcionalidad(dr));
            }
        }

        public Funcionalidad this[int index] {
            get {
                return (Funcionalidad)items[index];
            }

            set {
                items[index] = (object)value;
            }
        }

        #endregion
        //--------------FIN HOMOGENEO A TODAS LAS ENTIDADES------


        /// <summary>
        /// Llena la lista con todos los roles que tienen una funcionalidad
        /// </summary>
        /// <param name="p_rolId"></param>
        public void FillByRol(int p_rolId) {
            Fill(DB.ExecuteReader("SELECT fun_id, fun_nombre FROM moustache_spice.rol_x_funcionalidad JOIN moustache_spice.funcionalidad ON fun_id = rxf_funcionalidad WHERE rxf_rol = " + p_rolId));
        }

    }
}
