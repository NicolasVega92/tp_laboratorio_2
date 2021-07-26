using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Data
{
    public static class FabricacionDAO
    {
        static SqlConnection conexion;
        static SqlCommand comando;
        static SqlDataReader lector;

        static FabricacionDAO()
        {
            FabricacionDAO.conexion = new SqlConnection("Data Source = .\\SQLEXPRESS; Initial Catalog = Fabricacion;Integrated security = true");
            FabricacionDAO.comando = new SqlCommand();

            FabricacionDAO.comando.CommandType = CommandType.Text;
            comando.Connection = FabricacionDAO.conexion;

        }
        /// <summary>
        /// Obtengo todos los registros de la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<Fabricacion> SelectFabricacion()
        {
            List<Fabricacion> listaFabricacion = new List<Fabricacion>();
            string query = "SELECT * FROM Materiales";
            comando.CommandText = query; 
            
            try
            {
                if( FabricacionDAO.conexion.State != ConnectionState.Open &&
                    FabricacionDAO.conexion.State != ConnectionState.Connecting)
                {
                    FabricacionDAO.conexion.Open();
                }

                FabricacionDAO.lector = FabricacionDAO.comando.ExecuteReader();

                while(FabricacionDAO.lector.Read())
                {
                    Fabricacion nuevaFabricacion = new Fabricacion();
                    nuevaFabricacion.Id = (int)lector["Id"];
                    nuevaFabricacion.Material = lector["Material"].ToString();
                    nuevaFabricacion.Proceso = lector["Proceso"].ToString();
                    nuevaFabricacion.Origen = lector["Origen"].ToString();
                    nuevaFabricacion.Cantidad = (int)lector["Cantidad"];
                    nuevaFabricacion.Calidad = lector["Calidad"].ToString();
                    nuevaFabricacion.Color = lector["Color"].ToString();

                    listaFabricacion.Add(nuevaFabricacion);
                }

            }
            catch (Exception ex)
            {
                listaFabricacion = null;
                throw ex;
            }
            finally
            {
                if(FabricacionDAO.conexion.State != ConnectionState.Closed)
                {
                    FabricacionDAO.conexion.Close();
                }
            }
            return listaFabricacion;
        }
        /// <summary>
        /// Modifica la fabricacion recibida por parametro en la tabla de la base de datos
        /// </summary>
        /// <param name="fabricacion"></param>
        /// <returns></returns>
        public static bool UpdateFabricacion(Fabricacion fabricacion)
        {
            bool seModifico = false;
            string consulta = "UPDATE Materiales SET Material=@material, Proceso=@proceso, Origen=@origen, Cantidad=@cantidad, Calidad=@calidad, Color=@color WHERE Id=@id";
            FabricacionDAO.comando.CommandText = consulta;
            FabricacionDAO.comando.Parameters.AddWithValue("@material", fabricacion.Material);
            FabricacionDAO.comando.Parameters.AddWithValue("@proceso", fabricacion.Proceso);
            FabricacionDAO.comando.Parameters.AddWithValue("@origen", fabricacion.Origen);
            FabricacionDAO.comando.Parameters.AddWithValue("@cantidad", fabricacion.Cantidad);
            FabricacionDAO.comando.Parameters.AddWithValue("@calidad", fabricacion.Calidad);
            FabricacionDAO.comando.Parameters.AddWithValue("@color", fabricacion.Color);
            FabricacionDAO.comando.Parameters.AddWithValue("@id", fabricacion.Id);

            try
            {
                if( FabricacionDAO.conexion.State != ConnectionState.Open &&
                    FabricacionDAO.conexion.State != ConnectionState.Connecting)
                {
                    FabricacionDAO.conexion.Open();
                }
                int filasAfectadas = FabricacionDAO.comando.ExecuteNonQuery();
                if(filasAfectadas > 0)
                {
                    seModifico = true;
                }
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(FabricacionDAO.conexion.State != ConnectionState.Closed)
                {
                    FabricacionDAO.conexion.Close();
                }
                FabricacionDAO.comando.Parameters.Clear();
            }
            return seModifico;
        }
    }
}
