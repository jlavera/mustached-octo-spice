﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class Usuario {

        public int id{ get; set; }
        public string nombreUsuario { get; set; }
        public string contrasegna { get; set; }
        public int intentosFallidos { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipoDocumento { get; set; }
        public decimal numeroDocumento { get; set; }
        public string direccion { get; set; }
        public decimal telefono { get; set; }
        public string mail { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string sexo { get; set; }
        public bool habilitado { get; set; }

        public Usuario(DataRow dr) {

            id = (int)dr["id"];
            nombreUsuario = (string)dr["nombreUsuario"];
            contrasegna = (string)dr["contrasegna"];
            intentosFallidos = (int)dr["intentosFallidos"];
            nombre = (string)dr["nombre"];
            apellido = (string)dr["apellido"];
            tipoDocumento = Convert.ToString(dr["tipoDocumento"]);
            numeroDocumento = (decimal)dr["numeroDocumento"];
            direccion = (string)dr["direccion"];
            telefono = (decimal)dr["telefono"];
            mail = (string)dr["mail"];
            fechaNacimiento = (DateTime)dr["fechaNacimiento"];
            sexo = dr["sexo"].ToString();
            habilitado = (bool)Convert.ToBoolean(dr["habilitado"]);

        }
    }
}