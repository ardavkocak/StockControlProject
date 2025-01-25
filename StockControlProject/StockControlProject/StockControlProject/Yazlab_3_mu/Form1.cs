using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;
using Npgsql; // PostgreSQL bağlantısı için kütüphane
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace Yazlab_3_mu
{
    public partial class Form1 : Form
    {
        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1234;Database=SistemYonetim";

        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            //RastgeleKullaniciEkle();


        }



        private void RastgeleKullaniciEkle()
        {
            try
            {
                // Rastgele sayı oluşturmak için
                Random random = new Random();

                int toplamKullaniciSayisi = random.Next(5, 11); // 5 ile 10 arasında rastgele sayı

                List<string> isimler = new List<string> { "Ahmet", "Ayşe", "Arda", "Halit", "Asya", "Burak", "Hasan", "Elif", "Osman", "Seda" };

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    for (int i = 0; i < toplamKullaniciSayisi; i++)
                    {
                        // Rastgele isim seçimi
                        string customerName = isimler[random.Next(isimler.Count)] + " " + (char)('A' + random.Next(0, 26)) + ".";
                        decimal budget = random.Next(500, 3001); // 500-3000 arasında rastgele bütçe ayarlıyoz
                        string customerType = i < 2 ? "premium" : "normal"; 
                        decimal totalSpent = 0; 

                        // SQL sorgusu
                        string query = "INSERT INTO \"customer\" (\"customer_name\", \"budget\", \"customer_type\", \"total_spent\") " +
                                       "VALUES (@Customer_name, @Budget, @Customer_type, @TotalSpent)";

                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            // Parametreleri ekle
                            command.Parameters.AddWithValue("@Customer_name", customerName);
                            command.Parameters.AddWithValue("@Budget", budget);
                            command.Parameters.AddWithValue("@Customer_type", customerType);
                            command.Parameters.AddWithValue("@TotalSpent", totalSpent);

                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show($"{toplamKullaniciSayisi} rastgele kullanıcı başarıyla eklendi.");
                }

              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

 
public class GradientGroupBox : GroupBox
    {
        public Color StartColor { get; set; } = Color.LightBlue;
        public Color EndColor { get; set; } = Color.White;

        protected override void OnPaint(PaintEventArgs e)
        {
            // Arka plan için gradyan fırçası oluştur
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, StartColor, EndColor, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            // Çerçeve ve başlık çizimi
            using (Pen pen = new Pen(this.ForeColor))
            {
                SizeF textSize = e.Graphics.MeasureString(this.Text, this.Font);
                Rectangle borderRect = new Rectangle(0, (int)textSize.Height / 2, this.Width - 1, this.Height - (int)textSize.Height / 2 - 1);

                e.Graphics.DrawRectangle(pen, borderRect);
                e.Graphics.FillRectangle(new SolidBrush(this.BackColor), new Rectangle(6, 0, (int)textSize.Width, (int)textSize.Height));
                e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), new PointF(6, 0));
            }
        }
}

        private int admin_giris_kontrol()
        {
            string query = "SELECT admin_name, admin_password FROM admin";

            string admin_ad = admin_ad_text.Text;  
            string sifre = admin_sifre_text.Text;  

            
            decimal kontrol_sifre = decimal.Parse(sifre);

           
            int result = 0;

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Komut oluştur
                using (var command = new NpgsqlCommand(query, connection))
                {
                    
                    using (var reader = command.ExecuteReader())
                    {
                        
                        while (reader.Read())
                        {
                            string admin_name = reader["admin_name"].ToString(); 
                            decimal admin_password = reader.GetDecimal(reader.GetOrdinal("admin_password")); 

                            
                            if (admin_name == admin_ad && admin_password == kontrol_sifre)
                            {
                                result = 1;  
                                break;  
                            }
                        }
                    }
                }
            }

            // Sonucu döndürüyok 1 başarılı, 0 başarısız
            return result;
        }




        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            Form5 orderForm = new Form5();
            orderForm.Show();

        }

        private void admin_giris_button_Click(object sender, EventArgs e)
        {
            if (admin_giris_kontrol()==1)
            {
                Form3 orderForm = new Form3();
                orderForm.Show();

            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre.\n" +
                    "Lütfen tekrar deneyin");
            }

        }
    }
}
