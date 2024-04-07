using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace hotelmanagement1
{
    public partial class Form3 : Form
    {
        OracleConnection conn;
        public Form3()
        {
            InitializeComponent();
          
        }
        public void ConnectDB()
        {
            conn = new OracleConnection("Data Source=localhost:1521;Persist Security Info=True;User ID=System;Password=Shravani123");
            conn.Open();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB();
            try { OracleCommand command2 = conn.CreateCommand();
                command2.CommandText = "INSERT INTO customer_login (name, phoneno, email) VALUES (:Name, :Phoneno, :Email)";
                command2.Parameters.Add("Name", OracleDbType.Varchar2).Value = textBox1.Text;
                command2.Parameters.Add("Phoneno", OracleDbType.Int64).Value = Convert.ToInt64(textBox2.Text);
                command2.Parameters.Add("Email", OracleDbType.Varchar2).Value = textBox3.Text;
                int rowsAffected = command2.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                   Form5 form5 = new Form5();
                    form5.Show();
                    this.Close();
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
           finally
           {
               conn.Close();
           }
       }


        }

       
    }

