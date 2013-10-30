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

            string query = "SELECT  DISTINCT r.*, " + DB.schema + "concatenarFuncionalidad(id) AS funcionalidades FROM " + DB.schema + tabla +
                " r LEFT JOIN " + DB.schema + "rol_x_funcionalidad AS rxf ON r.id = rxf.rol WHERE " + ((p_showAll) ? "1=1" : "r.habilitado=1");


            if (p_objects.Count > 0)
            {
                query += " AND (";
                foreach (Funcionalidad func in p_objects)
                {
                    query += " rxf.funcionalidad = " + func.id + " OR";
                }
                query = query.Substring(0, query.Length - 3);
                query += ")";
            }

            if (p_nombre != "")
                query += " AND r.nombre LIKE '%" + p_nombre + "%'";


            Fill(DB.ExecuteReader(query));
        }

        override public DataTable SelectAll() {

            return DB.ExecuteReader("SELECT *, " + DB.schema + "concatenarFuncionalidad(id) AS funcionalidades FROM " + DB.schema + tabla + " WHERE habilitado=1");
        }

        public void FillRolesByUser(int p_userId) {

            //--Trae funcionalidades vacio para mantener polimorfismo
            Fill(DB.ExecuteReader("SELECT *, ' ' AS funcionalidades FROM " + DB.schema + "rol_x_usuario rxu JOIN " + DB.schema + "rol ON rxu.rol = rol.id WHERE usuario = \'" + p_userId + "\'"));
        }

        public void DeleteSelected(DataGridView dgv, DataGridViewSelectedRowCollection p_objects) {

            //--Eliminar de la DB
            string query = "UPDATE " + DB.schema + tabla + " SET habilitado=0 WHERE";

            foreach (DataGridViewRow rol in p_objects) {
                query += " id=" + rol.Cells["id"].Value + " OR";
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
