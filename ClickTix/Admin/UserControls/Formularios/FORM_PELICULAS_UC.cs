﻿using ClickTix.Conexion;
using ClickTix.Controller;
using ClickTix.Modelo;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Storage;
using System.Net;
using ClickTix.Admin.UserControls.Formularios;

namespace ClickTix.UserControls
{
    public partial class FORM_PELICULAS_UC : UserControl
    {

        private int idDelPanel;
        Image ImagenCargada;
        private string extensionAntigua = "";
        private string rutaAntigua = "";

        public FORM_PELICULAS_UC()
        {
            InitializeComponent();

            LlenarComboBoxClasificacion();
            LlenarComboBoxCategoria();

            this.addpelicula_btn.Click += new System.EventHandler(this.Addpelicula_btn_Click);

        }

        public FORM_PELICULAS_UC(Pelicula peliculaAPI)
        {
            InitializeComponent();
            LlenarComboBoxClasificacion();
            LlenarComboBoxCategoria();


            this.addpelicula_btn.Click += new System.EventHandler(this.Addpelicula_btn_ClickAPI);

            try
            {
                string rutaImagen = "http://image.tmdb.org/t/p/w500" + peliculaAPI.imagen;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(rutaImagen);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                {
                    Image imagen = Image.FromStream(stream);
                    pictureBox1.Image = imagen;

                    string filePath = peliculaAPI.imagen;
                    string fileExtension = Path.GetExtension(filePath);

                    pictureBox1.Tag = fileExtension;

                    extensionAntigua = fileExtension;
                    rutaAntigua = rutaImagen;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar la imagen: {ex.Message}");
            }

            input_titulo.Text = peliculaAPI.titulo;
            input_descripcion.Text = peliculaAPI.descripcion;

            if (DateTime.TryParse(peliculaAPI.fEstreno.ToString(), out DateTime fechaEstreno))
            {
                input_estreno.Value = fechaEstreno;
            }

        }




        public FORM_PELICULAS_UC(int id)
        {
            this.idDelPanel = id;

            int peliculaID = id;
            InitializeComponent();
            LlenarComboBoxClasificacion();
            LlenarComboBoxCategoria();
            button1.Visible = false;
            addpelicula_btn.Click += new EventHandler(this.Addpelicula_btn_Click2);
            addpelicula_btn.Text = "Modificar";
            this.title.Text = "INGRESE DATOS PARA ACTUALIZAR UNA PELICULA";

          

            try
            {

                string rutaImagen = Pelicula_Controller.obtenerFileName(peliculaID);

                using (WebClient webClient = new WebClient())
                {
                    byte[] data = webClient.DownloadData(rutaImagen);
                    using (MemoryStream mem = new MemoryStream(data))
                    {
                        Image imagen = Image.FromStream(mem);
                        pictureBox1.Image = imagen;

                    }
                }

                //if (File.Exists(rutaImagen))
                //{
                //    extensionAntigua = Path.GetExtension(rutaImagen);
                //    rutaAntigua = rutaImagen;
                //    ImagenCargada = Image.FromFile(rutaImagen);
                //    pictureBox1.Image = ImagenCargada;
                //    pictureBox1.Tag = Path.GetExtension(rutaImagen);

                //}
            }
            catch {
                
            }
            CargarDatosPelicula(peliculaID);


        }

        

        private void FORM_PELICULAS_UC_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void Addpelicula_btn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(input_titulo.Text) || string.IsNullOrWhiteSpace(input_director.Text)
                || input_duracion.Value <= 0 || string.IsNullOrWhiteSpace(input_descripcion.Text)
                || string.IsNullOrWhiteSpace(input_genero.Text) || string.IsNullOrWhiteSpace(input_clasificacion.Text)
                || string.IsNullOrWhiteSpace(input_estreno.Text))
            {
                MessageBox.Show("Los campos deben estar llenos ");
            }
            else
            {
                int id = GetMaxID() + 1;
                int idGenero = ObtenerIdGenero(input_genero.Text);
                int idCategoria = ObtenerIdClasificacion(input_clasificacion.Text);


                string rutaDeGuardadoFirebase = await guardarImagen();

                InsertarPelicula(id, input_titulo.Text, input_director.Text, input_duracion.Value, input_descripcion.Text, idGenero, idCategoria, rutaDeGuardadoFirebase, input_estreno.Value);
                ABM_PELICULAS_UC abmpeliculas = new ABM_PELICULAS_UC();
                Index_Admin.addUserControl(abmpeliculas);

            }




        }

