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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void CLIENTES_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }
        private void CargarClientes()
            {
                string connectionString = "Server=localhost\\SQLEXPRESS;Database=AlquilerVehiculosDB;Integrated Security=True;";
                string query = "SELECT cliente_id, nombre, apellido, licencia, telefono FROM Clientes";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable clientesTable = new DataTable();
                    adapter.Fill(clientesTable);

                    dgvClientes.DataSource = clientesTable;
                }
            }

            private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                int clienteId = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value);

                string connectionString = "Server=localhost\\SQLEXPRESS;Database=AlquilerVehiculosDB;Integrated Security=True;";
                string query = "DELETE FROM Clientes WHERE cliente_id = @cliente_id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cliente_id", clienteId);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Cliente eliminado exitosamente.");
                        CargarClientes();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para eliminar.");
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
