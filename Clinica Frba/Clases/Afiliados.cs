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

        /// <summary>
        /// Trae todos los afiliados desde la vista (junto con las entidades de sus FK)
        /// </summary>
        /// <returns></returns>
        public override DataTable SelectAll() {
            return DB.ExecuteReader("SELECT * FROM "+ DB.schema + "vAfiliado");
        }

        /// <summary>
        /// Trae filtrando según sus atributos
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
            int p_familiares) {

            string query = "SELECT * FROM " + DB.schema + "vAfiliado WHERE";
            if(p_apellido!="")
                query+=" usu_apellido LIKE '%"+p_apellido+"%' AND ";
            if (p_direccion != "")
                query += " usu_direccion LIKE '%" + p_direccion + "%' AND ";
            if (p_estadoCivil.Count > 0){
                query += " (";
                foreach (EstadoCivil ec in p_estadoCivil)
                    query += "est_id =" + ec.id + " OR ";
                query.Substring(0, query.Length - 4);
                query += ") AND ";
            }
            if (p_familiares != -1)
                query += " afi_familiaresACargo =" + p_familiares+ " AND ";
            if (p_grupoFamiliar.Count > 0){
                query += " (";
                foreach (GrupoFamiliar gf in p_grupoFamiliar)
                    query += "afi_grupoFamiliar =" + gf.grupo + " OR ";
                query.Substring(0, query.Length - 4);
                query += ") AND ";
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
                query.Substring(0, query.Length - 4);
                query += ") AND ";
            }
            if (p_sexo != "")
                query += " usu_sexo =" + p_sexo + " AND ";
            if (p_telefono != -1)
                query += " usu_telefono =" + p_telefono+ " AND ";
            if (p_tipoDocumento != "")
                query += " usu_tipoDocumento='" + p_tipoDocumento+ "' AND ";


            //sacar la ultima basura
            query = query.Substring(0, query.Length - 5);
            Fill(DB.ExecuteReader(query));
        }

    }
}
