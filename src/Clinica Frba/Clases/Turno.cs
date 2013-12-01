using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Clinica_Frba.Clases;

namespace Clinica_Frba.Clases {
    class Turno {
        public int id;
        public Afiliado afiliado;
        public Profesional profesional;
        public Especialidad especialidad;
        public DateTime turno;

        public string sintomas;
        public string diagnostico;
        //public BonoFarmacia bonoFarmacia;
        //public BonoConsulta bonoConsulta;
        public bool habilitado;

        public Turno(DataRow dr) {

            id = Convert.ToInt32(dr["tur_id"]);
            afiliado = new Afiliado((int)dr["tur_afiliado"]);
            profesional = new Profesional((int)dr["tur_profesional"]);
            if(dr["tur_especialidad"] != DBNull.Value)
                especialidad = new Especialidad((int)dr["tur_especialidad"]);
            turno = Convert.ToDateTime(dr["tur_fechaYHoraTurno"]);
            habilitado = Convert.ToBoolean(dr["tur_habilitado"]);

        }
        public override string ToString() {
            return turno.ToString() + "\t" + profesional.usuario.apellido + ", " + profesional.usuario.nombre + "(" + profesional.id + ")\t" + afiliado.usuario.apellido + ", " + afiliado.usuario.nombre + "(" + afiliado.id + ")";
        }
    }
}
