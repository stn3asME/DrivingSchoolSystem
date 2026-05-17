using Driving_school_login_form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_School_System_Forms
{
    public partial class ReceptionistForm : Form
    {
        public ReceptionistForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterStudentsForm stud = new RegisterStudentsForm();
            stud.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VerifyPayments ver = new VerifyPayments();
            ver.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
