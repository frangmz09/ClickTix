﻿using ClickTix.Conexion;
using ClickTix.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.Empleado.UserControls
{
    public partial class BUTACAS_UC : UserControl
    {
        private int idPelicula;
        private int idFuncion;

        public BUTACAS_UC(int id_funcion, int idPeli)
        {
            this.idFuncion = id_funcion;
            this.idPelicula = idPeli;
            InitializeComponent();
            llenarButacas(id_funcion);
        }

        private void BUTACAS_UC_Load(object sender, EventArgs e)


        {
        }

        private void llenarButacas(int id_funcion)
        {
            Trace.WriteLine(id_funcion);
            flowLayoutPanel1.Controls.Clear();
            int numFilas = 0;
            int numColumnas = 0;
            MyConexion c = new MyConexion("localhost", "clicktix", "root", "");

            using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
            {
                mysqlConnection.Open();
                string query = "select filas, columnas from sala s inner join funcion f on f.id_sala = s.id inner join asiento a on f.id = a.id_funcion where f.id = @id_funcion;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@id_funcion", id_funcion);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        numFilas = reader.GetInt32(0);
                        numColumnas = reader.GetInt32(1);
                    }

                    Trace.WriteLine(numFilas);
                    Trace.WriteLine(numColumnas);

                    reader.Close();
                    mysqlConnection.Close();

                    List<Asiento> list = new List<Asiento>();
                    list = Asiento_Controller.obtenerPorFuncion(id_funcion);
                    Image imagenButaca = Properties.Resources.butaca;

                    int columnCount = 0;
                    
                    FlowLayoutPanel currentRowPanel = new FlowLayoutPanel();
                    currentRowPanel.FlowDirection = FlowDirection.LeftToRight;
                    currentRowPanel.Width = flowLayoutPanel1.Width;
                    currentRowPanel.Height = 30;


                    foreach (Asiento asiento in list)
                    {
                        Button butaca = new Button();
                        butaca.Width = 25;
                        butaca.Height = 25;
                        butaca.Name = $"btnButaca_{asiento.Fila} _ {asiento.Columna}";
                        butaca.BackgroundImage = imagenButaca;
                        butaca.BackgroundImageLayout = ImageLayout.Stretch;

                        butaca.BackColor = Color.LightGray;
                        butaca.Margin = new Padding(5);

                        if (asiento.Disponible == false)
                        {
                            butaca.BackColor = Color.Red;
                            butaca.Enabled = false;
                        }
                        butaca.Click += Butaca_Click;
                        butaca.Anchor = AnchorStyles.None;

                        currentRowPanel.Controls.Add(butaca);
                        columnCount++;

                        if (columnCount == numColumnas)
                        {
                            flowLayoutPanel1.Controls.Add(currentRowPanel);

                            columnCount = 0;
                            currentRowPanel = new FlowLayoutPanel();
                            currentRowPanel.FlowDirection = FlowDirection.LeftToRight;
                            currentRowPanel.Width = flowLayoutPanel1.Width;
                            currentRowPanel.Height = 30;
                        }
                    }

                    if (currentRowPanel.Controls.Count > 0)
                    {
                        flowLayoutPanel1.Controls.Add(currentRowPanel);
                    }
                }
            }
        }
        private void Butaca_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton.BackColor == Color.LightGray)
            {
                clickedButton.BackColor = Color.Green; 
            }
            else
            {
                clickedButton.BackColor = Color.LightGray; 
            }
        }

        private void confirmar_asiento_Click(object sender, EventArgs e)
        {
            TICKET_UC tICKET_UC = new TICKET_UC(idFuncion,1,1);
            Index_User.addUserControlUsuario(tICKET_UC);
           
        }
    }
}
