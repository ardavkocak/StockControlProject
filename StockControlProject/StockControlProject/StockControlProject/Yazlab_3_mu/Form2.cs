using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static Yazlab_3_mu.Form5; 

namespace Yazlab_3_mu
{
    public partial class Form2 : Form
    {
        private string _currentUser;
        public Form2(string currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        public int customerId;
        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1234;Database=SistemYonetim";
        private void Form2_Load(object sender, EventArgs e)
        {
            kullanicilari_cek();
            if (Form3.admin_islem)
            {
                MessageBox.Show("Admin işlem yapıyor.İşlem yapamazsınız ");
                return;
                Urunleri_getir();
            }
            else
            {
               
               
                    Urunleri_getir();
                    data_urunler.CellClick += data_urunler_CellClick;
                    // Kullanıcı adı combobox'ta varsa seçili hale getir
                    if (comboBox1.Items.Contains(_currentUser))
                    {
                        comboBox1.SelectedItem = _currentUser;
                        MessageBox.Show($"Hoş geldiniz, {_currentUser}");
                        label4.Text = $" {_currentUser} ";
                    }
                    else
                    {
                        MessageBox.Show($"'{_currentUser}' kullanıcısı listede bulunamadı.");
                    }
                }
            
        }


        List<SepetItem> sepet = new List<SepetItem>();

        
        public class SepetItem
        {
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
        }


        private string selectedProductName = "";
        private int selectedProductStock = 0;
        private decimal selectedProductPrice = 0;
        private string selectedCustomer = "";

        private void data_urunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Form3.admin_islem)
            {
                MessageBox.Show("Admin işlem yapıyor.Lütfen bekleyiniz");
                return;
            }
            else
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = data_urunler.Rows[e.RowIndex];

                    
                    selectedProductName = row.Cells["product_name"].Value.ToString();
                    selectedProductStock = Convert.ToInt32(row.Cells["stock"].Value);
                    selectedProductPrice = Convert.ToDecimal(row.Cells["price"].Value);

