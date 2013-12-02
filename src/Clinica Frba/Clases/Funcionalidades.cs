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

        public Funcionalidades(int p_id)
            : base("funcionalidad") {
            Fill(DB.ExecuteReader("SELECT fun_id, fun_nombre FROM " + DB.schema + "rol_x_funcionalidad rxf JOIN " + DB.schema + "funcionalidad f ON f.fun_id = rxf.rxf_funcionalidad WHERE rxf.rxf_rol = " + p_id));
        }

        /// <summary>
        /// Llena la lista con t0dos los roles que tienen una funcionalidad
        /// </summary>
        /// <param name="p_rolId"></param>
        public void FillByRol(int p_rolId) {
            Fill(DB.ExecuteReader("SELECT fun_id, fun_nombre FROM " + DB.schema + "rol_x_funcionalidad JOIN " + DB.schema + "funcionalidad ON fun_id = rxf_funcionalidad WHERE rxf_rol = " + p_rolId));
        }

    }
}
