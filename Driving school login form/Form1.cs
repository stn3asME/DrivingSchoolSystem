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

namespace Driving_school_login_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            string connstring =  "Data Source=146.230.177.46;Initial Catalog=GroupWst27;Persist Security Info=True;User ID=GroupWst27;Password=mhfd5;";


            using (SqlConnection conn = new SqlConnection(connstring))
            {

                try
                {
                    string query = "Select  1 FROM staff WHERE   email=@user  AND password=@pass ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        // getting values from textb0x
                        cmd.Parameters.AddWithValue("@user", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", textBox3.Text.Trim());


                        conn.Open();


                        // SqlDataReader reader = cmd.ExecuteReader();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            // Data found → login success
                            MessageBox.Show("Login successful");
                        }
                        else
                        {
                            // No data → login failed
                            MessageBox.Show("wrong password or username");
                        }
                        // reader.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //Console.WriteLine(ex.ToString());
                }
                conn.Close();
            }



            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
