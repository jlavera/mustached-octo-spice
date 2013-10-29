using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    class Funcionalidad: Entidad {

        public int id;
        public string nombre;

        public Funcionalidad(DataRow dr) {
            id = Convert.ToInt32(dr["id"]);
            nombre = dr["nombre"].ToString();

        }
    }
}
