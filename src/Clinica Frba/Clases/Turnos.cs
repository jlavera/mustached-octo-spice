﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Clinica_Frba.Clases;
using System.Windows.Forms;

namespace Clinica_Frba.Clases {
    class Turnos : ListaEntidad {
        //--------------HOMOGENEO A TODAS LAS ENTIDADES------
        #region homogeneo
        public Turnos()
            : base("turno") {
        }

        public void FillWithAll() {
            Fill(SelectAll());
        }

        private void Fill(DataTable dt) {
            foreach (DataRow dr in dt.Rows) {
                items.Add(new Turno(dr));
            }
        }

        public Turno this[int index] {
            get {
                return (Turno)items[index];
            }

            set {
                items[index] = (object)value;
            }
        }

        #endregion
        //--------------FIN HOMOGENEO A TODAS LAS ENTIDADES------

        public void FillForAfi(Afiliado _afi) {
            Fill(DB.ExecuteReader("SELECT * FROM " + DB.schema + "turno" +
               " JOIN " + DB.schema + "vProfesional ON tur_profesional = pro_id" +
               " JOIN " + DB.schema + "vAfiliado ON tur_afiliado = afi_id" +
               " WHERE tur_afiliado = " + _afi.id + " " + //Que sea del afiliado que pidio el turno
                   "AND (SELECT COUNT(1) FROM " + DB.schema + "atencion WHERE ate_turno = tur_id) = 0" +
               "AND CAST(tur_fechaYHoraTurno as DATE) = '" + FuncionesBoludas.GetDateTime().ToString("yyyy-MM-dd") + "' " + //Que sea de ese dia
               "AND CAST(tur_fechaYHoraTurno as TIME) > '" + FuncionesBoludas.GetDateTime().ToString("HH:mm") + "' " + //Pero que sea mas tarde
               "AND tur_habilitado=1 " +
               "ORDER BY tur_fechaYHoraTurno ASC")); //Ordenados
        }

        public void FillForProf(Profesional _prof, Boolean llego) {
            //El discriminador es para saber si tiene que tomar los turnos que llegaron, o lo que todavia no

            Fill(DB.ExecuteReader("SELECT * FROM " + DB.schema + "turno" +
                " JOIN "+DB.schema+"vProfesional ON tur_profesional = pro_id" +
                " JOIN " + DB.schema + "vAfiliado ON tur_afiliado = afi_id" +
                " WHERE tur_profesional = " + _prof.id + " " + //Que sea del profesional que atendiste
                    "AND (SELECT COUNT(1) FROM " + DB.schema + "atencion WHERE ate_turno = tur_id) " +
                (!llego ? "=0 " : "=1 ") +
                "AND CAST(tur_fechaYHoraTurno as DATE) = '" + FuncionesBoludas.GetDateTime().ToString("yyyy-MM-dd") +"' " + //Que sea de ese dia
                "AND CAST(tur_fechaYHoraTurno as TIME) > '" + FuncionesBoludas.GetDateTime().ToString("HH:mm") + "' " + //Pero que sea mas tarde
                "AND tur_habilitado=1 " +
                "ORDER BY tur_fechaYHoraTurno ASC")); //Ordenados
        }


        public void FillForProf2(Profesional _prof, Boolean llego, Boolean atendio) {
            //El discriminador es para saber si tiene que tomar los turnos que llegaron, o lo que todavia no
            //--Y para saber si fue atendido o no

            Fill(DB.ExecuteReader("SELECT * FROM " + DB.schema + "turno" +
                " JOIN " + DB.schema + "vProfesional ON tur_profesional = pro_id" +
                " JOIN " + DB.schema + "vAfiliado ON tur_afiliado = afi_id" +
                " WHERE tur_profesional = " + _prof.id + " " + //Que sea del profesional que atendiste
                "AND (SELECT COUNT(1) FROM " + DB.schema + "atencion WHERE ate_turno = tur_id " + ((atendio)? "AND ate_fechaYHoraAtencion IS NOT NULL" : "" ) + ") " + 
                (!llego ? "=0 " : "=1 ") +
                "AND CAST(tur_fechaYHoraTurno as DATE) = '" + FuncionesBoludas.GetDateTime().ToString("yyyy-MM-dd") + "' " + //Que sea de ese dia
                "AND CAST(tur_fechaYHoraTurno as TIME) > '" + FuncionesBoludas.GetDateTime().ToString("HH:mm") + "' " + //Pero que sea mas tarde
                "AND tur_habilitado=1 " +
                "ORDER BY tur_fechaYHoraTurno ASC")); //Ordenados
        }

        public void FillForDay(Profesional _prof, DateTime _dia) {
            //--Trae los turnos de un profesional en un día específico

            Fill(DB.ExecuteReader("SELECT * FROM " + DB.schema + "turno" +
                " JOIN " + DB.schema + "vProfesional ON tur_profesional = pro_id" +
                " JOIN " + DB.schema + "vAfiliado ON tur_afiliado = afi_id" +
                " WHERE tur_profesional = " + _prof.id + " " + //Que sea del profesional que atendiste
                "AND CAST(tur_fechaYHoraTurno as DATE) = '" + _dia.ToString("yyyy-MM-dd") + "' " + //Que sea de ese dia
                "AND tur_habilitado = 1 " +
                "ORDER BY tur_fechaYHoraTurno ASC")); //Ordenados
        }
    }
}
