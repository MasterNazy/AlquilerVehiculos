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
    public partial class FormAlquileres : Form
    {
        public FormAlquileres()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CargarAlquileres();
            CargarClientes();
            CargarVehiculos();
            

        }
        private void CargarAlquileres()
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=AlquilerVehiculosDB;Integrated Security=True;";
            string query = "SELECT alquiler_id, vehiculo_id, cliente_id, fecha_inicio, fecha_fin FROM Alquileres";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable alquileresTable = new DataTable();
                adapter.Fill(alquileresTable);

                dgvAlquileres.DataSource = alquileresTable;
            }
        }

        private void CargarClientes()
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=AlquilerVehiculosDB;Integrated Security=True;";
            string query = "SELECT cliente_id, nombre + ' ' + apellido AS nombre_completo FROM Clientes";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable clientesTable = new DataTable();
                adapter.Fill(clientesTable);

                cbClientes.DataSource = clientesTable;
                cbClientes.DisplayMember = "nombre_completo";
                cbClientes.ValueMember = "cliente_id";
            }
        }

        private void CargarVehiculos()
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=AlquilerVehiculosDB;Integrated Security=True;";
            string query = "SELECT vehiculo_id, marca + ' ' + modelo AS vehiculo FROM Vehiculos WHERE disponible = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable vehiculosTable = new DataTable();
                adapter.Fill(vehiculosTable);

                cbVehiculos.DataSource = vehiculosTable;
                cbVehiculos.DisplayMember = "vehiculo";
                cbVehiculos.ValueMember = "vehiculo_id";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formPrincipal = new Form1();
            formPrincipal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=AlquilerVehiculosDB;Integrated Security=True;";
            string query = "INSERT INTO Alquileres (vehiculo_id, cliente_id, fecha_inicio, fecha_fin) VALUES (@vehiculo_id, @cliente_id, @fecha_inicio, @fecha_fin)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@vehiculo_id", cbVehiculos.SelectedValue);
                    command.Parameters.AddWithValue("@cliente_id", cbClientes.SelectedValue);
                    command.Parameters.AddWithValue("@fecha_inicio", dtpFechaInicio.Value);
                    command.Parameters.AddWithValue("@fecha_fin", dtpFechaFin.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Alquiler guardado exitosamente.");
                    CargarAlquileres();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvAlquileres.SelectedRows.Count > 0)
            {
                int alquilerId = Convert.ToInt32(dgvAlquileres.SelectedRows[0].Cells[0].Value);

                string connectionString = "Server=localhost\\SQLEXPRESS;Database=AlquilerVehiculosDB;Integrated Security=True;";
                string query = "DELETE FROM Alquileres WHERE alquiler_id = @alquiler_id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@alquiler_id", alquilerId);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Alquiler eliminado exitosamente.");

                        // Recargar los datos después de la eliminación
                        CargarAlquileres();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un alquiler para eliminar.");
            }
        }
    }
}


