namespace Yazlab_3_mu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.admin_ad_text = new System.Windows.Forms.TextBox();
            this.admin_sifre_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.admin_giris_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.BackColor = System.Drawing.Color.Azure;
            this.btnSiparisVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisVer.Location = new System.Drawing.Point(293, 545);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(454, 58);
            this.btnSiparisVer.TabIndex = 23;
            this.btnSiparisVer.Text = "Sipariş Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = false;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click);
            // 
            // admin_ad_text
            // 
            this.admin_ad_text.Location = new System.Drawing.Point(183, 112);
            this.admin_ad_text.Multiline = true;
            this.admin_ad_text.Name = "admin_ad_text";
            this.admin_ad_text.Size = new System.Drawing.Size(185, 31);
            this.admin_ad_text.TabIndex = 26;
            // 
            // admin_sifre_text
            // 
            this.admin_sifre_text.Location = new System.Drawing.Point(183, 153);
            this.admin_sifre_text.Multiline = true;
            this.admin_sifre_text.Name = "admin_sifre_text";
            this.admin_sifre_text.PasswordChar = '*';
            this.admin_sifre_text.Size = new System.Drawing.Size(185, 31);
            this.admin_sifre_text.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(114, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(114, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ad";
            // 
            // admin_giris_button
            // 
            this.admin_giris_button.Location = new System.Drawing.Point(40, 212);
            this.admin_giris_button.Name = "admin_giris_button";
            this.admin_giris_button.Size = new System.Drawing.Size(454, 58);
            this.admin_giris_button.TabIndex = 30;
            this.admin_giris_button.Text = "Giriş Yap";
            this.admin_giris_button.UseVisualStyleBackColor = true;
            this.admin_giris_button.Click += new System.EventHandler(this.admin_giris_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.admin_giris_button);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.admin_sifre_text);
            this.groupBox1.Controls.Add(this.admin_ad_text);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(253, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 326);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Giriş";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Yazlab_3_mu.Properties.Resources.giris_arkaplan1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1033, 811);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 811);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.TextBox admin_ad_text;
        private System.Windows.Forms.TextBox admin_sifre_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button admin_giris_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

