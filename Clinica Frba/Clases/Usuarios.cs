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

        public void FillWithAll() {
            Fill(SelectAll());
        }

        private void Fill(DataTable dt) {
            foreach (DataRow dr in dt.Rows) {
                items.Add(new Usuario(dr));
            }
        }

        public Usuario this[int index] {
            get {
                return (Usuario)items[index];
            }

            set {
                items[index] = (object)value;
            }
        }

        #endregion
        //--------------FIN HOMOGENEO A TODAS LAS ENTIDADES------

        /// <summary>
        /// Devuelve un usuario que cumpla con el usuario y la contrase�a
        /// </summary>
        /// <param name="p_user">Usuario</param>
        /// <param name="p_pass">Contrase�a</param>
        /// <returns></returns>
        public Usuario VerifyUser(string p_user, string p_pass) {
            try {
                return new Usuario(DB.ExecuteReader("SELECT * FROM " + DB.schema + "usuario WHERE usu_nombreUsuario = \'" + p_user + "\' AND usu_contrasegna = \'" + p_pass + "\'").Rows[0]);
            } catch  {
                throw;
            }
        }

    }
}
