using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Clinica_Frba.Clases {
    static class DB {

        static private string strCon = "Data Source=JOA-VM\\SQLSERVER2008;Initial Catalog=GD2C2013;Persist Security Info=True;User ID=gd;Password=gd2013";
        static private SqlConnection sqlCon = new SqlConnection(strCon);
        static public string schema = "moustache_spice.";

        static private void OpenConnection() {

            sqlCon.Open();
        }

        static private void CloseConnection() {

            sqlCon.Close();
        }

        /// <summary>
        /// Ejecuta comando y lo devuelve en un datatable
        /// </summary>
        /// <param name="command">Comando</param>
        /// <returns></returns>
        static public DataTable ExecuteReader(string command) {

            sqlCon.Open();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(command, sqlCon);
            da.Fill(dt);
            da.Dispose();

            sqlCon.Close();

            return dt;
        }

        /// <summary>
        /// Ejecuta comando y devuelve un número
        /// </summary>
        /// <param name="command">Comando</param>
        /// <returns></returns>
        static public int ExecuteCardinal(string command) {
            SqlDataReader reader = null;
            int temp;

            try {
                sqlCon.Open();

                reader = (new SqlCommand(command, sqlCon)).ExecuteReader();
                reader.Read();

                temp = reader.GetInt32(0);

                sqlCon.Close();
            } catch (Exception ex) {
                return -1;
            }
            return temp;
        }

    }
}
