using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Clases {
    public class Integrante {

        public string nombre;
        public string apellido;
        public string direccion;
        public string mail;
        public string tipoDocumento;
        public string contrasegna;
        public decimal numeroDocumento;
        public decimal telefono;
        public EstadoCivil estadoCivil;
        public string sexo;
        public string nombreUsuario;
        public bool esConyuge;
        public DateTime fechaNacimiento;

        public bool faltaGrabar;

        /// <summary>
        /// Crea un integrante a partir de un DataRow
        /// </summary>
        /// <param name="dr"></param>
        public Integrante(DataRow dr) {

            nombreUsuario = (string)dr["usu_nombreUsuario"];
            nombre = (string)dr["usu_nombre"];
            apellido = (string)dr["usu_apellido"];
            tipoDocumento = (dr["usu_tipoDocumento"] == System.DBNull.Value) ? "" : Convert.ToString(dr["usu_tipoDocumento"]);
            numeroDocumento = (decimal)dr["usu_numeroDocumento"];
            direccion = (string)dr["usu_direccion"];
            telefono = (decimal)dr["usu_telefono"];
            mail = (string)dr["usu_mail"];
            sexo = (dr["usu_sexo"] == System.DBNull.Value) ? "" : dr["usu_sexo"].ToString();
            fechaNacimiento = (DateTime)dr["usu_fechaNacimiento"];
            contrasegna = (string)dr["usu_contrasegna"];

            //--Marcar que NO falta grabar en DB
            faltaGrabar = false;
        }

        /// <summary>
        /// Crea un integrante a partir de sus atributos
        /// </summary>
        /// <param name="p_nombre"></param>
        /// <param name="p_apellido"></param>
        /// <param name="p_direccion"></param>
        /// <param name="p_mail"></param>
        /// <param name="p_tipoDocumento"></param>
        /// <param name="p_numeroDocumento"></param>
        /// <param name="p_telefono"></param>
        /// <param name="p_estado"></param>
        /// <param name="p_sexo"></param>
        /// <param name="p_nombreUsuario"></param>
        /// <param name="p_esConyuge"></param>
        public Integrante(string p_nombre, string p_apellido, string p_direccion,
            string p_mail, string p_tipoDocumento, long p_numeroDocumento,
            long p_telefono, EstadoCivil p_estado, string p_sexo,
            string p_nombreUsuario, bool p_esConyuge, DateTime p_fechaNacimiento, string p_contrasegna) {

            nombre = p_nombre;
            apellido = p_apellido;
            direccion = p_direccion;
            mail = p_mail;
            tipoDocumento = p_tipoDocumento;
            numeroDocumento = p_numeroDocumento;
            telefono = p_telefono;
            estadoCivil = p_estado;
            sexo = p_sexo;
            nombreUsuario = p_nombreUsuario;
            fechaNacimiento = p_fechaNacimiento;
            esConyuge = p_esConyuge;
            contrasegna = p_contrasegna;

            //--Marcar que falta grabar en DB
            faltaGrabar = true;

        }

        public override string ToString() {
            return apellido + ", " + nombre;
        }

    }
}
