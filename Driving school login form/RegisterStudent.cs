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

namespace Driving_school_login_form
{

    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            this.Hide();

            if (Session.Role == "Manager")
            {
                ManagerForm m = new ManagerForm();
                m.Show();
            }
            else if (Session.Role == "Receptionist")
            {
                ReceptionistForm r = new ReceptionistForm();
                r.Show();
            }
            else if (Session.Role == "Instructor")
            {
                InstructorForm i = new InstructorForm();
                i.Show();
            }
            else
            {
                MessageBox.Show("Session expired. Please login again.");
                FormLogin login = new FormLogin();
                login.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst27DataSet.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.groupWst27DataSet.Student);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* string fullName = txtName.Text.Trim();
            string phone = txtCellPhone.Text.Trim();
            string address = txtPhysicalAddress.Text.Trim();
            string surname = txtSurname.Text;
            string email = txtEmail.Text.Trim();
            string date_of_birth = txtDOB.Text.Trim(); 

            if (fullName == "" || phone == "" || address == "" || surname == "" || email == "" || date_of_birth == "")
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // 2. Insert into database
            string connstring = " Data Source=146.230.177.46;Initial Catalog=GroupWst27;Persist Security Info=True;User ID=GroupWst27;Password=mhfd5";
            using (SqlConnection con = new SqlConnection(connstring))
            {
                con.Open();

                string query = @"INSERT INTO Student 
                                (FullNames, PhoneNum, Address, StudEmail, DateOfBirth)
                                VALUES 
                                (@FullName, @Phone, @Address, @Email, @Surname, @Date_of_Birth)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FullName", Name);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Email",email );
                    cmd.Parameters.AddWithValue("@Surname", surname);
                    cmd.Parameters.AddWithValue("@Date_of_Birth", date_of_birth);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Student registered successfully!");

                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to register student.");
                    }
                }
            }*/
        }
       /* private void ClearFields()
        {
            txtName.Clear();
            txtCellPhone.Clear();
            txtPhysicalAddress.Clear();
            txtEmail.Clear();
            txtSurname.Clear();
            txtDOB.Clear();
        }*/
    }
}
