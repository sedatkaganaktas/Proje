using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proje
{
    public partial class AdminLogin : Form

    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtAdminKAdi.Text;
            string pass = txtAdminSifre.Text;
            con = new SqlConnection("Data Source=DESKTOP-B38R1G5;Initial Catalog=giris;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM dbo.giris where usr='" + txtAdminKAdi.Text + "' AND psw='" + txtAdminSifre.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            con.Close();
        }

        private void txtAdminSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sifremiunuttum git = new sifremiunuttum();
            git.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
