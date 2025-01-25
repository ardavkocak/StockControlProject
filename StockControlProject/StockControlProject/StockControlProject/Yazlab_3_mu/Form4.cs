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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            loglari_getir();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; 
            dataGridView1.Columns["log_details"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 

          
            this.Resize += (s, args) =>
            {
                dataGridView1.Columns["log_details"].Width = dataGridView1.Width;
            };

        }

        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1234;Database=SistemYonetim";


        private void loglari_getir()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();


                    string query = "SELECT * FROM \"log\"";

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
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
