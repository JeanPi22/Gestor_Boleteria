using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_Boleteria.CapaDatos
{    
    public class DALCompra
    {
        private ConexionBD conexion = new ConexionBD();
        SqlCommand comando = new SqlCommand();

        public void CrearCompra( int cantidad, int idLocalidad)
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "Insertar_Compra";
            comando.CommandType = CommandType.StoredProcedure;
           // comando.Parameters.AddWithValue("@Fecha_Boleta", fecha);
            comando.Parameters.AddWithValue("@Cantidad", cantidad);
            comando.Parameters.AddWithValue("@Id_Localidad", idLocalidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //1
        public void CargarCombo(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "Cargar_Combobox";
            SqlDataReader dr = comando.ExecuteReader();
            
            while (dr.Read())
            {
                comboBox.Items.Add(dr[1].ToString());
            }

            comando.Connection = conexion.CloseConnection();

            comboBox.Items.Insert(0, "Seleccione la tribuna");
            comboBox.SelectedIndex = 0;
        }

        public string[] capturarInfo (string Nombre_Tribuna)
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "Capturar_Info";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre_Tribuna", Nombre_Tribuna);
            //SqlCommand cmd = new SqlCommand("select * from [dbo].[Localidad] where Nombre_Tribuna = '" + Nombre_Tribuna + "'", conexion);
            SqlDataReader dr = comando.ExecuteReader();

            string[] resultado = null;

            while (dr.Read())
            {
                string[] valores =
                {
                    dr[2].ToString(),
                };
                resultado = valores;
            }

            comando.Connection = conexion.CloseConnection();

            return resultado;            
        }
    }
}
