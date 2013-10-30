using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class Rol {

        public int id;
        public string nombre;
        public string funcionalidades;
        public bool habilitado;

        public Rol(DataRow dr) {
            id = (int)dr["id"];
            nombre = (string)dr["nombre"];
            funcionalidades = dr["funcionalidades"].ToString();
            habilitado = Convert.ToBoolean(dr["habilitado"]);
        }

        public Rol(int p_id, string p_nombre, string p_funcionalidades) {
            id = p_id;
            nombre = p_nombre;
            funcionalidades = p_funcionalidades;
            habilitado = true;
        }

        public override string ToString() {
            return nombre;
        }

        public override bool Equals(object rol) {
            return (rol != System.DBNull.Value && ((Rol)rol).id == id && ((Rol)rol).nombre == nombre && ((Rol)rol).funcionalidades == funcionalidades);
        }
        
        public override int GetHashCode() {
            return base.GetHashCode();
        }

    }
}
