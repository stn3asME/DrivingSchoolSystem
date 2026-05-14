using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_school_login_form
{
    public partial class InstructorForm : Form
    {
        public InstructorForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchtextBox1_TextChanged(object sender, EventArgs e)
        {
            instructorTableAdapter3.FillBySearch(dataSet1.Instructor, searchtextBox1.Text);

        }

        private void addInstrubutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if email already exists in dataset
                dataSet1.InstructorRow existingRow = dataSet1.Instructor.FindByInstruEmailAddress(emailinstrutextBox1.Text);

                if (existingRow != null)
                {
                    MessageBox.Show("Instructor with email " + emailinstrutextBox1.Text + " already exists!",
                        "Duplicate Email",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Stop here dont insert
                }


                instructorTableAdapter5.InsertNewInstructor(emailinstrutextBox1.Text, nameinstrutextBox8.Text, surnameinstrutextBox7.Text, phoneinstructextBox6.Text, addressinstrutextBox5.Text, Convert.ToInt32(yearsInstrutextBox4.Text), licencetextBox3.Text, SpecialInstrutextBox2.Text);// insert new row
                instructorTableAdapter5.Fill(dataSet1.Instructor); // refresh the data grid view

                MessageBox.Show("Customer " + nameinstrutextBox8.Text + " " + surnameinstrutextBox7.Text +
                        " has been added.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding instructor: " + ex.Message);
            }

         }

        private void deleteInstrubutton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select an instructor to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                // Get email from selected row
                string email = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                int rowAffected = instructorTableAdapter5.DeleteInstructor(email);

                if (rowAffected > 0)
                {
                    MessageBox.Show("Instructor with email " + email + " has been deleted.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the grid
                    instructorTableAdapter5.Fill(dataSet1.Instructor);

                    // Clear textboxes
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("No instructor found.", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting instructor: " + ex.Message);
            }
        }

        private void updateinstrubutton4_Click(object sender, EventArgs e)
        {
            // Check a row is selected
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select an instructor to update.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataSet1.InstructorRow row = (dataSet1.InstructorRow)((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row;

           
            row.Name = nameinstrutextBox8.Text;
            row.Surname = surnameinstrutextBox7.Text;
            row.PhoneNum = phoneinstructextBox6.Text;
            row.Address = addressinstrutextBox5.Text;
            row.YearsOfExperience = Convert.ToInt32(yearsInstrutextBox4.Text);
            row.LicenceType = licencetextBox3.Text;
            row.Specialization = SpecialInstrutextBox2.Text;

            try
            {
                int rowAffected = instructorTableAdapter5.UpdateInfo(
                    nameinstrutextBox8.Text,
                    surnameinstrutextBox7.Text,
                    phoneinstructextBox6.Text,
                    addressinstrutextBox5.Text,
                    Convert.ToInt32(yearsInstrutextBox4.Text),
                    licencetextBox3.Text,
                    SpecialInstrutextBox2.Text,
                    emailinstrutextBox1.Text    // ← WHERE clause (PK last)
                );

                if (rowAffected > 0)
                {
                    MessageBox.Show("Instructor " + nameinstrutextBox8.Text + " updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh grid
                    instructorTableAdapter5.Fill(dataSet1.Instructor);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("No instructor found with that email.", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating instructor: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataSet1.InstructorRow row = (dataSet1.InstructorRow)((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row;

                emailinstrutextBox1.Text = row.InstruEmailAddress;
                nameinstrutextBox8.Text = row.Name;
                surnameinstrutextBox7.Text = row.Surname;
                phoneinstructextBox6.Text = row.PhoneNum;
                addressinstrutextBox5.Text = row.Address;
                yearsInstrutextBox4.Text = row.YearsOfExperience.ToString();
                licencetextBox3.Text = row.LicenceType;
                SpecialInstrutextBox2.Text = row.Specialization;
            }
        }
        private void ClearFields()
        {
            emailinstrutextBox1.Clear();
            nameinstrutextBox8.Clear();
            surnameinstrutextBox7.Clear();
            phoneinstructextBox6.Clear();
            addressinstrutextBox5.Clear();
            yearsInstrutextBox4.Clear();
            licencetextBox3.Clear();
            SpecialInstrutextBox2.Clear();
        }
    }
}
