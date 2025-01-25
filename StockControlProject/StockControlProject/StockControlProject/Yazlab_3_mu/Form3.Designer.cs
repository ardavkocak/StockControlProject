namespace Yazlab_3_mu
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pricenumeric = new System.Windows.Forms.NumericUpDown();
            this.urun_ekle = new System.Windows.Forms.Button();
            this.stocknumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtproductName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.urunleri_listele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.silinecek_urunler = new System.Windows.Forms.CheckedListBox();
            this.urunleri_sil_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.admin_onayla = new System.Windows.Forms.Button();
            this.siparisDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kullanicilari_sil_button = new System.Windows.Forms.Button();
            this.silinecek_kullanicilar = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBarSiparis = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.stok_guncelle_numeric = new System.Windows.Forms.NumericUpDown();
            this.stok_guncelle_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.durdur_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pricenumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocknumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siparisDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stok_guncelle_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // pricenumeric
            // 
            this.pricenumeric.Location = new System.Drawing.Point(68, 110);
            this.pricenumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pricenumeric.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.pricenumeric.Name = "pricenumeric";
            this.pricenumeric.Size = new System.Drawing.Size(283, 22);
            this.pricenumeric.TabIndex = 31;
            // 
            // urun_ekle
            // 
            this.urun_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urun_ekle.Location = new System.Drawing.Point(5, 159);
            this.urun_ekle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.urun_ekle.Name = "urun_ekle";
            this.urun_ekle.Size = new System.Drawing.Size(344, 58);
            this.urun_ekle.TabIndex = 30;
            this.urun_ekle.Text = "Ürün Ekle";
            this.urun_ekle.UseVisualStyleBackColor = true;
            this.urun_ekle.Click += new System.EventHandler(this.urun_ekle_Click);
            // 
            // stocknumeric
            // 
            this.stocknumeric.Location = new System.Drawing.Point(65, 62);
            this.stocknumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stocknumeric.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.stocknumeric.Name = "stocknumeric";
            this.stocknumeric.Size = new System.Drawing.Size(285, 22);
            this.stocknumeric.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(5, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(5, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Stok";
            // 
            // txtproductName
            // 
            this.txtproductName.BackColor = System.Drawing.Color.White;
            this.txtproductName.Location = new System.Drawing.Point(65, 6);
            this.txtproductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtproductName.Multiline = true;
            this.txtproductName.Name = "txtproductName";
            this.txtproductName.Size = new System.Drawing.Size(285, 31);
            this.txtproductName.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(5, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "İsim";
            // 
            // urunleri_listele
            // 
            this.urunleri_listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunleri_listele.Location = new System.Drawing.Point(12, 258);
            this.urunleri_listele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.urunleri_listele.Name = "urunleri_listele";
            this.urunleri_listele.Size = new System.Drawing.Size(603, 58);
            this.urunleri_listele.TabIndex = 24;
            this.urunleri_listele.Text = "Ürünleri Listele";
            this.urunleri_listele.UseVisualStyleBackColor = true;
            this.urunleri_listele.Click += new System.EventHandler(this.urunleri_listele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(603, 254);
            this.dataGridView1.TabIndex = 23;
            // 
            // silinecek_urunler
            // 
            this.silinecek_urunler.FormattingEnabled = true;
            this.silinecek_urunler.Location = new System.Drawing.Point(32, 6);
            this.silinecek_urunler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.silinecek_urunler.Name = "silinecek_urunler";
            this.silinecek_urunler.Size = new System.Drawing.Size(325, 106);
            this.silinecek_urunler.TabIndex = 32;
            // 
            // urunleri_sil_button
            // 
            this.urunleri_sil_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunleri_sil_button.Location = new System.Drawing.Point(32, 158);
            this.urunleri_sil_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.urunleri_sil_button.Name = "urunleri_sil_button";
            this.urunleri_sil_button.Size = new System.Drawing.Size(317, 58);
            this.urunleri_sil_button.TabIndex = 33;
            this.urunleri_sil_button.Text = "Ürünü Sil";
            this.urunleri_sil_button.UseVisualStyleBackColor = true;
            this.urunleri_sil_button.Click += new System.EventHandler(this.urunleri_sil_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.pricenumeric);
            this.groupBox1.Controls.Add(this.stocknumeric);
            this.groupBox1.Controls.Add(this.urun_ekle);
            this.groupBox1.Controls.Add(this.txtproductName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(23, 348);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(365, 233);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.Controls.Add(this.urunleri_sil_button);
            this.groupBox2.Controls.Add(this.silinecek_urunler);
            this.groupBox2.Location = new System.Drawing.Point(405, 348);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(393, 231);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // admin_onayla
            // 
            this.admin_onayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admin_onayla.Location = new System.Drawing.Point(19, 820);
            this.admin_onayla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_onayla.Name = "admin_onayla";
            this.admin_onayla.Size = new System.Drawing.Size(1124, 55);
            this.admin_onayla.TabIndex = 37;
            this.admin_onayla.Text = "Siparişleri Onayla";
            this.admin_onayla.UseVisualStyleBackColor = true;
            this.admin_onayla.Click += new System.EventHandler(this.admin_onayla_Click);
            // 
            // siparisDataGridView
            // 
            this.siparisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siparisDataGridView.Location = new System.Drawing.Point(23, 599);
            this.siparisDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siparisDataGridView.Name = "siparisDataGridView";
            this.siparisDataGridView.RowHeadersWidth = 51;
            this.siparisDataGridView.RowTemplate.Height = 24;
            this.siparisDataGridView.Size = new System.Drawing.Size(1113, 185);
            this.siparisDataGridView.TabIndex = 38;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DimGray;
            this.groupBox3.Controls.Add(this.kullanicilari_sil_button);
            this.groupBox3.Controls.Add(this.silinecek_kullanicilar);
            this.groupBox3.Location = new System.Drawing.Point(635, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(501, 222);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            // 
            // kullanicilari_sil_button
            // 
            this.kullanicilari_sil_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanicilari_sil_button.Location = new System.Drawing.Point(5, 149);
            this.kullanicilari_sil_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullanicilari_sil_button.Name = "kullanicilari_sil_button";
            this.kullanicilari_sil_button.Size = new System.Drawing.Size(489, 58);
            this.kullanicilari_sil_button.TabIndex = 33;
            this.kullanicilari_sil_button.Text = "Kullanıcıyı Sil";
            this.kullanicilari_sil_button.UseVisualStyleBackColor = true;
            this.kullanicilari_sil_button.Click += new System.EventHandler(this.kullanicilari_sil_button_Click);
            // 
            // silinecek_kullanicilar
            // 
            this.silinecek_kullanicilar.FormattingEnabled = true;
            this.silinecek_kullanicilar.Location = new System.Drawing.Point(5, 10);
            this.silinecek_kullanicilar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.silinecek_kullanicilar.Name = "silinecek_kullanicilar";
            this.silinecek_kullanicilar.Size = new System.Drawing.Size(489, 106);
            this.silinecek_kullanicilar.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(635, 258);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(507, 58);
            this.button1.TabIndex = 41;
            this.button1.Text = "Log İşlemerli";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBarSiparis
            // 
            this.progressBarSiparis.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBarSiparis.ForeColor = System.Drawing.SystemColors.InfoText;
            this.progressBarSiparis.Location = new System.Drawing.Point(23, 791);
            this.progressBarSiparis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarSiparis.Name = "progressBarSiparis";
            this.progressBarSiparis.Size = new System.Drawing.Size(1107, 23);
            this.progressBarSiparis.TabIndex = 42;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DimGray;
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.stok_guncelle_numeric);
            this.groupBox4.Controls.Add(this.stok_guncelle_button);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(804, 348);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(332, 226);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(67, 21);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 24);
            this.comboBox1.TabIndex = 32;
            // 
            // stok_guncelle_numeric
            // 
            this.stok_guncelle_numeric.Location = new System.Drawing.Point(67, 85);
            this.stok_guncelle_numeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stok_guncelle_numeric.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.stok_guncelle_numeric.Name = "stok_guncelle_numeric";
            this.stok_guncelle_numeric.Size = new System.Drawing.Size(259, 22);
            this.stok_guncelle_numeric.TabIndex = 29;
            // 
            // stok_guncelle_button
            // 
            this.stok_guncelle_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stok_guncelle_button.Location = new System.Drawing.Point(11, 153);
            this.stok_guncelle_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stok_guncelle_button.Name = "stok_guncelle_button";
            this.stok_guncelle_button.Size = new System.Drawing.Size(315, 58);
            this.stok_guncelle_button.TabIndex = 30;
            this.stok_guncelle_button.Text = "Stok Güncelle";
            this.stok_guncelle_button.UseVisualStyleBackColor = true;
            this.stok_guncelle_button.Click += new System.EventHandler(this.stok_guncelle_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "İsim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(5, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "Stok";
            // 
            // durdur_button
            // 
            this.durdur_button.BackColor = System.Drawing.Color.LawnGreen;
            this.durdur_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durdur_button.Location = new System.Drawing.Point(19, 881);
            this.durdur_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.durdur_button.Name = "durdur_button";
            this.durdur_button.Size = new System.Drawing.Size(1123, 51);
            this.durdur_button.TabIndex = 44;
            this.durdur_button.Text = "Sistemi Durdur";
            this.durdur_button.UseVisualStyleBackColor = false;
            this.durdur_button.Click += new System.EventHandler(this.durdur_button_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1144, 939);
            this.Controls.Add(this.durdur_button);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.progressBarSiparis);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.siparisDataGridView);
            this.Controls.Add(this.admin_onayla);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.urunleri_listele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pricenumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocknumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siparisDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stok_guncelle_numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown pricenumeric;
        private System.Windows.Forms.Button urun_ekle;
        private System.Windows.Forms.NumericUpDown stocknumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtproductName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button urunleri_listele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckedListBox silinecek_urunler;
        private System.Windows.Forms.Button urunleri_sil_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button admin_onayla;
        private System.Windows.Forms.DataGridView siparisDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button kullanicilari_sil_button;
        private System.Windows.Forms.CheckedListBox silinecek_kullanicilar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBarSiparis;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown stok_guncelle_numeric;
        private System.Windows.Forms.Button stok_guncelle_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button durdur_button;
    }
}