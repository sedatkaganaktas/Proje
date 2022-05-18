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
using System.IO;

namespace proje
{
    public partial class egitmensoru : Form
    {
        public egitmensoru()
        {
            InitializeComponent();
        }
        string resimadres;
        public void sorual()
        {
            openFileDialog1.Title = "soru seç";
            openFileDialog1.Filter = "Jpeg Dosyaları(*.jpg)|*.jpg|Gif dosyalari(*.gif)|*.gif";

        }
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-B38R1G5;Initial Catalog=giris;Integrated Security=True");

        private void egitmensoru_Load(object sender, EventArgs e)
        {
            sorual();

        }

        private void btn_soru_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            resimadres = openFileDialog1.FileName;
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO  Soru (ResimYolu) VALUES (@p1)", bgl);
            bgl.Open();
            cmd.Parameters.AddWithValue("@p1", resimadres);

            int cm = cmd.ExecuteNonQuery();
            if (cm != 0)
            {
                bgl.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
