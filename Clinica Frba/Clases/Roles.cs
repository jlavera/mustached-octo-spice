using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class Roles : ListaEntidad{

        
        //--------------HOMOGENEO A TODAS LAS ENTIDADES------
        #region homogeneo
        public Roles()
            : base("rol") {
        }

        public int CantRows() {
            return DB.ExecuteCardinal("SELECT COUNT(*) FROM " + DB.schema + tabla);
        }

        public void FillWithAll() {
            Fill(SelectAll());
        }

        private void Fill(DataTable dt) {

            foreach (DataRow dr in dt.Rows) {
                items.Add(new Rol(dr));
            }

        }
        #endregion
        //----------------------------------------------------

        public void FillRolesByUser(int p_userId) {
            Fill(DB.ExecuteReader("SELECT * FROM " + DB.schema + "rol_x_usuario rxu JOIN " + DB.schema + "rol ON rxu.rol = rol.id WHERE usuario = \'" + p_userId + "\'"));
        }

    }
}