                    MessageBox.Show($"Seçilen Ürün: {selectedProductName}\nStok: {selectedProductStock}\nFiyat: {selectedProductPrice:C}");
                }
            }
        }






        private void kullanicilari_cek()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT customer_name FROM \"customer\""; 
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        comboBox1.Items.Add(row["customer_name"].ToString());
                    }

                   
                    if (!string.IsNullOrEmpty(CurrentUser.Username))  
                    {
                        comboBox1.SelectedItem = CurrentUser.Username;
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

                    data_urunler.DataSource = dataTable; 
                }

                StokSembolGuncelle(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void StokSembolGuncelle()
        {
            foreach (DataGridViewRow row in data_urunler.Rows)
            {
                if (row.Cells["stock"].Value != null && int.TryParse(row.Cells["stock"].Value.ToString(), out int stockMiktari))
                {
                    // Stok miktarına göre sembol ve açıklama
                    if (stockMiktari == 0)
                    {
                        row.Cells["Durum"].Value = "❌ Tükendi";
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    else if (stockMiktari < 10)
                    {
                        row.Cells["Durum"].Value = "⚠ Az Stok";
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                    else
                    {
                        row.Cells["Durum"].Value = "✔ Yeterli";
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
            }
        }





        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (Form3.admin_islem)
            {
                
                MessageBox.Show("Admin işlem yapıyor.Lütfen bekleyiniz");
                return;
            }
            else
            {
                int quantity = (int)numeric_siparis.Value;

                if (quantity <= 0)
                {
                    MessageBox.Show("Lütfen geçerli bir miktar giriniz.");
                    return;
                }

                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir müşteri seçiniz.");
                    return;
                }

                if (!isTimerActive)
                {
                    siparisTimer = new Timer();
                    siparisTimer.Interval = 30000; // 30 saniye (milisaniye cinsinden)
                    siparisTimer.Tick += SiparisZamanAsimi;
                    siparisTimer.Start();
                    isTimerActive = true;
                }

                try
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();

                        
                        string customerName = comboBox1.SelectedItem.ToString();
                        customerId = GetCustomerId(customerName, connection); // Müşteri ID'yi doğrudan alıyoruz.
                        if (customerId == -1)
                        {
                            MessageBox.Show("Seçilen müşteri bulunamadı!");
                            return;
                        }

                        decimal customerBudget = GetCustomerBudget(customerId, connection);

                        
                        int existingQuantityInCart = sepet
                            .Where(item => item.ProductName == selectedProductName)
                            .Sum(item => item.Quantity);

                        
                        int totalQuantity = existingQuantityInCart + quantity;

                      
                        string stockQuery = "SELECT stock FROM \"product\" WHERE product_name = @productName";

                        using (NpgsqlCommand stockCommand = new NpgsqlCommand(stockQuery, connection))
                        {
                            stockCommand.Parameters.AddWithValue("@productName", selectedProductName);
                            int currentStock = Convert.ToInt32(stockCommand.ExecuteScalar());

                            if (totalQuantity > currentStock)
                            {
                                
                                AddLogEntry(
                                    customerId,
                                    null,
                                    "Stok Yetersiz",
                                    $"{customerName}'nın siparişi {selectedProductName} ürününün stok yetersizliğinden sepete eklenemedi.",
                                    connection
                                );

                                MessageBox.Show($"{selectedProductName} ürünü için stok yetersiz! Mevcut stok: {currentStock}");
                                return;
                            }
                        }

                       
                        decimal totalPriceForNewItems = quantity * selectedProductPrice;

                        
                        decimal totalCartCost = sepet.Sum(item => item.Quantity * item.Price);
                        if (totalCartCost + totalPriceForNewItems > customerBudget)
                        {
                           
                            AddLogEntry(
                                customerId,
                                null,
                                "Bütçe Yetersiz",
                                $"{customerName}'nın bütçesi yetersiz. Mevcut bütçe: {customerBudget}.",
                                connection
                            );

                            MessageBox.Show("Bu ürünü sepete eklemek için bütçeniz yetersiz!");
                            return;
                        }

                        // Ürün sepete ekleniyor
                        sepet.Add(new SepetItem
                        {
                            ProductName = selectedProductName,
                            Quantity = quantity,
                            Price = selectedProductPrice
                        });

                        SepetiGuncelle();
                        MessageBox.Show("Ürün sepete eklendi.");
                    }
                }
                catch (Exception ex)
                {
                    
                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            int customerId = comboBox1.SelectedIndex >= 0 ? GetCustomerId(comboBox1.SelectedItem.ToString(), connection) : -1;
                            AddLogEntry(customerId, null, "Veritabanı Hatası", ex.Message, connection);
                        }
                        catch
                        {
                            // Log kaydı yapılırken başka bir hata oluşursa bir şey yapma
                        }
                    }

                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }





        private void AddLogEntry(int customerId, int? orderId, string logType, string logDetails, NpgsqlConnection connection)
        {
            try
            {
                string insertLogQuery = @"
            INSERT INTO log (customer_id, order_id, log_date, log_type, log_details)
            VALUES (@customerId, @orderId, NOW(), @logType, @logDetails)";

                using (NpgsqlCommand logCommand = new NpgsqlCommand(insertLogQuery, connection))
                {
                    logCommand.Parameters.AddWithValue("@customerId", customerId);
                    logCommand.Parameters.AddWithValue("@orderId", (object)orderId ?? DBNull.Value);
                    logCommand.Parameters.AddWithValue("@logType", logType);
                    logCommand.Parameters.AddWithValue("@logDetails", logDetails);
                    logCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (log kaydı): " + ex.Message);
            }
        }




        private void SiparisZamanAsimi(object sender, EventArgs e)
        {
            
            siparisTimer.Stop();
            isTimerActive = false;

            MessageBox.Show("İşlem zaman aşımına uğradı!");

            
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string customerName = comboBox1.SelectedItem?.ToString();
                    int customerId = GetCustomerId(customerName, connection);

                    string insertLogQuery = @"
                INSERT INTO log (customer_id, order_id, log_date, log_type, log_details)
                VALUES (@customerId, NULL, NOW(), 'Sepet Zaman Aşımı', 'İşlem zaman aşımına uğradı')";

                    using (NpgsqlCommand logCommand = new NpgsqlCommand(insertLogQuery, connection))
                    {
                        logCommand.Parameters.AddWithValue("@customerId", customerId);
                        logCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (log ekleme): " + ex.Message);
            }

           
            sepet.Clear();
            SepetiGuncelle();
        }




        private void SepetiGuncelle()
        {
            panel1.Controls.Clear();

            int y = 10; 
            foreach (var item in sepet)
            {
                // Ürün bilgisi etiketi
                Label lbl = new Label();
                lbl.Text = $"{item.ProductName} - {item.Quantity} Adet - Toplam: {(item.Quantity * item.Price):C}";
                lbl.Location = new Point(10, y);
                lbl.AutoSize = true;
                panel1.Controls.Add(lbl);

                // Çöp kutusu simgesi olan buton
                Button btnSil = new Button();
                btnSil.Size = new Size(30, 30); 
                btnSil.Location = new Point(panel1.Width - 50, y - 5); 
                btnSil.Text = "🗑";
                btnSil.Font = new Font("Segoe UI Emoji", 12, FontStyle.Regular); 
                btnSil.Tag = item; 

               
                btnSil.Click += (sender, e) =>
                {
                    SepettenUrunSil(item);

                };

                panel1.Controls.Add(btnSil);
                y += 35; 
            }
        }




        
        private void SepettenUrunSil(SepetItem item)
        {
            sepet.Remove(item); 
            SepetiGuncelle(); 
            MessageBox.Show($"{item.ProductName} ürünü sepetten silindi.");
        }



        private int GetCustomerId(string customerName, NpgsqlConnection connection)
        {
            string query = "SELECT customer_id FROM \"customer\" WHERE customer_name = @customerName";

            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@customerName", customerName);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
        private int GetProductId(string productName, NpgsqlConnection connection)
        {
            string query = "SELECT product_id FROM \"product\" WHERE product_name = @productName";

            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@productName", productName);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
        private decimal GetCustomerBudget(int customerId, NpgsqlConnection connection)
        {
            string query = "SELECT budget FROM \"customer\" WHERE customer_id = @customerId";

            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@customerId", customerId);
                return Convert.ToDecimal(command.ExecuteScalar());
            }
        }
  
        private void UpdateCustomerBudget(int customerId, decimal newBudget, NpgsqlConnection connection)
        {
            string updateQuery = "UPDATE \"customer\" SET budget = @newBudget WHERE customer_id = @customerId";

            using (NpgsqlCommand command = new NpgsqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@newBudget", newBudget);
                command.Parameters.AddWithValue("@customerId", customerId);
                command.ExecuteNonQuery();
            }
        }


        private void siparis_butonu_Click(object sender, EventArgs e)
        {
            if (Form3.admin_islem)
            {
                MessageBox.Show("Admin işlem yapıyor.Lütfen bekleyiniz");
                return;
            }
            else
            {
                
                if (isTimerActive)
                {
                    siparisTimer.Stop();
                    isTimerActive = false;
                }

                
                if (sepet.Count == 0)
                {
                    MessageBox.Show("Sepetiniz boş. Lütfen ürün ekleyin.");
                    return;
                }

                try
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();

                        // Müşteri bilgilerini al
                        string customerName = comboBox1.SelectedItem?.ToString();
                        if (string.IsNullOrEmpty(customerName))
                        {
                            MessageBox.Show("Lütfen bir müşteri seçin.");
                            return;
                        }

                        int customerId = GetCustomerId(customerName, connection);

                        // Kullanıcı tipi bilgisini al
                        string customerType = GetCustomerType(customerId, connection);
                        decimal customerBudget = GetCustomerBudget(customerId, connection);
                        decimal sepetToplam = sepet.Sum(item => item.Quantity * item.Price);

                       
                        if (!MusteriButceKontrol(customerId, customerBudget, sepetToplam, connection))
                            return;

                        
                        if (!StokKontrol(connection))
                            return;

                       
                        foreach (var item in sepet)
                        {
                            int productId = GetProductId(item.ProductName, connection);
                            decimal totalPrice = item.Quantity * item.Price;

                            int orderId = SiparisEkle(customerId, productId, item.Quantity, totalPrice, connection);

                            // Log ekleme
                            AddLogEntry(
                                customerId,
                                orderId,
                                "Sipariş Verildi",
                                $"{customerName} ({customerType}) adlı kullanıcı {item.ProductName} ürününden {item.Quantity} tane sipariş verdi.",
                                connection
                            );

                           
                        }

                       
                        UpdateCustomerBudget(customerId, customerBudget - sepetToplam, connection);
                     
                      
                        MessageBox.Show("Sipariş başarıyla verildi!");
                        sepet.Clear();
                        SepetiGuncelle();
                        Urunleri_getir();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private string GetCustomerType(int customerId, NpgsqlConnection connection)
        {
            string query = "SELECT customer_type FROM \"customer\" WHERE customer_id = @customerId";
            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@customerId", customerId);

                object result = command.ExecuteScalar();
                return result != null ? result.ToString() : "Bilinmiyor";
            }
        }


      

        //BURDAAAAAAAAAA

        private bool MusteriButceKontrol(int customerId, decimal customerBudget, decimal sepetToplam, NpgsqlConnection connection)
        {
            if (customerBudget < sepetToplam)
            {
               // LogKaydet(customerId, null, "Sipariş Ver", "Yetersiz bütçe! İşlem başarısız.", connection);
                MessageBox.Show("Yetersiz bütçe! Siparişi tamamlamak için yeterli bakiyeniz yok.");
                return false;
            }
            return true;
        }





        private bool StokKontrol(NpgsqlConnection connection)
        {
            foreach (var item in sepet.GroupBy(i => i.ProductName))
            {
                string productName = item.Key;
                int totalQuantityInCart = item.Sum(i => i.Quantity);

                string stockQuery = "SELECT stock FROM \"product\" WHERE product_name = @productName";
                using (NpgsqlCommand stockCommand = new NpgsqlCommand(stockQuery, connection))
                {
                    stockCommand.Parameters.AddWithValue("@productName", productName);
                    int stock = Convert.ToInt32(stockCommand.ExecuteScalar());

                    if (totalQuantityInCart > stock)
                    {
                        //LogKaydet(GetCustomerId(comboBox1.SelectedItem.ToString(), connection), null, "Stok Kontrol",
                        //    $"{productName} ürünü için yeterli stok bulunmuyor. İşlem başarısız.", connection);

                        MessageBox.Show($"{productName} ürünü için yeterli stok bulunmuyor! Mevcut stok: {stock}");
                        return false;
                    }
                }
            }
            return true;
        }



        private Timer siparisTimer;
        private bool isTimerActive = false;


        private int SiparisEkle(int customerId, int productId, int quantity, decimal totalPrice, NpgsqlConnection connection)
        {
            string insertQuery = @"
        INSERT INTO ""orders"" (customer_id, product_id, quantity, total_price, status, order_date) 
        VALUES (@customerId, @productId, @quantity, @totalPrice, @status, @orderDate) 
        RETURNING order_id";

            using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@customerId", customerId);
                command.Parameters.AddWithValue("@productId", productId);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@totalPrice", totalPrice);
                command.Parameters.AddWithValue("@status", "Pending"); // Onay bekliyor
                command.Parameters.AddWithValue("@orderDate", DateTime.Now);

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }




     





        private void sepet_temizle_Click(object sender, EventArgs e)
        {

            if (isTimerActive)
            {
                siparisTimer.Stop();
                isTimerActive = false;
            }



            if (sepet.Count == 0)
            {
                MessageBox.Show("Sepet zaten boş.");
                return;
            }


            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                   
                }

                sepet.Clear();
                panel1.Controls.Clear();

                Urunleri_getir();

                MessageBox.Show("Sepet temizlendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void siparislerim_button_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string customerName = comboBox1.SelectedItem.ToString();
                customerId = GetCustomerId(customerName, connection); 
                Form6 orderForm = new Form6(customerId);
                orderForm.Show();
            }
        }
    }
}