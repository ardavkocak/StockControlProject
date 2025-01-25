using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Yazlab_3_mu
{
    public partial class Form6 : Form
    { 
        
        public int customerid;
        public Form6(int customerId)
        {
            InitializeComponent();
            customerid = customerId;
           
        }
       
        private void Form6_Load(object sender, EventArgs e)
        {
            loglari_getir(customerid);

        }

        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1234;Database=SistemYonetim";


        private void loglari_getir(int customerId)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                   
                    string query = "SELECT * FROM \"orders\" WHERE customer_id = @customerId";

                    
                    NpgsqlCommand command = new NpgsqlCommand(query, connection);
                    command.Parameters.AddWithValue("@customerId", customerId);

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                   
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }





    }
}
