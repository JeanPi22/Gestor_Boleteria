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
        //Cadena de conexión para el acceso a la base de datos SQL Server   
        private SqlConnection Conexion = new
            SqlConnection("server=DUALIDADPC\\SQLEXPRESS; database=Gestor_Boleteria;" +
            "integrated security = true");

       // Abrir la conexión hacia la base de datos       
        public SqlConnection OpenConnection()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        // Cerrar la conexión hacia la base de datos       
        public SqlConnection CloseConnection()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
