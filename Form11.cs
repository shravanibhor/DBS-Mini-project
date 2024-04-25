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
    public partial class Form11 : Form
    {
        OracleConnection conn;
        public Form11()
        {
            InitializeComponent();
        }
        public void ConnectDB()
        {
            conn = new OracleConnection("Data Source=localhost:1521;Persist Security Info=True;User ID=System;Password=Shravani123");
            conn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
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

                // Determine the vehicle type based on the selected radio button
                string vehicleType = "";
                if (radioButton1.Checked)
                {
                    vehicleType = "Two-wheeler";
                }
                else if (radioButton2.Checked)
                {
                    vehicleType = "Sedan";
                }
                else if (radioButton3.Checked)
                {
                    vehicleType = "SUV";
                }
                else
                {
                    MessageBox.Show("Please select a vehicle type.");
                    return;
                }

                // Insert the rented vehicle into the "rented_vehicle" table
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "INSERT INTO rented_vehicle (cid, vehicle_type) VALUES (:cid, :vehicle_type)";
                command.Parameters.Add("cid", OracleDbType.Int64).Value = Convert.ToInt64(textBox1.Text);
                command.Parameters.Add("vehicle_type", OracleDbType.Varchar2).Value = vehicleType;

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Vehicle rented successfully for 1 day i.e 24hrs, please collect it from Hotel Wheel Renatls");
                }
                else
                {
                    MessageBox.Show("Failed to rent vehicle!");
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
