using System;
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
            DataTable dt = DB.ExecuteReader("SELECT * FROM " + DB.schema + "turno " +
                    "JOIN " +DB.schema + "vProfesional pro ON pro_id = tur_profesional " +
                "WHERE tur_afiliado=" + _afi.id + " AND DATEDIFF(DAY, tur_fechaYHoraTurno, '" + FuncionesBoludas.GetDateTime().ToString("yyyy-MM-dd") + "')<-1 AND tur_fechaYHoraLlegada IS NULL AND tur_fechaYHoraAtencion IS NULL AND tur_habilitado=1");
            //Tengo que hacerlo a mano porqu quiero los turnos chiquitos, no los grandes
            foreach (DataRow dr in dt.Rows) {
                items.Add(new Turno(_afi, dr));
            }
        }

        public void FillForProf(Profesional _prof) {
            DataTable dt = DB.ExecuteReader("SELECT * FROM " + DB.schema + "turno t " +
                " WHERE tur_profesional = " + _prof.id + " " +
                "AND tur_fechaYHoraLlegada IS NULL " +
                "AND DATEDIFF(MINUTE, GETDATE(), t.tur_fechaYHoraTurno) > -100 " + // FIXME LOL NO
                "AND CAST(GETDATE() as DATE) = CAST(t.tur_fechaYHoraTurno as DATE) " +
                "ORDER BY tur_fechaYHoraTurno DESC");
            
            //Tengo que hacerlo a mano porqu quiero los turnos chiquitos, no los grandes
            foreach (DataRow dr in dt.Rows) {
                items.Add(new Turno(dr));
            }
        }
    }
}
