using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class Profesional {

        public int id;
        public int matricula;
        public int usuarioId;
        public bool habilitado;
        public Especialidades especialidades;

        public Usuario usuario;

        public Profesional() {
        }

        public Profesional(DataRow dr) {
            id = Convert.ToInt32(dr["pro_id"]);
            matricula = (dr["pro_matricula"] == DBNull.Value) ? -1 : Convert.ToInt32(dr["pro_matricula"]);
            usuarioId = Convert.ToInt32(dr["pro_usuario"]);
            habilitado = Convert.ToBoolean(dr["pro_habilitado"]);

            usuario = new Usuario(dr);
            especialidades = new Especialidades(id);
        }

        public override string ToString()
        {
            return usuario.ToString();
        }

        public string concatEsps() {
            string temp = "";
            foreach (Especialidad esp in especialidades.items)
                temp += esp.nombre + ", ";
            return (temp == "") ? "" : temp.Substring(0, temp.Length - 2);
        }

        public object[] ToList() {
            return especialidades.ToList();
        }
    }
}
