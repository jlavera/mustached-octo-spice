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
        public string especialidades;
        public string[] especialidadesLista;

        public Usuario usuario;

        public Profesional(DataRow dr) {
            id = Convert.ToInt32(dr["pro_id"]);
            matricula = (dr["pro_matricula"] == DBNull.Value) ? -1 : Convert.ToInt32(dr["pro_matricula"]);
            usuarioId = Convert.ToInt32(dr["pro_usuario"]);
            habilitado = Convert.ToBoolean(dr["pro_habilitado"]);
            especialidadesLista = dr["especialidades"].ToString().Split(new string[]{", "}, StringSplitOptions.RemoveEmptyEntries);
            especialidades = dr["especialidades"].ToString();

            usuario = new Usuario(dr);
        }

        public override string ToString()
        {
            return usuario.ToString();
        }
    }
}
