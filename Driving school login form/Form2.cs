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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void sCHEDULEToolStripMenuItem_Click(object sender, EventArgs e)
        {   

        }

        private void Form2_Load(object sender, EventArgs e)
        {
          // Application.Run(new Form2());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Application.Exit();
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void registerStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 registerStudent = new Form3();
            registerStudent.Show();
            this.Hide();

        }
    }
}
