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
    public partial class RegisterStudentsForm : Form
    {
        public RegisterStudentsForm()
        {
            InitializeComponent();
        }

        private void RegisterStudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst27DataSet2.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.groupWst27DataSet2.Student);

        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            studentTableAdapter1.FillBySearch(groupWst27DataSet2.Student, searchtextBox.Text);
                 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            studentTableAdapter.Insert(
        txtEmail.Text,
        txtFullNames.Text,
        txtPhone.Text,
        dtpDOB.Value,
        txtAddress.Text
        );

            studentTableAdapter.Fill(groupWst27DataSet2.Student);

            MessageBox.Show("Student Saved");

           
            txtEmail.Clear();
            txtFullNames.Clear();
            txtPhone.Clear();
            txtAddress.Clear();

            
            dtpDOB.Value = DateTime.Now;

            txtEmail.Focus();
        }

        private void emailtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            studentTableAdapter.UpdateStudent(
           txtFullNames.Text,
           txtPhone.Text,
           dtpDOB.Value.ToString("yyyy-MM-dd"),
           txtAddress.Text,
           txtEmail.Text
        );

            studentTableAdapter.Fill(groupWst27DataSet2.Student);

            MessageBox.Show("Student Updated");


            txtEmail.Clear();
            txtFullNames.Clear();
            txtPhone.Clear();
            txtAddress.Clear();

            
            dtpDOB.Value = DateTime.Now;

           
            txtEmail.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            studentTableAdapter.DeleteStudent(txtEmail.Text);

            studentTableAdapter.Fill(groupWst27DataSet2.Student);

            MessageBox.Show("Student Deleted");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtEmail.Text = row.Cells[0].Value?.ToString();
                txtFullNames.Text = row.Cells[1].Value?.ToString();
                txtPhone.Text = row.Cells[2].Value?.ToString();
                dtpDOB.Value = Convert.ToDateTime(row.Cells[3].Value);
                txtAddress.Text = row.Cells[4].Value?.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
