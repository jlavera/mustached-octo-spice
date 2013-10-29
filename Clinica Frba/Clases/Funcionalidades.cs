using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace Clinica_Frba.Clases {
    class Funcionalidades: ListaEntidad {

        public Funcionalidades(DataTable dt, string tabla):base(tabla) {
            foreach(DataRow dr in dt.Rows)
                items.Add(new Funcionalidad(dr));
        }

    }
}
