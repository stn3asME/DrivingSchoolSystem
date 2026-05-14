using Driving_School_System_Forms;
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
using static System.Collections.Specialized.BitVector32;

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
                    string query = "Select  Role FROM AdminStaff WHERE   StafEmailAddress=@email  AND Password=@pass ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        // getting values from textb0x
                        cmd.Parameters.AddWithValue("@email", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", textBox3.Text.Trim());


                        conn.Open();


                   
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            // Data found → login success
                            MessageBox.Show("Login successful");
                            //show results by role.
                            string role = result.ToString();
                            Session.Role = role;

                            MessageBox.Show("Login successful: " + role);

                            OpenRoleForm(role);

                            this.Hide();
                        }
                        else
                        {
                            // incorrect data/ → login failed
                            MessageBox.Show("wrong password or username");
                        }
                        

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }



            
        }
        private void OpenRoleForm(string role)
        {
            Form nextForm = null;

            switch (role)
            {
                case "Receptionist":
                    nextForm = new ReceptionistForm();
                    break;

                case "Instructor":
                    nextForm = new InstructorForm();
                    break;

                case "Manager":
                    nextForm = new ManagerForm();
                    break;

                default:
                    MessageBox.Show("Unknown role: " + role);
                    return;
            }

            nextForm.Show();
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
    public static class Session
    {
        public static string Role;
    }
}
