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
using Driving_School_System_Forms;
using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;

namespace Driving_school_login_form
{
    public partial class FormLogin : Form
    {
        public FormLogin()
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
            string connstring = " Data Source=146.230.177.46;Initial Catalog=GroupWst27;Persist Security Info=True;User ID=GroupWst27;Password=mhfd5";


            using (SqlConnection conn = new SqlConnection(connstring))
            {

                try
                {
                    string query = "Select  1 FROM AdminStaff WHERE   StafEmailAddress=@email  AND Password=@pass";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        // getting values from textb0x
                        cmd.Parameters.AddWithValue("@email", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", textBox3.Text.Trim());


                        conn.Open();




                        object result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            // Data found → login success
                            // MessageBox.Show("Login successful");
                            //show results by role.
                            MessageBox.Show("wrong Password or username");
                        }
                        else
                        {
                            if (checkRole(connstring, "receptionist"))
                            {
                                ReceptionistForm rec = new ReceptionistForm();
                                rec.Show();
                                this.Hide();
                            }
                            else if(checkRole(connstring, "Instructor"))
                            {
                                InstructorForm ins= new InstructorForm();
                                ins.Show();
                                this.Hide();
                            }
                            else if(checkRole(connstring, "Manager"))
                            {
                                ManagerForm man = new ManagerForm();
                                man.Show();
                                this.Hide();
                               
                            }









                        }

                    }
                }
                


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



            
        }
        private bool checkRole(String connstring, String role)
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {

                try
                {
                    string query = "Select  1 FROM AdminStaff WHERE   Role=@role and StafEmailAddress=@email  AND Password=@pass";

                    using (SqlCommand cmd2 = new SqlCommand(query, conn))
                    {

                        // getting values from textb0x
                        cmd2.Parameters.AddWithValue("@role".ToLower(), role.Trim().ToLower());
                        cmd2.Parameters.AddWithValue("@email", textBox1.Text.Trim());
                        cmd2.Parameters.AddWithValue("@pass", textBox3.Text.Trim());

                        conn.Open();




                        object result = cmd2.ExecuteScalar();
                        if (result != null)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                   
                }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
