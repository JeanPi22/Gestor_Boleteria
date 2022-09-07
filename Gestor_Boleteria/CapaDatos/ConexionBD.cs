using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_Boleteria.CapaDatos
{
    class ConexionBD
    {
        /// <summary>
        /// Cadena de conexión para el acceso a la base de datos SQL Server
        /// </summary>
        private SqlConnection Conexion = new
            SqlConnection("server=DUALIDADPC\\SQLEXPRESS; database=Gestor_Boleteria;" +
            "integrated security = true");

        /// <summary>
        /// Abrir la conexión hacia la base de datos
        /// </summary>
        /// <returns></returns>
        public SqlConnection OpenConnection()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        /// <summary>
        /// Cerrar la conexión hacia la base de datos
        /// </summary>
        /// <returns></returns>
        public SqlConnection CloseConnection()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
