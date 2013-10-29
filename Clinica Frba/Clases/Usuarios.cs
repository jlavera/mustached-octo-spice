using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Clinica_Frba.Clases {
    public class Usuarios : ListaEntidad {

        //--------------HOMOGENEO A TODAS LAS ENTIDADES------
        #region homogeneo
        public Usuarios()
            : base("usuario") {
        }

        public int CantRows() {
            return DB.ExecuteCardinal("SELECT COUNT(*) FROM " + DB.schema + tabla);
        }

        public void FillWithAll() {
            Fill(SelectAll());
        }

        private void Fill(DataTable dt) {

            foreach (DataRow dr in dt.Rows) {
                items.Add(new Usuario(dr));
            }

        }
        #endregion
        //----------------------------------------------------

        public Usuario VerifyUser(string p_user, string p_pass) {
            try {
                return new Usuario(DB.ExecuteReader("SELECT * FROM " + DB.schema + "usuario WHERE nombreUsuario = \'" + p_user + "\' AND " + "contrasegna = \'" + p_pass + "\'").Rows[0]);
            } catch (Exception ex) {
                return null;
            }
        }

    }
}