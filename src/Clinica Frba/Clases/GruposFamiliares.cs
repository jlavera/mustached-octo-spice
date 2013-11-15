using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Clinica_Frba.Clases;

namespace Clinica_Frba.Clases {
    class GruposFamiliares:ListaEntidad {
        
        //--------------HOMOGENEO A TODAS LAS ENTIDADES------
        #region homogeneo
        public GruposFamiliares()
            : base("afiliado") {
        }

        public void FillWithAll() {
            Fill(SelectAll());
        }

        private void Fill(DataTable dt) {
            foreach (DataRow dr in dt.Rows) {
                items.Add(new GrupoFamiliar(dr));
            }
        }

        public GrupoFamiliar this[int index] {
            get {
                return (GrupoFamiliar)items[index];
            }

            set {
                items[index] = (object)value;
            }
        }

        #endregion
        //--------------FIN HOMOGENEO A TODAS LAS ENTIDADES------

        /// <summary>
        /// Obtiene los distintos grupos familiares, junto con el id, apellido y nombre del titular desde los afiliados
        /// </summary>
        /// <returns></returns>
        public override DataTable SelectAll() {
            return DB.ExecuteReader("SELECT DISTINCT afi_grupoFamiliar, afi_id, usu_apellido, usu_nombre, " +
                "(SELECT ((CASE WHEN 2>MAX(afi_orden) THEN 2 ELSE MAX(afi_orden) END) +1) FROM " + DB.schema + "afiliado WHERE afi_grupoFamiliar = va.afi_grupoFamiliar) AS 'grp_proximoOrden'" +
                "FROM " + DB.schema + "vAfiliado va WHERE afi_orden = 1");
        }

        /// <summary>
        /// Llena la entidad con grupos seg�n el nombre o apellido
        /// </summary>
        /// <param name="p_text"></param>
        public void FillByName(string p_text) {
            Fill(DB.ExecuteReader("SELECT DISTINCT afi_grupoFamiliar, afi_id, usu_apellido, usu_nombre, " +
                "(SELECT ((CASE WHEN 2>MAX(afi_orden) THEN 2 ELSE MAX(afi_orden) END) +1) FROM " + DB.schema + "afiliado WHERE afi_grupoFamiliar = va.afi_grupoFamiliar) AS 'grp_proximoOrden'" +
                "FROM " + DB.schema + "vAfiliado va WHERE afi_orden = 1 AND (usu_apellido LIKE '%" + p_text + "%' OR usu_nombre LIKE '%" + p_text + "%')"));
        }

    }
}
