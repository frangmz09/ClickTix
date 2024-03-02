﻿using ClickTix.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.Conexion
{
     class Sucursal_Controller
    {
        public static List<string> obtenerNombresSucursalesSinAdministrador()
        {
            List<string> nombresSucursales = new List<string>();

            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                ManagerConnection.OpenConnection();

                string query = "SELECT nombre FROM sucursal WHERE nombre <> 'Administradores'";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nombresSucursales.Add(reader.GetString("nombre"));
                        }
                    }
                }

                ManagerConnection.CloseConnection();
            }

            return nombresSucursales;
        }

        public static List<Sucursal> obtenerTodos()
        {
            List<Sucursal> sucursales = new List<Sucursal>();
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                ManagerConnection.OpenConnection();

                string query = "SELECT id,nombre,cuit, direccion, abreviatura FROM sucursal";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Sucursal sucursal = new Sucursal();

                            sucursal.id = reader.GetInt32("id");
                            sucursal.nombre = reader.GetString("nombre");
                            sucursal.cuit= reader.GetString("cuit");
                            sucursal.direccion = reader.GetString("direccion");
                            sucursal.abreviatura = reader.GetString("abreviatura");
                            sucursales.Add(sucursal);
                        }
                    }
                }
                ManagerConnection.CloseConnection();

            }

            return sucursales;
        }

        public static string ObtenerNombreSucursalPorID(int idSucursal)
        {
            string nombreSucursal = "";
            ManagerConnection.OpenConnection();
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                string query = "SELECT nombre FROM sucursal WHERE id = @idSucursal";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@idSucursal", idSucursal);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        nombreSucursal = result.ToString();
                    }
                }
            }
            ManagerConnection.CloseConnection();

            return nombreSucursal;

        }
        public static string ObtenerAbreviaturaSucursalPorIdFuncion(int idFuncion)
        {
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                mysqlConnection.Open();
                string query = "SELECT suc.abreviatura FROM funcion f " +
                               "INNER JOIN sala s ON f.id_sala = s.id " +
                               "INNER JOIN sucursal suc ON suc.id = s.id_sucursal " +
                               "WHERE f.id = @idFuncion;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@idFuncion", idFuncion);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString(); 
                    }
                    else
                    {
                        return "";
                    }
                }
            }
        }

        public static bool ValidarExistenciaAbreviatura(string abv)
        {
            bool existeAbreviatura = false;
            ManagerConnection.OpenConnection();
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                string query = "SELECT COUNT(*) FROM sucursal WHERE abreviatura = @abreviatura";
                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@abreviatura", abv);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    existeAbreviatura = count > 0;
                }
            }
            ManagerConnection.CloseConnection();
            return existeAbreviatura;
        }

        public static bool CrearSucursal(Sucursal sucursal)
        {
            string query = "INSERT INTO sucursal (id, nombre, cuit,direccion, abreviatura) " +
                           "VALUES (@id, @nombre, @cuit,@direccion, @abreviatura)";

            MySqlCommand cmd = new MySqlCommand(query, ManagerConnection.getInstance());
            cmd.Parameters.AddWithValue("@id",ObtenerMaxIdSucursal()+1);
            cmd.Parameters.AddWithValue("@nombre", sucursal.nombre);
            cmd.Parameters.AddWithValue("@cuit", sucursal.cuit);
            cmd.Parameters.AddWithValue("@direccion", sucursal.direccion);
            cmd.Parameters.AddWithValue("@abreviatura", sucursal.abreviatura.ToUpper());

            try
            {
                ManagerConnection.OpenConnection();
                cmd.ExecuteNonQuery();
                
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
            finally
            {
                ManagerConnection.CloseConnection();
            }
        }

        public static int ObtenerMaxIdSucursal()
        {
            int maxId = 0;
            string query = "SELECT MAX(id) FROM sucursal";

            MySqlCommand cmd = new MySqlCommand(query, ManagerConnection.getInstance());

            try
            {
 
                    ManagerConnection.OpenConnection();
                

                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    maxId = Convert.ToInt32(result);
                }

                return maxId;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el máximo ID: " + ex.Message);
            }
            finally
            {

                    ManagerConnection.CloseConnection();
            }
        }

        public static bool ActualizarSucursal(Sucursal sucursal)
        {
            ManagerConnection.OpenConnection();
            string query = "UPDATE sucursal " +
                           "SET nombre = @nombre, cuit = @cuit, direccion = @direccion " +
                           "WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(query, ManagerConnection.getInstance());

            cmd.Parameters.AddWithValue("@id", sucursal.id);
            cmd.Parameters.AddWithValue("@nombre", sucursal.nombre);
            cmd.Parameters.AddWithValue("@cuit", sucursal.cuit);
            cmd.Parameters.AddWithValue("@direccion", sucursal.direccion);

            try
            {
                
                int filasActualizadas = cmd.ExecuteNonQuery();
                

                return filasActualizadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la sucursal: " + ex.Message);
            }
            finally
            {
                ManagerConnection.CloseConnection();
            }
        }

        public static void Sucursal_Load(DataGridView tabla)
        {
            try
            {
                ManagerConnection.OpenConnection();


                string query = "SELECT  id, nombre, cuit,direccion FROM sucursal";

                using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
                {
                    using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                    {

                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dt = new DataTable();


                        adapter.Fill(dt);


                        tabla.DataSource = dt;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            finally
            {
                ManagerConnection.CloseConnection();
            }
            
        }


        public static bool EliminarRegistroSucursal(int id)
        {
            try
            {
                using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
                {
                    ManagerConnection.OpenConnection();
                    string query = "DELETE FROM sucursal WHERE id = @id";

                    using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el registro a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                ManagerConnection.CloseConnection();
            }
        }
        public static int ObtenerIdPorNombre(string nombreSucursal)
        {
            int idSucursal = -1; 

            try
            {
                ManagerConnection.OpenConnection();

                string query = "SELECT id FROM sucursal WHERE nombre = @nombre";

                using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
                {
                    using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombreSucursal);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            idSucursal = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID de la sucursal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ManagerConnection.CloseConnection();
            }

            return idSucursal;
        }




    }
}
