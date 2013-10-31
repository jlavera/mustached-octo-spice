using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Clinica_Frba.Clases;
using System.Windows.Forms;

namespace Clinica_Frba.Clases {
    class Afiliados : ListaEntidad {
        //--------------HOMOGENEO A TODAS LAS ENTIDADES------
        #region homogeneo
        public Afiliados()
            : base("afiliado") {
        }

        public void FillWithAll() {
            Fill(SelectAll());
        }

        private void Fill(DataTable dt) {
            foreach (DataRow dr in dt.Rows) {
                items.Add(new Afiliado(dr));
            }
        }

        public Afiliado this[int index] {
            get {
                return (Afiliado)items[index];
            }

            set {
                items[index] = (object)value;
            }
        }

        #endregion
        //--------------FIN HOMOGENEO A TODAS LAS ENTIDADES------

        public override DataTable SelectAll() {
            return DB.ExecuteReader("SELECT * FROM "+ DB.schema + "vAfiliado");
        }

        public void FillWithFilter(string p_nombre, ListBox.SelectedObjectCollection p_objects, bool p_showAll) {

            string query = "SELECT * FROM " + DB.schema + "vAfiliado WHERE " + ((p_showAll) ? "1=1" : "rol_habilitado=1");

            if (p_objects.Count > 0) {
                query += " AND (";
                foreach (Funcionalidad func in p_objects) {
                    query += " rxf_funcionalidad = " + func.id + " OR";
                }
                query = query.Substring(0, query.Length - 3);
                query += ")";
            }

            if (p_nombre != "")
                query += " AND rol_nombre LIKE '%" + p_nombre + "%'";


            Fill(DB.ExecuteReader(query));
        }

    }
}
