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
                    "JOIN " + DB.schema + "vProfesional ON pro_id = tur_profesional " +
                    "JOIN " +DB.schema + "vAfiliado ON afi_id = tur_afiliado " +
                "WHERE tur_afiliado=" + _afi.id + " AND DATEDIFF(DAY, tur_fechaYHoraTurno, '" + FuncionesBoludas.GetDateTime().ToString("yyyy-MM-dd") + "')<-1 AND tur_fechaYHoraLlegada IS NULL AND tur_fechaYHoraAtencion IS NULL AND tur_habilitado=1");
            //Tengo que hacerlo a mano porqu quiero los turnos chiquitos, no los grandes
            foreach (DataRow dr in dt.Rows) {
                items.Add(new Turno(dr));
            }
        }

        public void FillForProf(Profesional _prof) {
            DataTable dt = DB.ExecuteReader("SELECT * FROM " + DB.schema + "turno" +
                " JOIN "+DB.schema+"vProfesional ON tur_profesional = pro_id" +
                " JOIN " + DB.schema + "vAfiliado ON tur_afiliado = afi_id" +
                " WHERE tur_profesional = " + _prof.id + " " + //Que sea del profesional que atendiste
                "AND tur_fechaYHoraLlegada IS NULL " + //Que no haya llegado ya
                "AND CAST(tur_fechaYHoraTurno as DATE) = '" + FuncionesBoludas.GetDateTime().ToString("yyyy-MM-dd") +"' " + //Que sea de ese dia
                "AND CAST(tur_fechaYHoraTurno as TIME) > '" + FuncionesBoludas.GetDateTime().ToString("HH:mm") + "' " + //Pero que sea mas tarde
                "AND tur_habilitado=1 " +
                "ORDER BY tur_fechaYHoraTurno DESC"); //Ordenados
            
            //Tengo que hacerlo a mano porqu quiero los turnos chiquitos, no los grandes
            foreach (DataRow dr in dt.Rows) {
                items.Add(new Turno(dr));
            }
        }

        

        public void FillRegistrarAtencion(Profesional _prof) {

            DataTable dt = DB.ExecuteReader("POTATO");

            //Tengo que hacerlo a mano porqu quiero los turnos chiquitos, no los grandes
            foreach (DataRow dr in dt.Rows) {
                items.Add(new Turno(dr));
            }

            /*SELECT *

            FROM moustache_spice.turno

            WHERE
	            tur_profesional = 17
	            AND tur_habilitado = 1
	            AND tur_fechaYHoraAtencion IS NULL
	            AND tur_fechaYHoraLlegada IS NOT NULL
	            AND tur_fechaYHoraTurno > GETDATE()
             */

        }
    }
}
