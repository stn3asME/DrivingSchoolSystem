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
    public partial class BookLessonForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=DrivingSchool;Integrated Security=True");


        public BookLessonForm()
        {
            InitializeComponent();
        }

        private void BookLessonForm_Load(object sender, EventArgs e)
        {
            LoadBookings();

            // Instructor ComboBox Items
            comboInstructor.Items.Add("Mr Smith");
            comboInstructor.Items.Add("Mrs Naidoo");
            comboInstructor.Items.Add("Mr Dlamini");
        }



        public void LoadBookings()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM Bookings", con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        


        // ADD BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand( "INSERT INTO Bookings " + "(BookingID, StudentName, Instructor, LessonDate, Vehicle) " +
                                                 "VALUES (@BookingID, @StudentName, @Instructor, @LessonDate, @Vehicle)", con);

                cmd.Parameters.AddWithValue("@BookingID", txtBookingID.Text);
                cmd.Parameters.AddWithValue("@StudentName", txtStudent.Text);
                cmd.Parameters.AddWithValue("@Instructor", comboInstructor.Text);
                cmd.Parameters.AddWithValue("@LessonDate", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Vehicle", txtVehicle.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Lesson Booked Successfully");

                LoadBookings();

                ClearControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }




        // UPDATE BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE Bookings SET " +
                    "StudentName=@StudentName, " +
                    "Instructor=@Instructor, " +
                    "LessonDate=@LessonDate, " +
                    "Vehicle=@Vehicle " +
                    "WHERE BookingID=@BookingID", con);

                cmd.Parameters.AddWithValue("@BookingID", txtBookingID.Text);
                cmd.Parameters.AddWithValue("@StudentName", txtStudent.Text);
                cmd.Parameters.AddWithValue("@Instructor", comboInstructor.Text);
                cmd.Parameters.AddWithValue("@LessonDate", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Vehicle", txtVehicle.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Booking Updated");

                LoadBookings();
                ClearControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        // DELETE BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM Bookings WHERE BookingID=@BookingID", con);

                cmd.Parameters.AddWithValue( "@BookingID", txtBookingID.Text);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Booking Deleted");
                }
                else
                {
                    MessageBox.Show("Booking Not Found");
                }

                LoadBookings();

                ClearControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }




        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(  @"SELECT * FROM Bookings
                                                         WHERE StudentName LIKE @Search
                                                         OR BookingID LIKE @Search
                                                         OR Instructor LIKE @Search
                                                         OR Vehicle LIKE @Search", con);


                da.SelectCommand.Parameters.AddWithValue("@Search", "%" + textBoxSearch.Text + "%");

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtBookingID.Text = row.Cells[0].Value.ToString();
                txtStudent.Text = row.Cells[1].Value.ToString();
                comboInstructor.Text = row.Cells[2].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells[3].Value);
                txtVehicle.Text = row.Cells[4].Value.ToString();
            }
        }


        private void ClearControls()
        {
            txtBookingID.Clear();
            txtStudent.Clear();
            comboInstructor.Text = "";
            txtVehicle.Clear();

            dateTimePicker1.Value = DateTime.Now;
        }







        // txtBookingID
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtStudent_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }


    }
}
