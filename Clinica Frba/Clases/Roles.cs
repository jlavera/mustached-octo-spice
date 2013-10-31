using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Clinica_Frba.Clases {
    public class Roles : ListaEntidad {


        //--------------HOMOGENEO A TODAS LAS ENTIDADES------
        #region homogeneo
        public Roles()
            : base("rol") {
        }

        public void FillWithAll() {
            Fill(SelectAll());
        }

        private void Fill(DataTable dt) {
            foreach (DataRow dr in dt.Rows) {
                items.Add(new Rol(dr));
            }
        }

        public Rol this[int index] {
            get {
                return (Rol)items[index];
            }

            set {
                items[index] = (object)value;
            }
        }

        #endregion
        //--------------FIN HOMOGENEO A TODAS LAS ENTIDADES------
        
        public Rol this[string id]{
            get{
                foreach(Rol item in items){
                    if (item.id == Convert.ToInt32(id)){
                        return item;
                    }
                }
                return null;
            }
        }

        public void FillWithFilter(string p_nombre, ListBox.SelectedObjectCollection p_objects, bool p_showAll) {

            string query = "SELECT DISTINCT r.*, " + DB.schema + "concatenarFuncionalidad(rol_id) AS funcionalidades FROM " + DB.schema + tabla +
                " r LEFT JOIN " + DB.schema + "rol_x_funcionalidad ON rol_id = rxf_rol WHERE " + ((p_showAll) ? "1=1" : "rol_habilitado=1");


            if (p_objects.Count > 0)
            {
                query += " AND (";
                foreach (Funcionalidad func in p_objects)
                {
                    query += " rxf_funcionalidad = " + func.id + " OR";
                }
                query = query.Substring(0, query.Length - 3);
                query += ")";
            }

            if (p_nombre != "")
                query += " AND rol_nombre LIKE '%" + p_nombre + "%'";


            Fill(DB.ExecuteReader(query));
        }

        override public DataTable SelectAll() {

            return DB.ExecuteReader("SELECT *, " + DB.schema + "concatenarFuncionalidad(id) AS funcionalidades FROM " + DB.schema + tabla + " WHERE rol_habilitado=1");
        }

        public void FillRolesByUser(int p_userId) {

            //--Trae funcionalidades vacio para mantener polimorfismo
            Fill(DB.ExecuteReader("SELECT *, ' ' AS funcionalidades FROM " + DB.schema + "rol_x_usuario JOIN " + DB.schema + "rol ON rxu_rol = rol_id WHERE rxu_usuario = " + p_userId));
        }

        public void DeleteSelected(DataGridView dgv, DataGridViewSelectedRowCollection p_objects) {

            //--Eliminar de la DB
            string query = "UPDATE " + DB.schema + tabla + " SET rol_habilitado=0 WHERE";

            foreach (DataGridViewRow rol in p_objects) {
                query += " rol_id=" + rol.Cells["id"].Value + " OR";
            }
            //Para sacar el ultimo or
            query = query.Substring(0, query.Length - 3);

            if (DB.ExecuteNonQuery(query) == -1)
                MessageBox.Show("Error en la delecion");

            //--Eliminar del ArrayList
            foreach (DataGridViewRow rol in p_objects) {
                items.Remove(this[rol.Cells["id"].Value.ToString()]);
            }

            //--Eliminar del dgv
            foreach (DataGridViewRow rol in p_objects) {
                dgv.Rows.Remove(rol);
            }

        }
    }
}
