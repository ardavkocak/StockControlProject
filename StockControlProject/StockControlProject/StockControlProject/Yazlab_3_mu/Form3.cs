using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Timers;
namespace Yazlab_3_mu
{
    public partial class Form3 : Form
    {

        public static bool admin_islem { get; private set; } = false;

        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1234;Database=SistemYonetim";
        private System.Windows.Forms.Timer timer;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Urunleri_checkboxlarda_goster();
            Kullanicilari_checkboxlarda_goster();
            Urunleri_getir();
            SiparisleriGetir();
            duzenlenecek_urunleri_goster();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Her 1 saniyede bir çalışacak (1000 ms)
            timer.Tick += Timer_Tick;
            timer.Start(); 

        }



        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                PriorityScoreHesapla(); 
                SiparisleriGetir(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }
        }
        private void product_ekle()
        {
            try
            {
                string productname = txtproductName.Text;
                decimal price = pricenumeric.Value;
                decimal stock = stocknumeric.Value;

                if (string.IsNullOrWhiteSpace(productname) || price <= 0 || stock <= 0)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();


                    string query = "INSERT INTO \"product\" (\"product_name\", \"stock\", \"price\") VALUES (@Product_name, @Stock, @Price)";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Product_name", productname);
                        command.Parameters.AddWithValue("@Stock", stock);
                        command.Parameters.AddWithValue("@Price", price);


                        int rowsAffected = command.ExecuteNonQuery();


                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ürün Başarıyla Eklendi");
                            Urunleri_getir();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı eklenemedi.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }



       




        private void Urunleri_getir()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();


                    string query = "SELECT * FROM \"product\"";

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






        private void Kullanicilari_checkboxlarda_goster()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT customer_id, customer_name, customer_type, budget FROM \"customer\""; 
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            silinecek_kullanicilar.Items.Clear(); 
                            while (reader.Read())
                            {
                               
                                string displayText = $"ID: {reader["customer_id"]} - Name: {reader["customer_name"]} - Type: {reader["customer_type"]} - Budget: {reader["budget"]}";
                                silinecek_kullanicilar.Items.Add(displayText);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void Urunleri_checkboxlarda_goster()
        {
               
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT product_name FROM \"product\""; 
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                               
                                silinecek_urunler.Items.Add(reader["product_name"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }



        private void Kullanicilari_sil()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (var item in silinecek_kullanicilar.CheckedItems)
                    {
                        
                        string displayText = item.ToString();
                        string[] parts = displayText.Split('-'); 
                        string customerName = parts[1].Replace("Name:", "").Trim();

                        
                        string getIdQuery = "SELECT customer_id FROM \"customer\" WHERE customer_name = @CustomerName";
                        int customerId;
                        using (NpgsqlCommand getIdCommand = new NpgsqlCommand(getIdQuery, connection))
                        {
                            getIdCommand.Parameters.AddWithValue("@CustomerName", customerName);
                            object result = getIdCommand.ExecuteScalar();
                            if (result == null)
                            {
                                MessageBox.Show($"Kullanıcı '{customerName}' bulunamadı.");
                                continue;
                            }
                            customerId = Convert.ToInt32(result);
                        }

                        
                        string deleteLogsQuery = "DELETE FROM \"log\" WHERE customer_id = @CustomerId";
                        using (NpgsqlCommand deleteLogsCommand = new NpgsqlCommand(deleteLogsQuery, connection))
                        {
                            deleteLogsCommand.Parameters.AddWithValue("@CustomerId", customerId);
                            deleteLogsCommand.ExecuteNonQuery();
                        }

                        
                        string deleteOrdersQuery = "DELETE FROM \"orders\" WHERE customer_id = @CustomerId";
                        using (NpgsqlCommand deleteOrdersCommand = new NpgsqlCommand(deleteOrdersQuery, connection))
                        {
                            deleteOrdersCommand.Parameters.AddWithValue("@CustomerId", customerId);
                            deleteOrdersCommand.ExecuteNonQuery();
                        }

                       
                        string deleteCustomerQuery = "DELETE FROM \"customer\" WHERE customer_id = @CustomerId";
                        using (NpgsqlCommand deleteCustomerCommand = new NpgsqlCommand(deleteCustomerQuery, connection))
                        {
                            deleteCustomerCommand.Parameters.AddWithValue("@CustomerId", customerId);
                            deleteCustomerCommand.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Seçilen kullanıcılar başarıyla silindi.");
                    silinecek_kullanicilar.Items.Clear(); 
                    Kullanicilari_checkboxlarda_goster(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }





        private void Urunleri_sil()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (var item in silinecek_urunler.CheckedItems)
                    {
                        string productName = item.ToString();

                        
                        string query = "DELETE FROM \"product\" WHERE product_name = @productName";
                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@productName", productName);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Seçilen ürünler başarıyla silindi.");
                    Urunleri_getir(); 
                    silinecek_urunler.Items.Clear(); 
                    Urunleri_checkboxlarda_goster(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }



        private void duzenlenecek_urunleri_goster()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM \"product\"";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        comboBox1.Items.Add(row["product_name"].ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }


        }


        private void urun_ekle_Click(object sender, EventArgs e)
        {

            product_ekle();
            silinecek_urunler.Items.Clear(); 
            Urunleri_checkboxlarda_goster();
        }

        private void urunleri_listele_Click(object sender, EventArgs e)
        {
            Urunleri_getir();

        }

        private void urunleri_sil_button_Click(object sender, EventArgs e)
        {
            Urunleri_sil();
        }


        private void kullanicilari_sil_button_Click(object sender, EventArgs e)
        {
            Kullanicilari_sil();
        }

        // thread kısmı burdan sonra
        private void SiparisleriGetir()
        {
            try
            {
                PriorityScoreHesapla(); 
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM \"orders\" WHERE \"status\" = 'Pending'"; 
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // UI thread'e erişimi sağlamak için Invoke kullanılıyor
                    if (siparisDataGridView.InvokeRequired)
                    {
                        siparisDataGridView.Invoke(new Action(() =>
                        {
                            siparisDataGridView.DataSource = dataTable;
                        }));
                    }
                    else
                    {
                        siparisDataGridView.DataSource = dataTable;
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }





        private void admin_onayla_Click(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker
            {
                WorkerReportsProgress = true
            };

            worker.DoWork += (s, args) =>
            {
                SiparisleriGetir();
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = @"
                SELECT o.order_id, o.customer_id, o.product_id, o.order_date, o.quantity,
                    CASE 
                        WHEN c.customer_type = 'premium' THEN 15 
                        ELSE 10 
                    END + EXTRACT(EPOCH FROM (NOW() - o.order_date)) * 0.5 AS priority_score
                FROM orders o
                JOIN customer c ON o.customer_id = c.customer_id
                WHERE o.status = 'Pending'
                ORDER BY priority_score DESC";

                    NpgsqlCommand selectCommand = new NpgsqlCommand(selectQuery, connection);
                    NpgsqlDataReader reader = selectCommand.ExecuteReader();

                    List<Order> orders = new List<Order>();
                    while (reader.Read())
                    {
                        orders.Add(new Order
                        {
                            OrderId = reader.GetInt32(0),
                            CustomerId = reader.GetInt32(1),
                            ProductId = reader.GetInt32(2),
                            OrderDate = reader.GetDateTime(3),
                            Quantity = reader.GetInt32(4),
                            PriorityScore = reader.GetDouble(5)
                        });
                    }
                    reader.Close();

                    int completedOrders = 0;

                    foreach (var order in orders)
                    {
                        TimeSpan orderAge = DateTime.Now - order.OrderDate;
                        if (orderAge.TotalSeconds > 60)
                        {
                            ReddetSiparis(connection, order, "Zaman aşımı", "Sipariş zaman aşımına uğradı");
                        }
                        else if (!StokKontrol(connection, order.ProductId, order.Quantity))
                        {
                            ReddetSiparis(connection, order, "Stok yetersiz", $"Sipariş idsi :{order.OrderId} olan sipariş stok yetersizliği nedeniyle reddedildi");
                        }
                        else
                        {
                            string updateQuery = "UPDATE orders SET status = 'Approved' WHERE order_id = @orderId";
                            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
                            updateCommand.Parameters.AddWithValue("@orderId", order.OrderId);
                            updateCommand.ExecuteNonQuery();

                           
                            string priceQuery = "SELECT price FROM product WHERE product_id = @productId";
                            NpgsqlCommand priceCommand = new NpgsqlCommand(priceQuery, connection);
                            priceCommand.Parameters.AddWithValue("@productId", order.ProductId);
                            decimal unitPrice = Convert.ToDecimal(priceCommand.ExecuteScalar());

                            
                            decimal totalPrice = unitPrice * order.Quantity;

                           
                            string updateTotalSpentQuery = @"
            UPDATE customer
            SET total_spent = total_spent + @totalPrice
            WHERE customer_id = @customerId";
                            NpgsqlCommand updateTotalSpentCommand = new NpgsqlCommand(updateTotalSpentQuery, connection);
                            updateTotalSpentCommand.Parameters.AddWithValue("@totalPrice", totalPrice);
                            updateTotalSpentCommand.Parameters.AddWithValue("@customerId", order.CustomerId);
                            updateTotalSpentCommand.ExecuteNonQuery();

                           
                            string insertLogQuery = @"
            INSERT INTO log (customer_id, order_id, log_date, log_type, log_details)
            VALUES (@customerId, @orderId, NOW(), 'Sipariş Onayı', @detail)";
                            NpgsqlCommand logCommand = new NpgsqlCommand(insertLogQuery, connection);
                            logCommand.Parameters.AddWithValue("@customerId", order.CustomerId);
                            logCommand.Parameters.AddWithValue("@orderId", order.OrderId);
                            logCommand.Parameters.AddWithValue("@detail", $"Sipariş ID: {order.OrderId} başarıyla onaylandı. Toplam tutar: {totalPrice:C}.");
                            logCommand.ExecuteNonQuery();
                        }

                        completedOrders++;
                        
                        int progress = (int)((completedOrders / (double)orders.Count) * 100);
                        (s as BackgroundWorker).ReportProgress(progress);

                       
                        Thread.Sleep(500); 
                    }

                }
            };

            worker.ProgressChanged += (s, args) =>
            {
                progressBarSiparis.Value = args.ProgressPercentage;
            };

            worker.RunWorkerCompleted += (s, args) =>
            {
                progressBarSiparis.Visible = false;
                MessageBox.Show("Tüm siparişler başarıyla işleme alındı.");
                SiparisleriGetir();
                Urunleri_getir();
            };

            // İşleme başlamadan önce ProgressBar'ı sıfırla ve görünür yap
            progressBarSiparis.Value = 0;
            progressBarSiparis.Visible = true;

            worker.RunWorkerAsync();
        }

      

        private bool StokKontrol(NpgsqlConnection connection, int productId, int quantity)
        {
            string stockQuery = "SELECT stock FROM product WHERE product_id = @productId";
            NpgsqlCommand stockCommand = new NpgsqlCommand(stockQuery, connection);
            stockCommand.Parameters.AddWithValue("@productId", productId);

            object stockObj = stockCommand.ExecuteScalar();
            if (stockObj == null || Convert.ToInt32(stockObj) < quantity)
            {
                return false; 
            }

          
            string updateStockQuery = "UPDATE product SET stock = stock - @quantity WHERE product_id = @productId";
            NpgsqlCommand updateStockCommand = new NpgsqlCommand(updateStockQuery, connection);
            updateStockCommand.Parameters.AddWithValue("@quantity", quantity);
            updateStockCommand.Parameters.AddWithValue("@productId", productId);
            updateStockCommand.ExecuteNonQuery();

            return true;
        }




        private void ReddetSiparis(NpgsqlConnection connection, Order order, string logType, string logDetail)
        {
            string updateQuery = "UPDATE orders SET status = 'Rejected' WHERE order_id = @orderId";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@orderId", order.OrderId);
            updateCommand.ExecuteNonQuery();

            string insertLogQuery = @"
        INSERT INTO log (customer_id, order_id, log_date, log_type, log_details)
        VALUES (@customerId, @orderId, NOW(), @logType, @logDetail)";
            NpgsqlCommand logCommand = new NpgsqlCommand(insertLogQuery, connection);
            logCommand.Parameters.AddWithValue("@customerId", order.CustomerId);
            logCommand.Parameters.AddWithValue("@orderId", order.OrderId);
            logCommand.Parameters.AddWithValue("@logType", logType);
            logCommand.Parameters.AddWithValue("@logDetail", logDetail);
            logCommand.ExecuteNonQuery();
        }





        private void PriorityScoreHesapla()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Tüm bekleyen siparişlerin Priority Score'unu hesaplayıp güncelle
                    string updatePriorityQuery = @"
                UPDATE orders
                SET priority_score = 
                    CASE 
                        WHEN c.customer_type = 'premium' THEN 50 
                        ELSE 10 
                    END + EXTRACT(EPOCH FROM (NOW() - orders.order_date)) * 0.5
                FROM customer c
                WHERE orders.customer_id = c.customer_id AND orders.status = 'Pending'";

                    NpgsqlCommand updateCommand = new NpgsqlCommand(updatePriorityQuery, connection);
                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        public class Order
        {
            public int OrderId { get; set; }
            public int CustomerId { get; set; }
            public int ProductId { get; set; }
            public DateTime OrderDate { get; set; }
            public int Quantity { get; set; }
            public double PriorityScore { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 orderForm = new Form4();
            orderForm.ShowDialog();
        }

        private void stok_guncelle_button_Click(object sender, EventArgs e)
        {
            try
            {
               
                string secilenUrunComboBox = comboBox1.SelectedItem?.ToString();

                
                string secilenUrunListBox = silinecek_kullanicilar.SelectedItem?.ToString();

               
                if (string.IsNullOrEmpty(secilenUrunComboBox) && string.IsNullOrEmpty(secilenUrunListBox))
                {
                    MessageBox.Show("Lütfen ComboBox veya ListBox'tan bir ürün seçin!");
                    return;
                }

           
                string secilenUrun = !string.IsNullOrEmpty(secilenUrunComboBox) ? secilenUrunComboBox : secilenUrunListBox;

             
                int yeniStok = (int)stok_guncelle_numeric.Value;

      
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    
                    string query = "UPDATE \"product\" SET stock = @stok WHERE product_name = @urun";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                      
                        command.Parameters.AddWithValue("@stok", yeniStok);
                        command.Parameters.AddWithValue("@urun", secilenUrun);

                  
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Stok başarıyla güncellendi! Güncellenen ürün: {secilenUrun}");
                            Urunleri_getir();
                        }
                        else
                        {
                            MessageBox.Show("Ürün bulunamadı veya stok güncellenemedi.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void durdur_button_Click(object sender, EventArgs e)
        {
            admin_islem = !admin_islem;
            if (admin_islem)
            {
                timer.Stop(); 
                durdur_button.BackColor = Color.Crimson;
                durdur_button.Text = "Sistemi Başlat"; 
                MessageBox.Show("İşlemler durduruldu");
                

            }
            else
            {
                timer.Start();
                durdur_button.BackColor = Color.LawnGreen;
                durdur_button.Text = "Sistemi Durdur";
                MessageBox.Show("İşlemler başladı");
            }
        }

    }
}
