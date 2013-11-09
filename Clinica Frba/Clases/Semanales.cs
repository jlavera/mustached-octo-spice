using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Clinica_Frba.Clases;

namespace Clinica_Frba.Clases {
    class Semanales : ListaEntidad {
        //--------------HOMOGENEO A TODAS LAS ENTIDADES------
        #region homogeneo
        public Semanales()
            : base("semanal") {
        }

        public void FillWithAll() {
            Fill(SelectAll());
        }

        private void Fill(DataTable dt) {
            foreach (DataRow dr in dt.Rows) {
                items.Add(new Semanal(dr));
            }
        }

        public Semanal this[int index] {
            get {
                return (Semanal)items[index];
            }

            set {
                items[index] = (object)value;
            }
        }

        #endregion
        //--------------FIN HOMOGENEO A TODAS LAS ENTIDADES------

        public void FillByProfId(int p_id) {
            Fill(DB.ExecuteReader("SELECT * FROM moustache_spice.vAgenda WHERE age_profesional = " + p_id));
        }

        public void FillTurnosLibres(int p_id, DateTime s_dia) {
             Fill(DB.ExecuteReader("SELECT * FROM moustache_spice.semanal" +
                                        " LEFT JOIN moustache_spice.agenda ON sem_agenda = age_id" +
                                    " WHERE sem_habilitado=1 AND sem_dia=DATEPART(dw, '" + s_dia.ToString("yyyy-MM-dd") + "') AND age_profesional=" + p_id + " AND" +
                                    " (SELECT COUNT(1) FROM moustache_spice.turno" +
                                            " WHERE CAST(tur_fechaYHoraTurno AS DATE)='" + s_dia.ToString("yyyy-MM-dd") + "'" +
                                              " AND CAST(tur_fechaYHoraTurno AS TIME)=sem_hora" +
                                               " AND tur_profesional = age_profesional AND tur_habilitado=1)=0" +
                                     " ORDER BY sem_hora DESC"));
        }

        public void Add(Semanal item) {
            items.Add(item);
        }

        public Object[] GetByDay(int p_prof, DateTime p_day) {
            //Como el 1 es domingo en la DB, tengo que hacer lo del %7
            int datOfWeek = (int)(p_day.DayOfWeek+1)%7;

            Semanales temp = new Semanales();
            foreach (Semanal sem in items) {
                if ((sem.dia == datOfWeek) && (DB.ExecuteCardinal("SELECT COUNT(*) FROM " + DB.schema + "turno WHERE tur_profesional = " + p_prof + " AND CAST(tur_fechaYHoraTurno AS DATE)= CAST('" + p_day.Date + " ' AS DATE) AND CAST(tur_fechaYHoraTurno AS TIME) = CAST('" + sem.hora + "' AS TIME)") == 0))
                    temp.Add(sem);
            }
            return temp.ToList();
        }

    }
}
