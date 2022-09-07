using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_Boleteria.CapaDatos
{
    public class DALUsuarios
    {
        private ConexionBD conexion = new ConexionBD();
        SqlCommand comando = new SqlCommand();

        public void CrearUsuario(int documento, string nombre, string correo, string clave)
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "Insertar_Usuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Documento", documento);
            comando.Parameters.AddWithValue("@Nombres_Apellidos", nombre);
            comando.Parameters.AddWithValue("@Correo", correo);
            comando.Parameters.AddWithValue("@Clave", clave);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void LeerUsuario(int documento, string clave)
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "Leer_Usuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Documento", documento); 

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        
    }
}
