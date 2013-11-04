using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class Rol {

        public int id;
        public string nombre;
        public Funcionalidades funcionalidades;
        public bool habilitado;

        public Rol(DataRow dr) {
            id = (int)dr["rol_id"];
            nombre = (string)dr["rol_nombre"];
            funcionalidades = new Funcionalidades(Convert.ToInt32(dr["rol_id"]));   
            habilitado = Convert.ToBoolean(dr["rol_habilitado"]);
        }

        public string concatFuncs() {
            string temp = "";
            foreach (Funcionalidad func in funcionalidades.items)
                temp += func.nombre + ", ";
            return (temp == "")?"":temp.Substring(0, temp.Length - 2);
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
