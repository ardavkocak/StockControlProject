namespace Yazlab_3_mu
{
    partial class Form5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kullanici_giris_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.admin_sifre_text = new System.Windows.Forms.TextBox();
            this.admin_ad_text = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.kullanici_giris_button);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.admin_sifre_text);
            this.groupBox1.Controls.Add(this.admin_ad_text);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(188, 181);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(404, 273);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Giriş";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(86, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Şifre";
            // 
            // kullanici_giris_button
            // 
            this.kullanici_giris_button.Location = new System.Drawing.Point(30, 172);
            this.kullanici_giris_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kullanici_giris_button.Name = "kullanici_giris_button";
            this.kullanici_giris_button.Size = new System.Drawing.Size(340, 47);
            this.kullanici_giris_button.TabIndex = 30;
            this.kullanici_giris_button.Text = "Giriş Yap";
            this.kullanici_giris_button.UseVisualStyleBackColor = true;
            this.kullanici_giris_button.Click += new System.EventHandler(this.kullanici_giris_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(86, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ad";
            // 
            // admin_sifre_text
            // 
            this.admin_sifre_text.Location = new System.Drawing.Point(137, 124);
            this.admin_sifre_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.admin_sifre_text.Multiline = true;
            this.admin_sifre_text.Name = "admin_sifre_text";
            this.admin_sifre_text.PasswordChar = '*';
            this.admin_sifre_text.Size = new System.Drawing.Size(140, 26);
            this.admin_sifre_text.TabIndex = 27;
            // 
            // admin_ad_text
            // 
            this.admin_ad_text.Location = new System.Drawing.Point(137, 91);
            this.admin_ad_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.admin_ad_text.Multiline = true;
            this.admin_ad_text.Name = "admin_ad_text";
            this.admin_ad_text.Size = new System.Drawing.Size(140, 26);
            this.admin_ad_text.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Yazlab_3_mu.Properties.Resources.siparis_filled;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(774, 664);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(772, 665);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kullanici_giris_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox admin_sifre_text;
        private System.Windows.Forms.TextBox admin_ad_text;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}