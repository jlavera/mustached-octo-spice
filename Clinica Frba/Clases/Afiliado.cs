using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Clinica_Frba;

namespace Clinica_Frba.Clases {
    public class Afiliado {

        public int id;
        public int orden;
        public int usuarioId;
        public int estadoCivilId;
        public int familiaresACargo;
        public int planMedicoId;
        public bool habilitado;

        public Usuario usuario;
        public PlanMedico planMedico;
        public EstadoCivil estadoCivil;
        public GrupoFamiliar grupoFamiliar;

        public Afiliado() { } //Afiliado de mentiritas :D

        public Afiliado(DataRow dr) {
            id = Convert.ToInt32(dr["afi_id"]);
            orden = (dr["afi_orden"] == System.DBNull.Value) ? -1 : Convert.ToInt32(dr["afi_orden"]);
            usuarioId = Convert.ToInt32(dr["afi_usuario"]);
            estadoCivilId = (dr["afi_estadoCivil"] == System.DBNull.Value) ? -1 : Convert.ToInt32(dr["afi_estadoCivil"]);
            familiaresACargo = (dr["afi_familiaresACargo"] == System.DBNull.Value) ? -1 : Convert.ToInt32(dr["afi_familiaresACargo"]);
            planMedicoId = (dr["afi_planMedico"] == System.DBNull.Value) ? -1 : Convert.ToInt32(dr["afi_planMedico"]);
            habilitado = Convert.ToBoolean(dr["afi_habilitado"]);

            usuario = new Usuario(dr);
            planMedico = new PlanMedico(dr);
            estadoCivil = new EstadoCivil(dr);
            grupoFamiliar = new GrupoFamiliar(dr);
        }

        public Afiliado(int p_id) {
            DataTable dt = DB.ExecuteReader("SELECT * FROM "+DB.schema + "vAfiliado WHERE afi_usuario = " + p_id);

            if(dt.Rows.Count==0)
                throw new NoTrajoNadaExcep();
            DataRow dr = dt.Rows[0];

            id = Convert.ToInt32(dr["afi_id"]);
            orden = (dr["afi_orden"] == System.DBNull.Value) ? -1 : Convert.ToInt32(dr["afi_orden"]);
            usuarioId = Convert.ToInt32(dr["afi_usuario"]);
            estadoCivilId = (dr["afi_estadoCivil"] == System.DBNull.Value) ? -1 : Convert.ToInt32(dr["afi_estadoCivil"]);
            familiaresACargo = (dr["afi_familiaresACargo"] == System.DBNull.Value) ? -1 : Convert.ToInt32(dr["afi_familiaresACargo"]);
            planMedicoId = (dr["afi_planMedico"] == System.DBNull.Value) ? -1 : Convert.ToInt32(dr["afi_planMedico"]);
            habilitado = Convert.ToBoolean(dr["afi_habilitado"]);

            usuario = new Usuario(dr);
            planMedico = new PlanMedico(dr);
            estadoCivil = new EstadoCivil(dr);
            grupoFamiliar = new GrupoFamiliar(dr);
        }

        public override string ToString() {
            return usuario.ToString();
        }

    }
}
