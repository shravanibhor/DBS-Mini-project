using hotelmanagement1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelmanagement1.Resources
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("We're currently verifying the availability of Queen Suite Deluxe you've requested. Please take a moment to fill out the form below");
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("We're currently verifying the availability of King Suite Deluxe you've requested. Please take a moment to fill out the form below");
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else if (radioButton3.Checked)
            {
                MessageBox.Show("We're currently verifying the availability of King Suite+Courtyard you've requested. Please take a moment to fill out the form below");
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
        }

        
    }
}
