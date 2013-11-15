using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Clinica_Frba.Clases {
    public class Agendas : ListaEntidad {


        //--------------HOMOGENEO A TODAS LAS ENTIDADES------
        #region homogeneo
        public Agendas()
            : base("agenda") {
        }

        public void FillWithAll() {
            Fill(SelectAll());
        }

        private void Fill(DataTable dt) {
            foreach (DataRow dr in dt.Rows) {
                items.Add(new Agenda(dr));
            }
        }

        public Agenda this[int index] {
            get {
                return (Agenda)items[index];
            }

            set {
                items[index] = (object)value;
            }
        }

        #endregion
        //--------------FIN HOMOGENEO A TODAS LAS ENTIDADES------
        
        public Agenda this[string id]{
            get{
                foreach(Agenda item in items){
                    if (item.id == Convert.ToInt32(id)){
                        return item;
                    }
                }
                return null;
            }
        }
        public void DeleteSelected(DataGridView dgv, DataGridViewSelectedRowCollection p_objects)
        {
            MessageBox.Show("Esto va a tardar porque pretende cancelar todos los turnos", "Warning");
            //--Eliminar de la DB
            if (p_objects.Count > 0)
            {
                string queryAge = "DELETE " + DB.schema + tabla + " WHERE";
                string querySem = "DELETE " + DB.schema + "semanal WHERE";

                foreach (DataGridViewRow agenda in p_objects)
                {
                    queryAge += " age_id=" + agenda.Cells["id"].Value + " OR";
                    querySem += " sem_agenda=" + agenda.Cells["id"].Value + " OR";
                }
                //Para sacar el ultimo or
                queryAge = queryAge.Substring(0, queryAge.Length - 3);
                querySem = querySem.Substring(0, querySem.Length - 3);

                if (DB.ExecuteNonQuery(querySem + "; " + queryAge) == -1)
                    MessageBox.Show("Error en la delecion");

                //--Eliminar del ArrayList
                foreach (DataGridViewRow agenda in p_objects)
                {
                    items.Remove(this[agenda.Cells["id"].Value.ToString()]);
                }

                //--Eliminar del dgv
                foreach (DataGridViewRow agenda in p_objects)
                {
                    dgv.Rows.Remove(agenda);
                }
            }
        }

        public void FillWithFilter(Profesional _profesional, DateTime _desde, DateTime _hasta, int _dia, string _dia_desde, string _dia_hasta)
        {
            string query = "SELECT DISTINCT age_id, age_desde, age_hasta, age_profesional, profesional FROM " + DB.schema + "vAgenda WHERE";
            if (_profesional != null)
                query += " age_profesional = " + _profesional.id + " AND ";
            if (_desde != _hasta)
                query += " age_desde > '" + _desde.Date.ToString("yyyy-MM-dd") + "' AND age_hasta < '" + _hasta.Date.ToString("yyy-MM-dd") + "' AND ";
            if (_dia != -1 && (_dia_desde != "" || _dia_hasta != "")) {
                query += " sem_dia = " + _dia + " AND ";
                if (_dia_desde != "")
                    query += "sem_hora > '" + _dia_desde + "' AND ";
                if (_dia_hasta != "")
                    query += "sem_hora < '" + _dia_hasta + "' AND ";
            }
            query = query.Substring(0, query.Length - 5);
            Fill(DB.ExecuteReader(query));
            
        }

        override public DataTable SelectAll(){
            return DB.ExecuteReader("SELECT DISTINCT age_id, age_desde, age_hasta, age_profesional, profesional FROM " + DB.schema + "vAgenda");
        }
    }
}
