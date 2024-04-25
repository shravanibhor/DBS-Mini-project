using Oracle.ManagedDataAccess.Client;
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
    public partial class Form12 : Form
    {
        OracleConnection conn;
        public Form12()
        {
            InitializeComponent();
        }
        public void ConnectDB()
        {
            conn = new OracleConnection("Data Source=localhost:1521;Persist Security Info=True;User ID=System;Password=Shravani123");
            conn.Open();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB();
            try
            {
                // Validate and parse the customer ID from textBox1
                if (!int.TryParse(textBox1.Text, out int cid))
                {
                    MessageBox.Show("Invalid customer ID. Please enter a valid integer.");
                    return;
                }

                // Insert the availed service into the "availed_services" table
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "INSERT INTO availed_services (cid, servicetype) VALUES (:cid, :servicetype)";
                command.Parameters.Add("cid", OracleDbType.Int64).Value = Convert.ToInt64(textBox1.Text);
                command.Parameters.Add("servicetype", OracleDbType.Varchar2).Value = "spa";

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Spa service availed successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to avail spa service!");
                }

                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectDB();
            try
            {
                // Validate and parse the customer ID from textBox1
                if (!int.TryParse(textBox1.Text, out int cid))
                {
                    MessageBox.Show("Invalid customer ID. Please enter a valid integer.");
                    return;
                }

                // Insert the availed service into the "availed_services" table
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "INSERT INTO availed_services (cid, servicetype) VALUES (:cid, 'sauna')";
                command.Parameters.Add("cid", OracleDbType.Int64).Value = Convert.ToInt64(textBox1.Text);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sauna service availed successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to avail sauna service!");
                }

                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
