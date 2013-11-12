﻿using System;
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
        //public BonoConsulta bonoConsulta;
        public bool habilitado;

        public Turno(DataRow dr) {

            id = Convert.ToInt32(dr["tur_id"]);
            afiliado = new Afiliado(dr);
            profesional = new Profesional(dr);
            especialidad = new Especialidad(dr);
            turno = Convert.ToDateTime(dr["tur_fechaYHoraTurno"]);
            if (dr["tur_fechaYHoraLlegada"] != DBNull.Value)
                llegada = Convert.ToDateTime(dr["tur_fechaYHoraLlegada"]);
            if(dr["tur_fechaYHoraLlegada"] != DBNull.Value)
                atencion = Convert.ToDateTime(dr["tur_fechaYHoraLlegada"]);
            sintomas = (dr["tur_sintomas"] != DBNull.Value) ? dr["tur_sintomas"].ToString() : "";
            diagnostico = (dr["tur_diagnostico"] != DBNull.Value) ? dr["tur_diagnostico"].ToString() : "";
            //bonoFarmacia = new BonoFarmacia(dr);
            habilitado = Convert.ToBoolean(dr["tur_habilitado"]);

        }

        public Turno(Afiliado _afiliado, DataRow dr) {
            //Turno pequeño pra la cancelacion
            id = Convert.ToInt32(dr["tur_id"]); 
            profesional = new Profesional((int)dr["pro_usuario"]);
            afiliado = _afiliado;
            turno = Convert.ToDateTime(dr["tur_fechaYHoraTurno"]);
        }

        public override string ToString() {
            return profesional.usuario.apellido + ", " + profesional.usuario.nombre + " - " + turno.ToString();
        }
    }
}
