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
    public partial class FormVehiculos : Form
    {
        public FormVehiculos()
        {
            InitializeComponent();
        }

        private void FormVehiculos_Load(object sender, EventArgs e)
        {
            CargarVehiculos();
        }

        private void CargarVehiculos()
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=AlquilerVehiculosDB;Integrated Security=True;";
            string query = "SELECT vehiculo_id, marca, modelo, año, disponible FROM Vehiculos";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable vehiculosTable = new DataTable();
                adapter.Fill(vehiculosTable);

                dgvVehiculos.DataSource = vehiculosTable;
            }
        }

       
        private void FormVehiculos_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'alquilerVehiculosDBDataSet.Vehiculos' Puede moverla o quitarla según sea necesario.
            this.vehiculosTableAdapter.Fill(this.alquilerVehiculosDBDataSet.Vehiculos);

        }

        private void btnEliminarVehiculo_Click_1(object sender, EventArgs e)
        {
            if (dgvVehiculos.SelectedRows.Count > 0)
            {
                int vehiculoId = Convert.ToInt32(dgvVehiculos.SelectedRows[0].Cells[0].Value);

                string connectionString = "Server=localhost\\SQLEXPRESS;Database=AlquilerVehiculosDB;Integrated Security=True;";
                string query = "DELETE FROM Vehiculos WHERE vehiculo_id = @vehiculo_id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@vehiculo_id", vehiculoId);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Vehículo eliminado exitosamente.");

                        // Recargar los datos después de la eliminación
                        CargarVehiculos();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un vehículo para eliminar.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form1 formPrincipal = new Form1(); 
            formPrincipal.Show(); 
        }
    }
}
