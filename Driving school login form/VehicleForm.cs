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
    public partial class VehicleForm : Form
    {
        public VehicleForm()
        {
            InitializeComponent();
        }

        private void txttextBox1_TextChanged(object sender, EventArgs e)
        {
            vehicleTableAdapter2.FillBySearch(dataSet1.Vehicle, txttextBox1.Text); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataSet1.VehicleRow existingRow = dataSet1.Vehicle.FindByVehicleID(VehicleIDtextBox1.Text);

                if (existingRow != null)
                {
                    MessageBox.Show("Vehicle with ID " + VehicleIDtextBox1.Text + " already exists!",
                        "Duplicate ID",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Stop here dont insert
                }


                vehicleTableAdapter2.InsertNewVehicle(VehicleIDtextBox1.Text, vehicletypetextBox1.Text, trasmtextBox3.Text);
                vehicleTableAdapter2.Fill(dataSet1.Vehicle); // refresh the data grid view
                MessageBox.Show("Vehicle " + VehicleIDtextBox1.Text + " has been added.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding vehicle: " + ex.Message);
            }
        }


        private void ClearFields()
        {
            VehicleIDtextBox1.Clear();
            vehicletypetextBox1.Clear();
            trasmtextBox3.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a vehicle to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string vehicleID = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                int rowAffected = vehicleTableAdapter2.DeleteVehicle(vehicleID);

                if (rowAffected > 0)
                {
                    MessageBox.Show("Vehicle with ID " + vehicleID + " has been deleted.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    vehicleTableAdapter2.Fill(dataSet1.Vehicle);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("No vehicle found.", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting vehicle: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a vehicle to update.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dataSet1.VehicleRow row = (dataSet1.VehicleRow)((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row;

            //row.VehicleID = VehicleIDtextBox1.Text;
            row.VehicleType = vehicletypetextBox1.Text;
            row.TransmissionType = trasmtextBox3.Text;

            vehicleTableAdapter2.Update(dataSet1.Vehicle);
            MessageBox.Show("Vehicle with ID " + VehicleIDtextBox1.Text + " has been updated.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();

            try
            {
                 int rowAffected = vehicleTableAdapter2.UpdateInfo(VehicleIDtextBox1.Text,vehicletypetextBox1.Text,trasmtextBox3.Text);

                if (rowAffected > 0)
                {
                    MessageBox.Show("Vehicle " + VehicleIDtextBox1.Text + " updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh grid
                    vehicleTableAdapter2.Fill(dataSet1.Vehicle);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("No vehicle found with that ID.", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating vehicle: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataSet1.VehicleRow row = (dataSet1.VehicleRow)((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row;

                //VehicleIDtextBox1.Text = row.VehicleID;
                vehicletypetextBox1.Text = row.VehicleType;
                trasmtextBox3.Text = row.TransmissionType;
            }
        }
    }
}
