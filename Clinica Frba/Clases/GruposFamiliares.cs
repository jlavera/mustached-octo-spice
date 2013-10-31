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


        public override DataTable SelectAll() {
            return DB.ExecuteReader("SELECT DISTINCT afi_grupoFamiliar, afi_id, usu_apellido + ', ' + usu_nombre AS afi_titular FROM " + DB.schema +"vAfiliado WHERE afi_orden = 1");
        }

    }
}
