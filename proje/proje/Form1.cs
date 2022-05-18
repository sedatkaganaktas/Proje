using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AdminLogin_click(object sender, EventArgs e)
        {
            AdminLogin goster = new AdminLogin();
            goster.Show();
            this.Hide();
        }

        private void UserLogin_click(object sender, EventArgs e)
        {
            UserLogin goster = new UserLogin();
            goster.Show(); this.Hide();
        }

        private void EducatorLogin_click(object sender, EventArgs e)
        {
            EducatorLogin goster = new EducatorLogin();
            goster.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
