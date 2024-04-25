using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelmanagement1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Close();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.Show();
            this.Close();
        }
    }
}
