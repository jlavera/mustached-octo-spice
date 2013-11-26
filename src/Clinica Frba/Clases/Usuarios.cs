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

        //Subrecarga del new para pasarle un rol y seleccione todos los que tengan ese rol
       public Usuarios(int _id)
            : base("usuario") {
            //Como esta el triger que borra si se deshabilitan, ni me gasto en hacer un  where
                Fill(DB.ExecuteReader("SELECT DISTINCT * FROM " + DB.schema + "usuario LEFT JOIN " + DB.schema + "rol_x_usuario ON rxu_usuario = usu_id WHERE rxu_rol=" + _id));
        }

        /// <summary>
        /// Devuelve un usuario que cumpla con el usuario y la contrase�a
        /// </summary>
        /// <param name="p_user">Usuario</param>
        /// <param name="p_pass">Contrase�a</param>
        /// <returns></returns>
        public Usuario VerifyUser(string p_user, string p_pass){
            DataTable dt =DB.ExecuteReader("SELECT * FROM " + DB.schema + "usuario WHERE usu_nombreUsuario = '" + p_user + "'");
            if (dt.Rows.Count > 0){
                //No me preocupa que exista mas de uno porqeu es UNIQUE
                Usuario usu = new Usuario(dt.Rows[0]);
                if (usu.habilitado == false)
                    throw new Exception("El usuario esta inhabilitado, porfavor contactar a un administrador");
                else if (usu.intentosFallidos >= 3)
                    throw new Exception("Muchos intentos fallidos, contacte a un administrador");
                else if (usu.contrasegna != p_pass){
                    //Updetea, si lo encuentra, bien, sino no importa no updetea nada
                    DB.ExecuteNonQuery("UPDATE " + DB.schema + "usuario SET usu_intentosFallidos=usu_intentosFallidos+1 WHERE usu_nombreUsuario = '" + p_user + "'");
                    throw new Exception("Contraseña incorrecta");
                }else
                    return usu;
            }else
                throw new Exception("No existe el usuario");
        }

    }
}
