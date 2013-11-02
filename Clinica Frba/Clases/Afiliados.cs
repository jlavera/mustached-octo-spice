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

        public Afiliado this[string id] {
            get {
                foreach (Afiliado item in items) {  
                    //Tengo que sacarle los ultimos 3 porque trae el ID con el orden
                    if (item.id == Convert.ToInt32(id.Substring(0, id.Length-3))) {
                        return item;
                    }
                }
                return null;
            }
        }

        /// <summary>
        /// Trae todos los afiliados desde la vista (junto con las entidades de sus FK)
        /// </summary>
        /// <returns></returns>
        public override DataTable SelectAll() {
            return DB.ExecuteReader("SELECT * FROM "+ DB.schema + "vAfiliado");
        }

        /// <summary>
        /// Trae filtrando seg�n sus atributos
        /// </summary>
        public void FillWithFilter(string p_nombre,
            string p_apellido,
            string p_direccion,
            string p_tipoDocumento,
            long p_numDocumento,
            long p_telefono,
            string p_mail,
            string p_nombreUsuario,
            string p_sexo,
            ListBox.SelectedObjectCollection p_grupoFamiliar,
            ListBox.SelectedObjectCollection p_estadoCivil,
            ListBox.SelectedObjectCollection p_planMedico,
            int p_orden,
            int p_familiares,
            int p_limit) {

            string query = "SELECT TOP " + p_limit  + " *, ' ' AS grp_proximoOrden FROM " + DB.schema + "vAfiliado WHERE"; //--Proximo orden para mantener polimorfismo
            if(p_apellido!="")
                query+=" usu_apellido LIKE '%"+p_apellido+"%' AND ";
            if (p_direccion != "")
                query += " usu_direccion LIKE '%" + p_direccion + "%' AND ";
            if (p_estadoCivil.Count > 0){
                query += " (";
                foreach (EstadoCivil ec in p_estadoCivil)
                    query += "est_id =" + ec.id + " OR ";
                query += "1!=1) AND ";
            }
            if (p_familiares != -1)
                query += " afi_familiaresACargo =" + p_familiares+ " AND ";
            if (p_grupoFamiliar.Count > 0){
                query += " (";
                foreach (GrupoFamiliar gf in p_grupoFamiliar)
                    query += "afi_grupoFamiliar =" + gf.grupo + " OR ";
                query += "1!=1) AND ";
            }
            if (p_mail != "")
                query += " usu_mail LIKE '%" + p_mail + "%' AND ";
            if (p_nombre != "")
                query += " usu_nombre LIKE '%" + p_nombre+ "%' AND ";
            if (p_nombreUsuario != "")
                query += " usu_nombreUsuario LIKE '%" + p_nombreUsuario + "%' AND ";
            if (p_numDocumento != -1)
                query += " usu_numeroDocumento=" + p_numDocumento+ " AND ";
            if (p_orden != -1)
                query += " afi_orden =" + p_orden+ " AND ";
            if (p_planMedico.Count > 0){
                query += " (";
                foreach (PlanMedico pm in p_planMedico)
                    query += "pla_id =" + pm.id + " OR ";
                query += "1!=1) AND ";
            }
            if (p_sexo != null)
                query += " usu_sexo='" + ((p_sexo=="Masculino") ? "M" : "F") + "' AND ";
            if (p_telefono != -1)
                query += " usu_telefono =" + p_telefono+ " AND ";
            if (p_tipoDocumento != "")
                query += " usu_tipoDocumento='" + p_tipoDocumento+ "' AND ";


            //sacar la ultima basura
            query = query.Substring(0, query.Length - 5);
            Fill(DB.ExecuteReader(query));
        }

        /// <summary>
        /// Elimina de la db, de la lista entidad y del dgv los roles seleccionados
        /// </summary>
        /// <param name="dgv"></param>
        public void DeleteSelected(DataGridView dgv) {
            DataGridViewSelectedRowCollection p_objects = dgv.SelectedRows;

            //--Eliminar de la DB
            if (p_objects.Count > 0){
                string query = "UPDATE " + DB.schema + tabla + " SET afi_habilitado=0 WHERE";

                foreach (DataGridViewRow afiliado in p_objects){
                    query += " afi_grupoFamiliar2=" + afiliado.Cells["id"].Value.ToString().Substring(0, afiliado.Cells["id"].Value.ToString().Length - 3) + " AND afi_orden= " + afiliado.Cells["id"].Value.ToString().Substring(afiliado.Cells["id"].Value.ToString().Length - 2) + " OR";
                }
                //Para sacar el ultimo or
                query = query.Substring(0, query.Length - 3);

                if (DB.ExecuteNonQuery(query) == -1)
                    MessageBox.Show("Error en la delecion");

                //--Eliminar del ArrayList
                foreach (DataGridViewRow afiliado in p_objects)
                {
                    items.Remove(this[afiliado.Cells["id"].Value.ToString()]);
                }

                //--Eliminar del dgv
                foreach (DataGridViewRow rol in p_objects)
                {
                    dgv.Rows.Remove(rol);
                }
            }
            else {
                MessageBox.Show("Nada seleccionado para borrar");
            }
        }

    }
}
