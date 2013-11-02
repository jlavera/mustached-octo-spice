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
            return DB.ExecuteReader("SELECT DISTINCT afi_grupoFamiliar, afi_id, usu_apellido, usu_nombre, (SELECT MAX(afi_orden) + 1 FROM " + DB.schema + tabla +" WHERE afi_grupoFamiliar = va.afi_grupoFamiliar) AS 'grp_proximoOrden' FROM " + DB.schema + "vAfiliado va WHERE afi_orden = 1");
        }

    }
}
