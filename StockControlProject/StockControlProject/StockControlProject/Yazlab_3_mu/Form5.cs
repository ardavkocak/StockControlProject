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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        public static class CurrentUser
        {
            public static string Username { get; set; }
        }


        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1234;Database=SistemYonetim";




        private int kullanici_giris_kontrol()
        {
            string query = "SELECT customer_name, password FROM customer";

            string admin_ad = admin_ad_text.Text;  
            string sifre = admin_sifre_text.Text;  

          
            decimal kontrol_sifre = decimal.Parse(sifre);

           
            int result = 0;

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

               
                using (var command = new NpgsqlCommand(query, connection))
                {
                    
                    using (var reader = command.ExecuteReader())
                    {
                        
                        while (reader.Read())
                        {
                            string admin_name = reader["customer_name"].ToString();  
                            decimal admin_password = reader.GetDecimal(reader.GetOrdinal("password")); //  

                            
                            if (admin_name == admin_ad && admin_password == kontrol_sifre)
                            {
                                CurrentUser.Username = admin_name; 
                                result = 1;
                                break;
                            }


                        }
                    }
                }
            }

            return result;
        }

        private void kullanici_giris_button_Click(object sender, EventArgs e)
        {
            string adminAd = admin_ad_text.Text; 

            if (kullanici_giris_kontrol() == 1)
            {
                Form2 orderForm = new Form2(adminAd); 
                orderForm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre.\nLütfen tekrar deneyin");
            }
        }

    }
}
