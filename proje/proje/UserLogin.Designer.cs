
namespace proje
{
    partial class UserLogin
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
            this.txtUserKAdi = new System.Windows.Forms.TextBox();
            this.txtUserSifre = new System.Windows.Forms.TextBox();
            this.UserKAdi = new System.Windows.Forms.Label();
            this.UserSifre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserKAdi
            // 
            this.txtUserKAdi.Location = new System.Drawing.Point(423, 95);
            this.txtUserKAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserKAdi.Name = "txtUserKAdi";
            this.txtUserKAdi.Size = new System.Drawing.Size(187, 22);
            this.txtUserKAdi.TabIndex = 0;
            // 
            // txtUserSifre
            // 
            this.txtUserSifre.Location = new System.Drawing.Point(423, 171);
            this.txtUserSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserSifre.Name = "txtUserSifre";
            this.txtUserSifre.Size = new System.Drawing.Size(187, 22);
            this.txtUserSifre.TabIndex = 1;
            // 
            // UserKAdi
            // 
            this.UserKAdi.AutoSize = true;
            this.UserKAdi.Location = new System.Drawing.Point(189, 95);
            this.UserKAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserKAdi.Name = "UserKAdi";
            this.UserKAdi.Size = new System.Drawing.Size(118, 17);
            this.UserKAdi.TabIndex = 2;
            this.UserKAdi.Text = "User Kullanici Adi";
            // 
            // UserSifre
            // 
            this.UserSifre.AutoSize = true;
            this.UserSifre.Location = new System.Drawing.Point(193, 171);
            this.UserSifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserSifre.Name = "UserSifre";
            this.UserSifre.Size = new System.Drawing.Size(71, 17);
            this.UserSifre.TabIndex = 3;
            this.UserSifre.Text = "User Sifre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 240);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "btn|kullanıcı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 240);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 59);
            this.button2.TabIndex = 5;
            this.button2.Text = "ŞİFREMİ UNUTTUM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(720, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 153);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(423, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 78);
            this.button3.TabIndex = 7;
            this.button3.Text = "çıkış";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserSifre);
            this.Controls.Add(this.UserKAdi);
            this.Controls.Add(this.txtUserSifre);
            this.Controls.Add(this.txtUserKAdi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserLogin";
            this.Text = "UserLogin";
            this.Load += new System.EventHandler(this.UserLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserKAdi;
        private System.Windows.Forms.TextBox txtUserSifre;
        private System.Windows.Forms.Label UserKAdi;
        private System.Windows.Forms.Label UserSifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
    }
}