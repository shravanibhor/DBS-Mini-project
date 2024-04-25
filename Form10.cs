using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hotelmanagement1
{
    public partial class Form10 : Form
    {
        OracleConnection conn;
        public Form10()
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

            Form9 form9 = new Form9();
            form9.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                ConnectDB();

                try
                {
                    OracleCommand command2 = conn.CreateCommand();
                    command2.CommandText = "INSERT INTO orders (cid, food_type, food_rate) VALUES (:cid, :food_type, :food_rate)";
                    command2.Parameters.Add("cid", OracleDbType.Int64).Value = Convert.ToInt64(textBox1.Text);
                    command2.Parameters.Add("food_type", OracleDbType.Varchar2).Value = "Btr Chkn";
                    command2.Parameters.Add("food_rate", OracleDbType.Int64).Value = 620;
                    int rowsAffected = command2.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("ok");

                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                    command2.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConnectDB();

            try
            {
                OracleCommand command2 = conn.CreateCommand();
                command2.CommandText = "INSERT INTO orders (cid, food_type, food_rate) VALUES (:cid, :food_type, :food_rate)";
                command2.Parameters.Add("cid", OracleDbType.Int64).Value = Convert.ToInt64(textBox1.Text);
                command2.Parameters.Add("food_type", OracleDbType.Varchar2).Value = "Biryani";
                command2.Parameters.Add("food_rate", OracleDbType.Int64).Value = 1050;
                int rowsAffected = command2.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("ok");

                }
                else
                {
                    MessageBox.Show("Error");
                }

                command2.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConnectDB();

            try
            {
                OracleCommand command2 = conn.CreateCommand();
                command2.CommandText = "INSERT INTO orders (cid, food_type, food_rate) VALUES (:cid, :food_type, :food_rate)";
                command2.Parameters.Add("cid", OracleDbType.Int64).Value = Convert.ToInt64(textBox1.Text);
                command2.Parameters.Add("food_type", OracleDbType.Varchar2).Value = "Plk Paneer";
                command2.Parameters.Add("food_rate", OracleDbType.Int64).Value = 580;
                int rowsAffected = command2.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("ok");

                }
                else
                {
                    MessageBox.Show("Error");
                }

                command2.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ConnectDB();

            try
            {
                OracleCommand command2 = conn.CreateCommand();
                command2.CommandText = "INSERT INTO orders (cid, food_type, food_rate) VALUES (:cid, :food_type, :food_rate)";
                command2.Parameters.Add("cid", OracleDbType.Int64).Value = Convert.ToInt64(textBox1.Text);
                command2.Parameters.Add("food_type", OracleDbType.Varchar2).Value = "Dal Mkhni";
                command2.Parameters.Add("food_rate", OracleDbType.Int64).Value = 480;
                int rowsAffected = command2.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("ok");

                }
                else
                {
                    MessageBox.Show("Error");
                }

                command2.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ConnectDB();

            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "DELETE FROM orders WHERE cid = :cid AND food_type = :foodType";
                command.Parameters.Add("cid", OracleDbType.Int64).Value = Convert.ToInt64(textBox1.Text);
                command.Parameters.Add("foodType", OracleDbType.Varchar2).Value = "Btr Chkn";

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("deleted successfully!");
                }
                else
                {
                    MessageBox.Show("No matching data found to delete!");
                }

                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ConnectDB();

            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "DELETE FROM orders WHERE cid = :cid AND food_type = :foodType";
                command.Parameters.Add("cid", OracleDbType.Int64).Value = Convert.ToInt64(textBox1.Text);
                command.Parameters.Add("foodType", OracleDbType.Varchar2).Value = "Biryani";

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("deleted successfully!");
                }
                else
                {
                    MessageBox.Show("No matching data found to delete!");
                }

                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ConnectDB();

            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "DELETE FROM orders WHERE cid = :cid AND food_type = :foodType";
                command.Parameters.Add("cid", OracleDbType.Int64).Value = Convert.ToInt64(textBox1.Text);
                command.Parameters.Add("foodType", OracleDbType.Varchar2).Value = "Plk Paneer";

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("deleted successfully!");
                }
                else
                {
                    MessageBox.Show("No matching data found to delete!");
                }

                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ConnectDB();

            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "DELETE FROM orders WHERE cid = :cid AND food_type = :foodType";
                command.Parameters.Add("cid", OracleDbType.Int64).Value = Convert.ToInt64(textBox1.Text);
                command.Parameters.Add("foodType", OracleDbType.Varchar2).Value = "Dal Mkhni";

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("deleted successfully!");
                }
                else
                {
                    MessageBox.Show("No matching data found to delete!");
                }

                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB();
            try
            {
                // Generate a unique order ID
                string orderId = Guid.NewGuid().ToString();

                // Insert the order ID and cid into the "customer_order" table
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "INSERT INTO customer_order ( cid,orderid) VALUES (:cid,:orderid)";
                command.Parameters.Add("cid", OracleDbType.Int64).Value = Convert.ToInt64(textBox1.Text);
                command.Parameters.Add("orderId", OracleDbType.Varchar2).Value = orderId;
               

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Order placed successfully! Order ID: " + orderId);
                }
                else
                {
                    MessageBox.Show("Failed to place order!");
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
