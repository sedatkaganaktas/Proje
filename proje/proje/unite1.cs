

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
    public partial class unite1 : Form
    {
        public unite1()
        {
            InitializeComponent();
        }
        int SORUID;
        string sorucevap;
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-B38R1G5;Initial Catalog=giris;Integrated Security=True");
       

        private void unite1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'girisDataSet3.Soru' table. You can move, or remove it, as needed.
            this.soruTableAdapter.Fill(this.girisDataSet3.Soru);
            // TODO: This line of code loads data into the 'girisDataSet2.Sorular' table. You can move, or remove it, as needed.
            //this.sorularTableAdapter.Fill(this.girisDataSet2.Sorular);
            // TODO: This line of code loads data into the 'girisDataSet1.Table_1' table. You can move, or remove it, as needed.
            this.table_1TableAdapter.Fill(this.girisDataSet1.Table_1);



        }
        int sayac = 20;
        int dogru = 0, yanlis = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("SELECT Cevap FROM Soru Where Id=@p1", bgl);
            bgl.Open();
            cmd.Parameters.AddWithValue("@p1", SORUID);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                sorucevap = Convert.ToString(reader[0]);
                bgl.Close();
            }
            else { bgl.Close(); }
            
                if(textBox1.Text ==sorucevap)
                {
                dogru++;//Doğru sayısını arttır
                textBox1.BackColor = Color.Green;
            }
                else
                {
                yanlis++;

            }
            label4.Text = dogru.ToString();
            label6.Text = yanlis.ToString();
        }

       

      

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            SORUID = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);
            bgl.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Soru WHERE Id=@p1", bgl);
            cmd.Parameters.AddWithValue("@p1", SORUID);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                pictureBox1.ImageLocation = Convert.ToString(reader[1]);
            }
            bgl.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void yanlış_Click(object sender, EventArgs e)
        {

        }
    }
}
