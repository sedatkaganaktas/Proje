using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace proje
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        SqlConnection cok;
        SqlDataReader dt;
        SqlCommand cos;
        private void button2_Click(object sender, EventArgs e)
        {
            sifremiunuttum sfr = new sifremiunuttum();
            sfr.Show();
            this.Hide();

        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUserKAdi.Text;
            string pass = txtUserSifre.Text;
            cok = new SqlConnection("Data Source=DESKTOP-B38R1G5;Initial Catalog=giris;Integrated Security=True");
            cos = new SqlCommand();
            cok.Open();
            cos.Connection = cok;
            cos.CommandText = "SELECT * FROM giris where usr='" + txtUserKAdi.Text + "' AND psw='" + txtUserSifre.Text + "'";
            dt = cos.ExecuteReader();
            if (dt.Read())
            {
                uniteler unt = new uniteler();
                unt.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            cok.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();


        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