        private async void Addpelicula_btn_ClickAPI(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(input_titulo.Text) || string.IsNullOrWhiteSpace(input_director.Text)
                || input_duracion.Value <= 0 || string.IsNullOrWhiteSpace(input_descripcion.Text)
                || string.IsNullOrWhiteSpace(input_genero.Text) || string.IsNullOrWhiteSpace(input_clasificacion.Text)
                || string.IsNullOrWhiteSpace(input_estreno.Text))
            {
                MessageBox.Show("Los campos deben estar llenos ");
            }
            else
            {
                int id = GetMaxID() + 1;
                int idGenero = ObtenerIdGenero(input_genero.Text);
                int idCategoria = ObtenerIdClasificacion(input_clasificacion.Text);


                string rutaDeGuardadoFirebase = await guardarImagenAPI();

                InsertarPelicula(id, input_titulo.Text, input_director.Text, input_duracion.Value, input_descripcion.Text, idGenero, idCategoria, rutaDeGuardadoFirebase, input_estreno.Value);
                ABM_PELICULAS_UC abmpeliculas = new ABM_PELICULAS_UC();
                Index_Admin.addUserControl(abmpeliculas);

            }




        }
        private async void Addpelicula_btn_Click2(object sender, EventArgs e)
        {



            if (string.IsNullOrWhiteSpace(input_titulo.Text) || string.IsNullOrWhiteSpace(input_director.Text)
                || input_duracion.Value <= 0 || string.IsNullOrWhiteSpace(input_descripcion.Text)
                || string.IsNullOrWhiteSpace(input_genero.Text) || string.IsNullOrWhiteSpace(input_clasificacion.Text)
                || string.IsNullOrWhiteSpace(input_estreno.Text))
            {
                MessageBox.Show("Los campos deben estar llenos ");
            }
            else
            {
                int idGenero = ObtenerIdGenero(input_genero.Text);
                int idCategoria = ObtenerIdClasificacion(input_clasificacion.Text);
                int idpelicula = idDelPanel;
                Trace.WriteLine(extensionAntigua);
                string rutaDeGuardadoFirebase = await guardarImagen();

                ActualizarPelicula(idpelicula, input_titulo.Text, input_director.Text, input_duracion.Value, input_descripcion.Text, idGenero, idCategoria, rutaDeGuardadoFirebase, input_estreno.Value);
                Trace.WriteLine("la ruta es:" + rutaAntigua);

                ABM_PELICULAS_UC abmpeliculas = new ABM_PELICULAS_UC();
                Index_Admin.addUserControl(abmpeliculas);
            }


        }
        private void input_genero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void input_clasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {


        }






        private bool InsertarPelicula(int id, string titulo, string director, decimal duracion, string descripcion, int categoria, int clasificacion, string portada, DateTime fechaEstreno)
        {



            try
            {

                string consulta = "INSERT INTO pelicula (id,titulo, director, duracion,descripcion, id_categoria, id_clasificacion, portada, fecha_estreno, esta_activa) " +
                                  "VALUES (@id,@titulo, @director, @duracion,@descripcion ,@categoria, @clasificacion, @portada, @fechaEstreno, 1)";
                ManagerConnection.OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(consulta, ManagerConnection.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.Parameters.AddWithValue("@director", director);
                    cmd.Parameters.AddWithValue("@duracion", duracion);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    cmd.Parameters.AddWithValue("@clasificacion", clasificacion);
                    cmd.Parameters.AddWithValue("@portada", portada);
                    cmd.Parameters.AddWithValue("@fechaEstreno", fechaEstreno);

                    cmd.ExecuteNonQuery();

                    return true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la película: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                ManagerConnection.CloseConnection();
            }

        }






        private void back_pelicula_Click(object sender, EventArgs e)
        {
            ABM_PELICULAS_UC abmpeliculas = new ABM_PELICULAS_UC();
            Index_Admin.addUserControl(abmpeliculas);
        }

        public int GetMaxID()
        {
            int maxID = -1;


            try
            {
                ManagerConnection.OpenConnection();

                string query = "SELECT MAX(id) FROM pelicula";

                MySqlCommand command = new MySqlCommand(query, ManagerConnection.getInstance());
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    maxID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener el ID máximo: " + ex.Message);
            }
            ManagerConnection.CloseConnection();


            return maxID;
        }

        private bool ActualizarPelicula(int idParaActualizar, string titulo, string director, decimal duracion, string descripcion, int categoria, int clasificacion, string portada, DateTime fechaEstreno)
        {
            try
            {


                string consulta = "UPDATE pelicula SET titulo = @titulo, director = @director, duracion = @duracion, descripcion = @descripcion, id_categoria = @categoria, id_clasificacion = @clasificacion, portada = @portada, fecha_estreno = @fechaEstreno WHERE id = @idParaActualizar";

                ManagerConnection.OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(consulta, ManagerConnection.getInstance()))
                {
                    Trace.WriteLine(idParaActualizar);
                    cmd.Parameters.AddWithValue("@idParaActualizar", idParaActualizar);
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.Parameters.AddWithValue("@director", director);
                    cmd.Parameters.AddWithValue("@duracion", duracion);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    cmd.Parameters.AddWithValue("@clasificacion", clasificacion);
                    cmd.Parameters.AddWithValue("@portada", portada);
                    cmd.Parameters.AddWithValue("@fechaEstreno", fechaEstreno);

                    int filasActualizadas = cmd.ExecuteNonQuery();
                    ManagerConnection.CloseConnection();
                    if (filasActualizadas > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún registro para actualizar.");
                        return false;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                return false;
            }

        }


        private void CargarDatosPelicula(int peliculaID)
        {
            try
            {

                string consulta = "SELECT titulo, director, duracion, descripcion, id_categoria, id_clasificacion, portada, fecha_estreno FROM pelicula WHERE id = @id";


                ManagerConnection.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(consulta, ManagerConnection.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@id", peliculaID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            input_titulo.Text = reader["titulo"].ToString();
                            input_director.Text = reader["director"].ToString();
                            input_duracion.Value = Convert.ToDecimal(reader["duracion"]);
                            input_descripcion.Text = reader["descripcion"].ToString();

                            if (DateTime.TryParse(reader["fecha_estreno"].ToString(), out DateTime fechaEstreno))
                            {
                                input_estreno.Value = fechaEstreno;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la película con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la película: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ManagerConnection.CloseConnection();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void addimage_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccionar una imagen";
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png\"";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                ImagenCargada = Image.FromFile(openFileDialog.FileName);
                pictureBox1.Image = ImagenCargada;
                pictureBox1.Tag = Path.GetExtension(openFileDialog.FileName);
            }


        }
       

        private async Task<string> guardarImagen()
{
    try
    {
        long timestamp = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

        string rutaDeGuardado = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources\\img\\peliculas\\" + timestamp);

        string extension = pictureBox1.Tag.ToString();

        if (string.IsNullOrEmpty(extension) || !extension.StartsWith("."))
        {
            Console.WriteLine("Extensión de archivo no válida.");
            return "";
        }

        string fileName = timestamp + extension;

        string rutaCompleta = rutaDeGuardado + extension;

        Trace.WriteLine(rutaCompleta);

        ImagenCargada.Save(rutaCompleta);

        FirebaseStorageManager uploader = new FirebaseStorageManager();


        string urlImagen =      await uploader.SubirImagenAsync(rutaCompleta, fileName);
                Trace.WriteLine(urlImagen);

                return urlImagen;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error al subir la imagen a Firebase Storage: {ex.Message}");
        return "";
    }
}


        private async Task<string> guardarImagenAPI()
        {
            try
            {
                long timestamp = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

                string rutaDeGuardado = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources\\img\\peliculas\\" + timestamp);

                string extension = pictureBox1.Tag.ToString();

                if (string.IsNullOrEmpty(extension) || !extension.StartsWith("."))
                {
                    Console.WriteLine("Extensión de archivo no válida.");
                    return "";
                }

                string fileName = timestamp + extension;

                string rutaCompleta = rutaDeGuardado + extension;

                Trace.WriteLine(rutaCompleta);
                try
                {
                    if (pictureBox1.Image != null)
                    {
                       
                        pictureBox1.Image.Save(rutaCompleta);
                    }
                    else
                    {
                        Console.WriteLine("La imagen en el PictureBox es nula.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al guardar la imagen: {ex.Message}");
                }
                FirebaseStorageManager uploader = new FirebaseStorageManager();


                string urlImagen = await uploader.SubirImagenAsync(rutaCompleta, fileName);
                Trace.WriteLine(urlImagen);

                return urlImagen;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al subir la imagen a Firebase Storage: {ex.Message}");
                return "";
            }
        }



        private void LlenarComboBoxClasificacion()
        {
            try
            {
                ManagerConnection.OpenConnection();
                string consultaSucursales = "SELECT id, clasificacion FROM clasificacion";

                using (MySqlCommand cmdSucursales = new MySqlCommand(consultaSucursales, ManagerConnection.getInstance()))
                {
                    DataTable dt = new DataTable();
                    dt.Load(cmdSucursales.ExecuteReader());


                    input_clasificacion.DataSource = dt;


                    input_clasificacion.DisplayMember = "clasificacion";


                    //input_sucursal.ValueMember = "id";


                    //input_sucursal.SelectedValue = idSucursalSeleccionada;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox de clasificacion de pelcula: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ManagerConnection.CloseConnection();
            }
        }





        private void LlenarComboBoxCategoria()
        {
            try
            {
                ManagerConnection.OpenConnection();
                string consultaSucursales = "SELECT id, nombre FROM categoria";

                using (MySqlCommand cmdSucursales = new MySqlCommand(consultaSucursales, ManagerConnection.getInstance()))
                {
                    DataTable dt = new DataTable();
                    dt.Load(cmdSucursales.ExecuteReader());


                    input_genero.DataSource = dt;


                    input_genero.DisplayMember = "nombre";


                    //input_sucursal.ValueMember = "id";


                    //input_sucursal.SelectedValue = idSucursalSeleccionada;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox de categoria de pelcula: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ManagerConnection.CloseConnection();
            }
        }




        public static int ObtenerIdGenero(string nombreCategoria)
        {
            int idCategoria = -1;

            try
            {
                ManagerConnection.OpenConnection();
                using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
                {
                    string query = "SELECT id FROM categoria WHERE nombre = @nombre";

                    using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombreCategoria);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            idCategoria = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID de la categoria de pelicula: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ManagerConnection.CloseConnection();
            }

            return idCategoria;
        }






        public static int ObtenerIdClasificacion(string nombreClasificacion)
        {
            int idClasificacion = -1;

            try
            {
                using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
                {
                    mysqlConnection.Open();
                    string query = "SELECT id FROM clasificacion WHERE clasificacion = @clasificacion";

                    using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                    {
                        command.Parameters.AddWithValue("@clasificacion", nombreClasificacion);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            idClasificacion = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID de la clasificacion de pelicula: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ManagerConnection.CloseConnection();

            return idClasificacion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FORM_API_PELICULAS formApiPeliculas = new FORM_API_PELICULAS();
            Index_Admin.addUserControl(formApiPeliculas);
        }
    }
}






