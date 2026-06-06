using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    internal class AccesoDatos
    {
        string rutaBDSucursales = "Data Source=localhost\\sqlexpress; Initial Catalog=BDSucursales;Integrated Security=True";

        public AccesoDatos()
        {

        }

        private SqlConnection ObtenerConexion()
        {
            SqlConnection connection = new SqlConnection(rutaBDSucursales);

            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }

        private SqlDataAdapter ObtenerAdaptador(String consulta, SqlConnection connection)
        {
            SqlDataAdapter adapter;

            try
            {
                adapter = new SqlDataAdapter(consulta, connection);
                return adapter;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }

        public DataTable ObtenerTabla(String tabla, String consulta)
        {
            DataSet dataSet = new DataSet();

            SqlConnection connection = ObtenerConexion();

            SqlDataAdapter adapter = ObtenerAdaptador(consulta, connection);
            adapter.Fill(dataSet, tabla);

            connection.Close();

            return dataSet.Tables[tabla];
        }

        //public int EjecutarProcedimientoAlmacenado(SqlCommand command, String storedProcedure)
        //{
        //    int filasAfectadas;

        //    SqlConnection connection = ObtenerConexion();

        //    command.Connection = connection;
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.CommandText = storedProcedure;

        //    filasAfectadas = command.ExecuteNonQuery();

        //    connection.Close();

        //    return filasAfectadas;
        //}

        public Boolean existe(String consulta)
        {
            Boolean estado = false;

            SqlConnection connection = ObtenerConexion();
            SqlCommand command = new SqlCommand(consulta, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                estado = true;
            }

            return estado;
        }

        //public int ObtenerMaximo(String consulta)
        //{
        //    int max = 0;

        //    SqlConnection connection = ObtenerConexion();
        //    SqlCommand command = new SqlCommand(consulta, connection);
        //    SqlDataReader reader = command.ExecuteReader();

        //    if (reader.Read())
        //    {
        //        max = Convert.ToInt32(reader[0].ToString());
        //    }

        //    return max;
        //}

        public int EjecutarConsulta(string consulta)
        {
            SqlConnection connection = ObtenerConexion();

            SqlCommand command = new SqlCommand(consulta, connection);

            int filas = command.ExecuteNonQuery();

            connection.Close();

            return filas;
        }

    }

}