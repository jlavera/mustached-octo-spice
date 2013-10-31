using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Clinica_Frba;

namespace Clinica_Frba.Clases {
    public class Afiliado {

        public int id;
        public int grupoFamiliar;
        public int orden;
        public int usuarioId;
        public int estadoCivil;
        public int familiaresACargo;
        public int planMedicoId;
        public bool habilitado;

        public Usuario usuario;
        public PlanMedico planMedico;
        public GrupoFamiliar grupoFamiliar;

        public Afiliado(DataRow dr) {
            id = Convert.ToInt32(dr["id"]);
            grupoFamiliar = (dr["grupoFamiliar"] == System.DBNull.Value)? -1 :Convert.ToInt32(dr["grupoFamiliar"]);
            orden = (dr["orden"] == System.DBNull.Value) ? -1 : Convert.ToInt32(dr["orden"]);
            usuarioId = Convert.ToInt32(dr["usuario"]);
            estadoCivil = (dr["estadoCivil"] == System.DBNull.Value) ? -1 : Convert.ToInt32(dr["estadoCivil"]);
            familiaresACargo = (dr["familiaresACargo"] == System.DBNull.Value) ? -1 : Convert.ToInt32(dr["familiaresACargo"]);
            planMedicoId = Convert.ToInt32(dr["planMedico"]);
            habilitado = Convert.ToBoolean(dr["habilitado"]);

            usuario = new Usuario(usuarioId);
            planMedico = new PlanMedico(planMedicoId);
        }

    }
}
