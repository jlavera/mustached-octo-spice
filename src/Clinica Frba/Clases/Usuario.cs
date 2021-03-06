﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Clinica_Frba.Clases;

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

            id = (int)dr["usu_id"];
            nombreUsuario = (string)dr["usu_nombreUsuario"];
            contrasegna = (dr["usu_contrasegna"] == System.DBNull.Value)? "" : (string)dr["usu_contrasegna"];
            intentosFallidos = (int)dr["usu_intentosFallidos"];
            nombre = (dr["usu_nombre"] == System.DBNull.Value) ? "" : (string)dr["usu_nombre"];
            apellido = (dr["usu_apellido"] == System.DBNull.Value) ? "" : (string)dr["usu_apellido"];
            tipoDocumento = (dr["usu_tipoDocumento"] == System.DBNull.Value)? "":Convert.ToString(dr["usu_tipoDocumento"]);
            numeroDocumento = (dr["usu_numeroDocumento"] == System.DBNull.Value) ? -1 : (decimal)dr["usu_numeroDocumento"];
            direccion = (dr["usu_direccion"] == System.DBNull.Value) ? "" : (string)dr["usu_direccion"];
            telefono = (dr["usu_telefono"] == System.DBNull.Value) ? -1 : (decimal)dr["usu_telefono"];
            mail = (dr["usu_mail"] == System.DBNull.Value) ? "" : (string)dr["usu_mail"];
            fechaNacimiento = (dr["usu_fechaNacimiento"] == System.DBNull.Value) ? DateTime.MinValue : (DateTime)dr["usu_fechaNacimiento"];
            sexo = (dr["usu_sexo"] == System.DBNull.Value)? "":dr["usu_sexo"].ToString();
            habilitado = (bool)Convert.ToBoolean(dr["usu_habilitado"]);

        }

        public override string ToString()
        {
            return apellido + ", " + nombre;
        }

        public override bool Equals(object x) {
            return (x != System.DBNull.Value && ((Usuario)x).id == id);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
