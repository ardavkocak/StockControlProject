namespace Yazlab_3_mu
{
    partial class Form2
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.data_urunler = new System.Windows.Forms.DataGridView();
            this.Durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeric_siparis = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.siparis_butonu = new System.Windows.Forms.Button();
            this.sepet_temizle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siparislerim_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_urunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_siparis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 25);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(8, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // data_urunler
            // 
            this.data_urunler.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.data_urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_urunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Durum});
            this.data_urunler.Location = new System.Drawing.Point(152, 60);
            this.data_urunler.Margin = new System.Windows.Forms.Padding(2);
            this.data_urunler.Name = "data_urunler";
            this.data_urunler.RowHeadersWidth = 51;
            this.data_urunler.RowTemplate.Height = 24;
            this.data_urunler.Size = new System.Drawing.Size(439, 460);
            this.data_urunler.TabIndex = 2;
            // 
            // Durum
            // 
            this.Durum.HeaderText = "Stok Durumu";
            this.Durum.MinimumWidth = 6;
            this.Durum.Name = "Durum";
            this.Durum.Width = 125;
            // 
            // numeric_siparis
            // 
            this.numeric_siparis.Location = new System.Drawing.Point(9, 272);
            this.numeric_siparis.Margin = new System.Windows.Forms.Padding(2);
            this.numeric_siparis.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numeric_siparis.Name = "numeric_siparis";
            this.numeric_siparis.Size = new System.Drawing.Size(142, 20);
            this.numeric_siparis.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Miktar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Location = new System.Drawing.Point(592, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 460);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(675, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sepetim";
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnSepeteEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepeteEkle.Location = new System.Drawing.Point(9, 444);
            this.btnSepeteEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(139, 36);
            this.btnSepeteEkle.TabIndex = 7;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = false;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // siparis_butonu
            // 
            this.siparis_butonu.BackColor = System.Drawing.Color.LemonChiffon;
            this.siparis_butonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparis_butonu.Location = new System.Drawing.Point(653, 525);
            this.siparis_butonu.Margin = new System.Windows.Forms.Padding(2);
            this.siparis_butonu.Name = "siparis_butonu";
            this.siparis_butonu.Size = new System.Drawing.Size(128, 36);
            this.siparis_butonu.TabIndex = 8;
            this.siparis_butonu.Text = "Sipariş Ver";
            this.siparis_butonu.UseVisualStyleBackColor = false;
            this.siparis_butonu.Click += new System.EventHandler(this.siparis_butonu_Click);
            // 
            // sepet_temizle
            // 
            this.sepet_temizle.BackColor = System.Drawing.Color.LemonChiffon;
            this.sepet_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sepet_temizle.Location = new System.Drawing.Point(11, 484);
            this.sepet_temizle.Margin = new System.Windows.Forms.Padding(2);
            this.sepet_temizle.Name = "sepet_temizle";
            this.sepet_temizle.Size = new System.Drawing.Size(139, 36);
            this.sepet_temizle.TabIndex = 9;
            this.sepet_temizle.Text = "Sepeti Temizle";
            this.sepet_temizle.UseVisualStyleBackColor = false;
            this.sepet_temizle.Click += new System.EventHandler(this.sepet_temizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kullanıcı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(93, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Miktar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Yazlab_3_mu.Properties.Resources.siparis_ekrani_arkaplan;
            this.pictureBox1.Location = new System.Drawing.Point(2, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(850, 601);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // siparislerim_button
            // 
            this.siparislerim_button.BackColor = System.Drawing.Color.LemonChiffon;
            this.siparislerim_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparislerim_button.Location = new System.Drawing.Point(317, 541);
            this.siparislerim_button.Margin = new System.Windows.Forms.Padding(2);
            this.siparislerim_button.Name = "siparislerim_button";
            this.siparislerim_button.Size = new System.Drawing.Size(139, 36);
            this.siparislerim_button.TabIndex = 13;
            this.siparislerim_button.Text = "Siparişlerim";
            this.siparislerim_button.UseVisualStyleBackColor = false;
            this.siparislerim_button.Click += new System.EventHandler(this.siparislerim_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(850, 609);
            this.Controls.Add(this.siparislerim_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sepet_temizle);
            this.Controls.Add(this.siparis_butonu);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeric_siparis);
            this.Controls.Add(this.data_urunler);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_urunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_siparis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView data_urunler;
        private System.Windows.Forms.NumericUpDown numeric_siparis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Button siparis_butonu;
        private System.Windows.Forms.Button sepet_temizle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button siparislerim_button;
    }
}