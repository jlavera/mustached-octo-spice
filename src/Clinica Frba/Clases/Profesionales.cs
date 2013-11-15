using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Clinica_Frba.Clases;

namespace Clinica_Frba.Clases {
    class Profesionales : ListaEntidad {
        //--------------HOMOGENEO A TODAS LAS ENTIDADES------
        #region homogeneo
        public Profesionales()
            : base("profesional") {
        }

        public void FillWithAll() {
            Fill(SelectAll());
        }

        private void Fill(DataTable dt) {
            foreach (DataRow dr in dt.Rows) {
                items.Add(new Profesional(dr));
            }
        }

        public Profesional this[int index] {
            get {
                return (Profesional)items[index];
            }

            set {
                items[index] = (object)value;
            }
        }

        #endregion
        //--------------FIN HOMOGENEO A TODAS LAS ENTIDADES------

        public Profesional this[string id] {
            get {
                foreach (Profesional item in items) {
                    if (item.id.ToString() == id) {
                        return item;
                    }
                }
                return null;
            }
        }

        /// <summary>
        /// Devuelve los profesionales junto con sus entidades FK desde la vista
        /// </summary>
        /// <returns></returns>
        public override DataTable SelectAll() {
            return DB.ExecuteReader("SELECT * FROM " + DB.schema + "vProfesional");
        }


        public void FillWithFilter(string p_matricula,
            string p_nombre,
            string p_apellido,
            string p_direccion,
            string p_tipoDocumento,
            long p_numDocumento,
            long p_telefono,
            string p_mail,
            string p_nombreUsuario,
            string p_sexo,
            ListBox.SelectedObjectCollection p_especialidades,
            int p_limit) {

            string query = "SELECT TOP " + p_limit + " * FROM " + DB.schema + "vProfesional WHERE";
            if (p_apellido != "")
                query += " usu_apellido LIKE '%" + p_apellido + "%' AND ";
            if (p_direccion != "")
                query += " usu_direccion LIKE '%" + p_direccion + "%' AND ";
            if (p_especialidades.Count > 0) {
                query += " (";
                foreach (Especialidad esp in p_especialidades)
                    query += "especialidades LIKe '%" + esp.nombre + "%' OR ";
                query += "1!=1) AND ";
            }
            if (p_mail != "")
                query += " usu_mail LIKE '%" + p_mail + "%' AND ";
            if (p_nombre != "")
                query += " usu_nombre LIKE '%" + p_nombre + "%' AND ";
            if (p_nombreUsuario != "")
                query += " usu_nombreUsuario LIKE '%" + p_nombreUsuario + "%' AND ";
            if (p_numDocumento != -1)
                query += " usu_numeroDocumento=" + p_numDocumento + " AND ";
            if (p_sexo != "")
                query += " usu_sexo='" + ((p_sexo == "Masculino") ? "M" : "F") + "' AND ";
            if (p_telefono != -1)
                query += " usu_telefono =" + p_telefono + " AND ";
            if (p_tipoDocumento != "")
                query += " usu_tipoDocumento='" + p_tipoDocumento + "' AND ";
            if (p_matricula != "")
                query += " pro_matricula='" + p_matricula + "' AND ";


            //sacar la ultima basura
            query = query.Substring(0, query.Length - 5);
            Fill(DB.ExecuteReader(query));

        }

        /// <summary>
        /// Elimina de la db, de la lista entidad y del dgv los profesionales seleccionados
        /// </summary>
        /// <param name="dgv"></param>
        public void DeleteSelected(DataGridView dgv) {

            DataGridViewSelectedRowCollection p_objects = dgv.SelectedRows;

            //--Eliminar de la DB
            if (p_objects.Count > 0) {
                string query = "UPDATE " + DB.schema + tabla + " SET pro_habilitado=0 WHERE";

                foreach (DataGridViewRow profesional in p_objects) {
                    query += " pro_id = " + profesional.Cells["id"].Value.ToString() + " OR ";
                }
                //Para sacar el ultimo or
                query = query.Substring(0, query.Length - 3);

                if (DB.ExecuteNonQuery(query) == -1)
                    MessageBox.Show("Error en la delecion");

                //--Eliminar del ArrayList
                foreach (DataGridViewRow profesional in p_objects) {
                    items.Remove(this[profesional.Cells["id"].Value.ToString()]);
                }

                //--Eliminar del dgv
                foreach (DataGridViewRow profesional in p_objects) {
                    dgv.Rows.Remove(profesional);
                }
            } else {
                MessageBox.Show("Nada seleccionado para borrar");
            }
        }
    }
}
