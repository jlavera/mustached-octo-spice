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
        public DateTime llegada;
        public DateTime atencion;
        public string sintomas;
        public string diagnostico;
        //public BonoFarmacia bonoFarmacia;
        public bool habilitado;

        public Turno(DataRow dr) {

            id = Convert.ToInt32(dr["tur_id"]);
            afiliado = new Afiliado(dr);
            profesional = new Profesional(dr);
            especialidad = new Especialidad(dr);
            turno = Convert.ToDateTime(dr["tur_fechaYHoraTurno"]);
            llegada = Convert.ToDateTime(dr["tur_fechaYHoraLlegada"]);
            atencion = Convert.ToDateTime(dr["tur_fechaYHoraAtencion"]);
            sintomas = dr["tur_sintomas"].ToString();
            diagnostico = dr["tur_diagnostico"].ToString();
            //bonoFarmacia = new BonoFarmacia(dr);
            habilitado = Convert.ToBoolean(dr["tur_habilitado"]);

        }

        public override string ToString() {
            return profesional.usuario.apellido + ", " + profesional.usuario.nombre + " - " + turno.ToString();
        }
    }
}
