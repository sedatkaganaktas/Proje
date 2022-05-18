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
    public partial class EducatorLogin : Form
    {
        public EducatorLogin()
        {
            InitializeComponent();
        }
        SqlConnection coc;
        SqlCommand cd;
        SqlDataReader db;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtEducatorKAdi.Text;
            string pass = txtEducatorSifre.Text;
            coc = new SqlConnection("Data Source=DESKTOP-B38R1G5;Initial Catalog=giris;Integrated Security=True");
            cd = new SqlCommand();
            coc.Open();
            cd.Connection = coc;
            cd.CommandText = "SELECT * FROM giris where usr='" + txtEducatorKAdi.Text + "' AND psw='" + txtEducatorSifre.Text + "'";
            db = cd.ExecuteReader();
            if (db.Read())
            {
                egitmensoru egt = new egitmensoru();
                egt.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            coc.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sifremiunuttum sre = new sifremiunuttum();
            sre.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();

        }

        private void EducatorLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
