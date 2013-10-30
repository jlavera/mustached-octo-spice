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
        public Rol this[string id]{
            get{
                foreach(Rol rol in items){
                    if (rol.id == Convert.ToInt32(id)){
                        return rol;
                    }
                }
                return null;
            }
        }

        #endregion
        //----------------------------------------------------


        public void FillWithFilter(string p_nombre, ListBox.SelectedObjectCollection p_objects) {

            string query = "SELECT  DISTINCT r.*, " + DB.schema + "concatenarFuncionalidad(id) AS funcionalidades FROM " + DB.schema + tabla +
                    " r LEFT JOIN " + DB.schema + "rol_x_funcionalidad AS rxf ON r.id = rxf.rol WHERE ";


            foreach (Funcionalidad func in p_objects) {
                query += " rxf.funcionalidad = " + func.id + " OR ";
            }

            if (p_nombre != "")
                query += " r.nombre LIKE '%" + p_nombre + "%'";
            else
                query += " (1 != 1)";

            Fill(DB.ExecuteReader(query));
        }

        override public DataTable SelectAll() {

            return DB.ExecuteReader("SELECT *, " + DB.schema + "concatenarFuncionalidad(id) AS funcionalidades FROM " + DB.schema + tabla);
        }

        public void FillRolesByUser(int p_userId) {

            //--Trae funcionalidades vacio para mantener polimorfismo
            Fill(DB.ExecuteReader("SELECT *, ' ' AS funcionalidades FROM " + DB.schema + "rol_x_usuario rxu JOIN " + DB.schema + "rol ON rxu.rol = rol.id WHERE usuario = \'" + p_userId + "\'"));
        }

        public void DeleteSelected(DataGridView dgv, DataGridViewSelectedRowCollection p_objects) {

            //--Eliminar de la DB
            string query = "DELETE FROM " + DB.schema + tabla + " r WHERE ";

            foreach (DataGridViewRow rol in p_objects) {
                query += " r.id= " + rol.Cells["id"].Value + " OR ";
            }

            query += " (1 != 1)";

            //if (DB.ExecuteCardinal(query) == -1)
                //return;

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