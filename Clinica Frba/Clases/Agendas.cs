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

            //--Eliminar de la DB
            if (p_objects.Count > 0)
            {
                string query = "DELETE " + DB.schema + tabla + " WHERE";

                foreach (DataGridViewRow agenda in p_objects)
                {
                    query += " age_id=" + agenda.Cells["id"].Value + " OR";
                }
                //Para sacar el ultimo or
                query = query.Substring(0, query.Length - 3);

                if (DB.ExecuteNonQuery(query) == -1)
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

        public void FillWithFilter(int _profesional, DateTime _desde, DateTime _hasta) {
            string query = "SELECT A.*, usu_apellido + ', ' + usu_nombre AS profesional FROM " + DB.schema + tabla + " A LEFT JOIN " + DB.schema + "vProfesional ON pro_id = age_profesional WHERE";
            if (_profesional != -1)
                query += " age_profesional = " + _profesional + " AND ";
            if (_desde != _hasta)
                query += " age_desde > '" + _desde.Date.ToString("yyyy-MM-dd") + "' AND age_hasta < '" + _hasta.Date.ToString("yyy-MM-dd") + "'     ";
            query = query.Substring(0, query.Length - 5);
            Fill(DB.ExecuteReader(query));
            
        }

        override public DataTable SelectAll(){
            return DB.ExecuteReader("SELECT A.*, usu_apellido + ', ' + usu_nombre AS profesional FROM " + DB.schema + tabla + " A LEFT JOIN " + DB.schema + "vProfesional ON pro_id = age_profesional");
        }
    }
}
