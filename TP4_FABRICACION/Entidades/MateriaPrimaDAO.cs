using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MateriaPrimaDAO
    {

        static SqlConnection conexion;
        static SqlCommand comando;
        static SqlDataReader lector;

        static MateriaPrimaDAO()
        {
            MateriaPrimaDAO.conexion = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = Fabricacion;Integrated security = true");
            MateriaPrimaDAO.comando = new SqlCommand();

            MateriaPrimaDAO.comando.CommandType = CommandType.Text;
            comando.Connection = MateriaPrimaDAO.conexion;

        }
        /// <summary>
        /// Obtengo todos los registros de la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<MateriaPrima> SelectMateriaPrima()
        {
            List<MateriaPrima> listaMateriaPrima = new List<MateriaPrima>();

            try
            {
                //string query = "SELECT * FROM 2"; // -> PARA PROBAR LA EXCEPCION
                string query = "SELECT * FROM Materiales";
                comando.CommandText = query;

                if (MateriaPrimaDAO.conexion.State != ConnectionState.Open &&
                    MateriaPrimaDAO.conexion.State != ConnectionState.Connecting)
                {
                    MateriaPrimaDAO.conexion.Open();
                }

                MateriaPrimaDAO.lector = MateriaPrimaDAO.comando.ExecuteReader();

                while (MateriaPrimaDAO.lector.Read())
                {
                    //MateriaPrima nuevaFabricacion = new MateriaPrima();
                    if (lector["Material"].ToString() == "Arrabio")
                    {
                        Arrabio nuevaFabricacion = new Arrabio();
                        MateriaPrimaDAO.AgregarMaterial(listaMateriaPrima, nuevaFabricacion);
                    }
                    else if(lector["Material"].ToString() == "Reciclado")
                    {
                        Reciclado nuevaFabricacion = new Reciclado();
                        MateriaPrimaDAO.AgregarMaterial(listaMateriaPrima, nuevaFabricacion);
                    }
                    else
                    {
                        //HACER EXCEPCION
                    }
                }

            }
            catch (Exception ex)
            {
                listaMateriaPrima = null;
                throw new SqlMensajeExcepcion("No se encontro la tabla en la Base de Datos");
            }
            finally
            {
                if (MateriaPrimaDAO.conexion.State != ConnectionState.Closed)
                {
                    MateriaPrimaDAO.conexion.Close();
                }
            }
            return listaMateriaPrima;
        }
        /// <summary>
        /// Obtiene los registros de la BD y evalua que tipo de material es
        /// </summary>
        /// <param name="materialTipo"></param>
        /// <returns></returns>
        public static List<MateriaPrima> SelectMateriaPrimaRecicladoOArrabio(string materialTipo)
        {
            List<MateriaPrima> listaMateriaPrima = new List<MateriaPrima>();
            string query = "SELECT * FROM Materiales WHERE Material = @material";
            MateriaPrimaDAO.comando.CommandText = query;
            MateriaPrimaDAO.comando.Parameters.AddWithValue("@material", materialTipo);
            try
            {
                if (MateriaPrimaDAO.conexion.State != ConnectionState.Open &&
                    MateriaPrimaDAO.conexion.State != ConnectionState.Connecting)
                {
                    MateriaPrimaDAO.conexion.Open();
                }

                MateriaPrimaDAO.lector = MateriaPrimaDAO.comando.ExecuteReader();

                while (MateriaPrimaDAO.lector.Read())
                {
                    //MateriaPrima nuevaFabricacion = new MateriaPrima();
                    if (lector["Material"].ToString() == "Reciclado")
                    {
                        Reciclado nuevaFabricacion = new Reciclado();
                        MateriaPrimaDAO.AgregarMaterial(listaMateriaPrima, nuevaFabricacion);
                    }
                    else if (lector["Material"].ToString() == "Arrabio")
                    {
                        Arrabio nuevaFabricacion = new Arrabio();
                        MateriaPrimaDAO.AgregarMaterial(listaMateriaPrima, nuevaFabricacion);
                    }
                    else
                    {
                        continue;
                    }
                }

            }
            catch (Exception ex)
            {
                listaMateriaPrima = null;
                throw ex;
            }
            finally
            {
                if (MateriaPrimaDAO.conexion.State != ConnectionState.Closed)
                {
                    MateriaPrimaDAO.conexion.Close();
                }
                MateriaPrimaDAO.comando.Parameters.Clear();
            }
            return listaMateriaPrima;
        }
        /// <summary>
        /// Agrega un material a la lista de MateriaPrima
        /// </summary>
        /// <param name="listaMateriaPrima"></param>
        /// <param name="nuevaFabricacion"></param>
        public static void AgregarMaterial(List<MateriaPrima> listaMateriaPrima, MateriaPrima nuevaFabricacion)
        {
            nuevaFabricacion.Id = (int)lector["Id"];
            nuevaFabricacion.Material = lector["Material"].ToString();
            nuevaFabricacion.Proceso = lector["Proceso"].ToString();
            nuevaFabricacion.Origen = lector["Origen"].ToString();
            nuevaFabricacion.Cantidad = (int)lector["Cantidad"];
            nuevaFabricacion.Calidad = lector["Calidad"].ToString();
            nuevaFabricacion.Color = lector["Color"].ToString();

            listaMateriaPrima.Add(nuevaFabricacion);
        }
        /// <summary>
        /// Modifica la fabricacion recibida por parametro en la tabla de la base de datos
        /// </summary>
        /// <param name="fabricacion"></param>
        /// <returns></returns>
        public static bool UpdateMateriaPrima(MateriaPrima fabricacion)
        {
            bool seModifico = false;
            string consulta = "UPDATE Materiales SET Material=@material, Proceso=@proceso, Origen=@origen, Cantidad=@cantidad, Calidad=@calidad, Color=@color WHERE Id=@id";
            MateriaPrimaDAO.comando.CommandText = consulta;
            MateriaPrimaDAO.comando.Parameters.AddWithValue("@material", fabricacion.Material);
            MateriaPrimaDAO.comando.Parameters.AddWithValue("@proceso", fabricacion.Proceso);
            MateriaPrimaDAO.comando.Parameters.AddWithValue("@origen", fabricacion.Origen);
            MateriaPrimaDAO.comando.Parameters.AddWithValue("@cantidad", fabricacion.Cantidad);
            MateriaPrimaDAO.comando.Parameters.AddWithValue("@calidad", fabricacion.Calidad);
            MateriaPrimaDAO.comando.Parameters.AddWithValue("@color", fabricacion.Color);
            MateriaPrimaDAO.comando.Parameters.AddWithValue("@id", fabricacion.Id);

            try
            {
                if (MateriaPrimaDAO.conexion.State != ConnectionState.Open &&
                    MateriaPrimaDAO.conexion.State != ConnectionState.Connecting)
                {
                    MateriaPrimaDAO.conexion.Open();
                }
                int filasAfectadas = MateriaPrimaDAO.comando.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    seModifico = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (MateriaPrimaDAO.conexion.State != ConnectionState.Closed)
                {
                    MateriaPrimaDAO.conexion.Close();
                }
                MateriaPrimaDAO.comando.Parameters.Clear();
            }
            return seModifico;
        }
        /// <summary>
        /// Inserta la materiaPrima recibida por parametro en la tabla de la base de datos.
        /// </summary>
        /// <param name="fabricacion"></param>
        /// <returns></returns>
        public static bool InsertMateriaPrima(MateriaPrima fabricacion)
        {
            bool seInserto = false;
            string consulta = "INSERT INTO Materiales (Material, Proceso, Origen, Cantidad, Calidad, Color) VALUES(@material, @proceso, @origen, @cantidad, @calidad, @color)";
            MateriaPrimaDAO.comando.CommandText = consulta;
            MateriaPrimaDAO.comando.Parameters.AddWithValue("@material", fabricacion.Material);
            MateriaPrimaDAO.comando.Parameters.AddWithValue("@proceso", fabricacion.Proceso);
            MateriaPrimaDAO.comando.Parameters.AddWithValue("@origen", fabricacion.Origen);
            MateriaPrimaDAO.comando.Parameters.AddWithValue("@cantidad", fabricacion.Cantidad);
            MateriaPrimaDAO.comando.Parameters.AddWithValue("@calidad", fabricacion.Calidad);
            MateriaPrimaDAO.comando.Parameters.AddWithValue("@color", fabricacion.Color);
            try
            {
                if(MateriaPrimaDAO.conexion.State != ConnectionState.Open &&
                    MateriaPrimaDAO.conexion.State != ConnectionState.Connecting)
                {
                    MateriaPrimaDAO.conexion.Open();
                }
                int filasAfectadas = MateriaPrimaDAO.comando.ExecuteNonQuery();
                if(filasAfectadas > 0)
                {
                    seInserto = true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (MateriaPrimaDAO.conexion.State != ConnectionState.Closed)
                {
                    MateriaPrimaDAO.conexion.Close();
                }
                MateriaPrimaDAO.comando.Parameters.Clear();
            }
            return seInserto;
        }
        /// <summary>
        /// Elimina de la BD el material que corresponda con el ID pasado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool DeleteMateriaPrima(int id)
        {
            bool pudeEliminar = false;
            string consulta = "DELETE FROM Materiales WHERE id= @id";
            MateriaPrimaDAO.comando.CommandText = consulta;
            MateriaPrimaDAO.comando.Parameters.AddWithValue("@id", id);

            try
            {
                if (MateriaPrimaDAO.conexion.State != ConnectionState.Open &&
                    MateriaPrimaDAO.conexion.State != ConnectionState.Connecting)
                {
                    MateriaPrimaDAO.conexion.Open();
                }

                int filasAfectadas = MateriaPrimaDAO.comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    pudeEliminar = true;
                }


            }
            catch (Exception e)
            {
                pudeEliminar = false;
                throw e;

            }
            finally
            {
                if (MateriaPrimaDAO.conexion.State != ConnectionState.Closed)
                {
                    MateriaPrimaDAO.conexion.Close();
                }

                MateriaPrimaDAO.comando.Parameters.Clear();

            }
            return pudeEliminar;
        }
    }
    
}
