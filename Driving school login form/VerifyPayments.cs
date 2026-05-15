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
    public partial class VerifyPayments : Form
    {
        public VerifyPayments()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void VerifyPayments_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String stu = "";

            stu+= textBox1.Text.ToString()+" ";
            stu+= textBox2.Text.ToString();
            label5.Text = stu;
            label5.Visible = true;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String stu = "";

            stu += textBox1.Text.ToString() + " ";
            stu += textBox2.Text.ToString();
            label5.Text = stu;
            label5.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            String stu = "";

            stu += textBox1.Text.ToString() + " ";
            stu += textBox2.Text.ToString();
            label5.Text = stu;
            label5.Visible = true;
        }
    }
}
