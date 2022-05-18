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
    public partial class uniteler : Form
    {
        public uniteler()
        {
            InitializeComponent();
        }

       
        
            

        private void unite1_Click(object sender, EventArgs e)
        {
            unite1 unite1 = new unite1();
            unite1.Show();
            this.Hide();
        }

        private void uniteler_Load(object sender, EventArgs e)
        {

        }
    }
    }

