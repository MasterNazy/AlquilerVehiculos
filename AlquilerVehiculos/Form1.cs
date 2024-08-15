using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquilerVehiculos
{
    public partial class Form1 : Form
    {
        private object dgvVehiculos;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardarVehiculo_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=AlquilerVehiculosDB;Integrated Security=True;";
            string query = "INSERT INTO Vehiculos (marca, modelo, año, disponible) VALUES (@marca, @modelo, @año, @disponible)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@marca", txtMarca.Text);
                    command.Parameters.AddWithValue("@modelo", txtModelo.Text);
                    command.Parameters.AddWithValue("@año", int.Parse(txtAño.Text));
                    command.Parameters.AddWithValue("@disponible", chkDisponible.Checked);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Vehículo guardado exitosamente.");
                }
            }
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=AlquilerVehiculosDB;Integrated Security=True;";
            string query = "INSERT INTO Clientes (nombre, apellido, licencia, telefono) VALUES (@nombre, @apellido, @licencia, @telefono)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@apellido", txtApellido.Text);
                    command.Parameters.AddWithValue("@licencia", txtLicencia.Text);
                    command.Parameters.AddWithValue("@telefono", txtTelefono.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cliente guardado exitosamente.");
                }
            }
        }

        private void btnAbrirClientes_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.Show();
        }

        private void btnAbrirVehiculos_Click(object sender, EventArgs e)
        {
            FormVehiculos formVehiculos = new FormVehiculos();
            formVehiculos.Show();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAlquileres formAlquileres = new FormAlquileres();
            formAlquileres.Show();
        }
    }

   
     
    }
