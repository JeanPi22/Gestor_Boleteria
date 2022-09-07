using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_Boleteria.CapaDatos
{
    class DALCompra
    {
        private ConexionBD conexion = new ConexionBD();
        SqlCommand comando = new SqlCommand();

        public void CrearCompra(int Id_Venta, int Documento1, int Id_Boleta1, float Total)
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "Insertar_Venta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Venta", Id_Venta);
            comando.Parameters.AddWithValue("@Documento", Documento1);
            comando.Parameters.AddWithValue("@Id_Boleta1", Id_Boleta1);
            comando.Parameters.AddWithValue("@Total", Total);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void LeerDoc (int Documento)
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "LeerDoc";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Venta", Id_Venta);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
    }
}
