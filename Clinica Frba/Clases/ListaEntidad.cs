using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using Clinica_Frba.Clases;

namespace Clinica_Frba {
    public class ListaEntidad {

        public ArrayList items = new ArrayList();
        public string tabla;

        public ListaEntidad(string p_tabla) {
            tabla = p_tabla;
        }
        
        public Object[] ToList(){
            Object[] list = new Object[items.Count];

            for (int i = 0; i < items.Count; i++)
                list[i] = items[i];
            
            return list;
        }

        public void ClearList() {
            items.Clear();
        }

        virtual public DataTable SelectAll() {

            return DB.ExecuteReader("SELECT * FROM " + DB.schema + tabla);

        }

        public int CantRows() {
            return DB.ExecuteCardinal("SELECT COUNT(*) FROM " + DB.schema + tabla);
        }

        public int GetNextIdentity() {
            try {
                return DB.ExecuteCardinal("SELECT IDENT_CURRENT('" + DB.schema + tabla + "') +  IDENT_INCR('" + DB.schema + tabla + "')");
            } catch (Exception ex) {
                return -1;
            }
        }

        //--Enumerator
        #region enum
        private int position;

        public bool MoveNext() {
            position++;
            return (position < items.Count);
        }

        public void Reset() { position = -1; }

        public object Current {
            get { return items[position]; }
        }

        public IEnumerator GetEnumerator() {
            return (IEnumerator)this;
        }
        #endregion
    }
}
