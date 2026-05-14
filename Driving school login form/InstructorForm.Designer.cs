namespace Driving_school_login_form
{
    partial class InstructorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.searchtextBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteInstrubutton1 = new System.Windows.Forms.Button();
            this.addInstrubutton = new System.Windows.Forms.Button();
            this.updateinstrubutton4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.emailinstrutextBox1 = new System.Windows.Forms.TextBox();
            this.SpecialInstrutextBox2 = new System.Windows.Forms.TextBox();
            this.licencetextBox3 = new System.Windows.Forms.TextBox();
            this.yearsInstrutextBox4 = new System.Windows.Forms.TextBox();
            this.addressinstrutextBox5 = new System.Windows.Forms.TextBox();
            this.phoneinstructextBox6 = new System.Windows.Forms.TextBox();
            this.surnameinstrutextBox7 = new System.Windows.Forms.TextBox();
            this.nameinstrutextBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.instruEmailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearsOfExperienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Driving_school_login_form.dataSet1();
            this.instructorTableAdapter1 = new Driving_school_login_form.dataSet1TableAdapters.InstructorTableAdapter();
            this.instructorTableAdapter3 = new Driving_school_login_form.dataSet1TableAdapters.InstructorTableAdapter();
            this.instructorTableAdapter5 = new Driving_school_login_form.dataSet1TableAdapters.InstructorTableAdapter();
            this.instructorTableAdapter2 = new Driving_school_login_form.dataSet1TableAdapters.InstructorTableAdapter();
            this.instructorTableAdapter4 = new Driving_school_login_form.dataSet1TableAdapters.InstructorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by name , surname , address , phoneNumber";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchtextBox1
            // 
            this.searchtextBox1.Location = new System.Drawing.Point(33, 68);
            this.searchtextBox1.Name = "searchtextBox1";
            this.searchtextBox1.Size = new System.Drawing.Size(278, 20);
            this.searchtextBox1.TabIndex = 1;
            this.searchtextBox1.TextChanged += new System.EventHandler(this.searchtextBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instruEmailAddressDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.phoneNumDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.yearsOfExperienceDataGridViewTextBoxColumn,
            this.licenceTypeDataGridViewTextBoxColumn,
            this.specializationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.instructorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // deleteInstrubutton1
            // 
            this.deleteInstrubutton1.Location = new System.Drawing.Point(759, 389);
            this.deleteInstrubutton1.Name = "deleteInstrubutton1";
            this.deleteInstrubutton1.Size = new System.Drawing.Size(75, 41);
            this.deleteInstrubutton1.TabIndex = 3;
            this.deleteInstrubutton1.Text = "Delete";
            this.deleteInstrubutton1.UseVisualStyleBackColor = true;
            this.deleteInstrubutton1.Click += new System.EventHandler(this.deleteInstrubutton1_Click);
            // 
            // addInstrubutton
            // 
            this.addInstrubutton.Location = new System.Drawing.Point(759, 295);
            this.addInstrubutton.Name = "addInstrubutton";
            this.addInstrubutton.Size = new System.Drawing.Size(75, 41);
            this.addInstrubutton.TabIndex = 4;
            this.addInstrubutton.Text = "Add";
            this.addInstrubutton.UseVisualStyleBackColor = true;
            this.addInstrubutton.Click += new System.EventHandler(this.addInstrubutton_Click);
            // 
            // updateinstrubutton4
            // 
            this.updateinstrubutton4.Location = new System.Drawing.Point(759, 342);
            this.updateinstrubutton4.Name = "updateinstrubutton4";
            this.updateinstrubutton4.Size = new System.Drawing.Size(75, 41);
            this.updateinstrubutton4.TabIndex = 6;
            this.updateinstrubutton4.Text = "Update";
            this.updateinstrubutton4.UseVisualStyleBackColor = true;
            this.updateinstrubutton4.Click += new System.EventHandler(this.updateinstrubutton4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "EmailAddress:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "LicenceType";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "YearsOfExperience";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(416, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Specialization";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(416, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "PhoneNumber:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(318, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Surname:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(174, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Name:";
            // 
            // emailinstrutextBox1
            // 
            this.emailinstrutextBox1.Location = new System.Drawing.Point(15, 342);
            this.emailinstrutextBox1.Name = "emailinstrutextBox1";
            this.emailinstrutextBox1.Size = new System.Drawing.Size(123, 20);
            this.emailinstrutextBox1.TabIndex = 15;
            // 
            // SpecialInstrutextBox2
            // 
            this.SpecialInstrutextBox2.Location = new System.Drawing.Point(419, 397);
            this.SpecialInstrutextBox2.Name = "SpecialInstrutextBox2";
            this.SpecialInstrutextBox2.Size = new System.Drawing.Size(100, 20);
            this.SpecialInstrutextBox2.TabIndex = 16;
            // 
            // licencetextBox3
            // 
            this.licencetextBox3.Location = new System.Drawing.Point(298, 397);
            this.licencetextBox3.Name = "licencetextBox3";
            this.licencetextBox3.Size = new System.Drawing.Size(100, 20);
            this.licencetextBox3.TabIndex = 17;
            // 
            // yearsInstrutextBox4
            // 
            this.yearsInstrutextBox4.Location = new System.Drawing.Point(164, 397);
            this.yearsInstrutextBox4.Name = "yearsInstrutextBox4";
            this.yearsInstrutextBox4.Size = new System.Drawing.Size(100, 20);
            this.yearsInstrutextBox4.TabIndex = 18;
            // 
            // addressinstrutextBox5
            // 
            this.addressinstrutextBox5.Location = new System.Drawing.Point(12, 397);
            this.addressinstrutextBox5.Name = "addressinstrutextBox5";
            this.addressinstrutextBox5.Size = new System.Drawing.Size(100, 20);
            this.addressinstrutextBox5.TabIndex = 19;
            // 
            // phoneinstructextBox6
            // 
            this.phoneinstructextBox6.Location = new System.Drawing.Point(419, 342);
            this.phoneinstructextBox6.Name = "phoneinstructextBox6";
            this.phoneinstructextBox6.Size = new System.Drawing.Size(100, 20);
            this.phoneinstructextBox6.TabIndex = 20;
            // 
            // surnameinstrutextBox7
            // 
            this.surnameinstrutextBox7.Location = new System.Drawing.Point(298, 342);
            this.surnameinstrutextBox7.Name = "surnameinstrutextBox7";
            this.surnameinstrutextBox7.Size = new System.Drawing.Size(100, 20);
            this.surnameinstrutextBox7.TabIndex = 21;
            // 
            // nameinstrutextBox8
            // 
            this.nameinstrutextBox8.Location = new System.Drawing.Point(164, 342);
            this.nameinstrutextBox8.Name = "nameinstrutextBox8";
            this.nameinstrutextBox8.Size = new System.Drawing.Size(112, 20);
            this.nameinstrutextBox8.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(280, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Add the new instructor and upadate information:";
            // 
            // instruEmailAddressDataGridViewTextBoxColumn
            // 
            this.instruEmailAddressDataGridViewTextBoxColumn.DataPropertyName = "InstruEmailAddress";
            this.instruEmailAddressDataGridViewTextBoxColumn.HeaderText = "InstruEmailAddress";
            this.instruEmailAddressDataGridViewTextBoxColumn.Name = "instruEmailAddressDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // phoneNumDataGridViewTextBoxColumn
            // 
            this.phoneNumDataGridViewTextBoxColumn.DataPropertyName = "PhoneNum";
            this.phoneNumDataGridViewTextBoxColumn.HeaderText = "PhoneNum";
            this.phoneNumDataGridViewTextBoxColumn.Name = "phoneNumDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // yearsOfExperienceDataGridViewTextBoxColumn
            // 
            this.yearsOfExperienceDataGridViewTextBoxColumn.DataPropertyName = "YearsOfExperience";
            this.yearsOfExperienceDataGridViewTextBoxColumn.HeaderText = "YearsOfExperience";
            this.yearsOfExperienceDataGridViewTextBoxColumn.Name = "yearsOfExperienceDataGridViewTextBoxColumn";
            // 
            // licenceTypeDataGridViewTextBoxColumn
            // 
            this.licenceTypeDataGridViewTextBoxColumn.DataPropertyName = "LicenceType";
            this.licenceTypeDataGridViewTextBoxColumn.HeaderText = "LicenceType";
            this.licenceTypeDataGridViewTextBoxColumn.Name = "licenceTypeDataGridViewTextBoxColumn";
            // 
            // specializationDataGridViewTextBoxColumn
            // 
            this.specializationDataGridViewTextBoxColumn.DataPropertyName = "Specialization";
            this.specializationDataGridViewTextBoxColumn.HeaderText = "Specialization";
            this.specializationDataGridViewTextBoxColumn.Name = "specializationDataGridViewTextBoxColumn";
            // 
            // instructorBindingSource
            // 
            this.instructorBindingSource.DataMember = "Instructor";
            this.instructorBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "dataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instructorTableAdapter1
            // 
            this.instructorTableAdapter1.ClearBeforeFill = true;
            // 
            // instructorTableAdapter3
            // 
            this.instructorTableAdapter3.ClearBeforeFill = true;
            // 
            // instructorTableAdapter5
            // 
            this.instructorTableAdapter5.ClearBeforeFill = true;
            // 
            // instructorTableAdapter2
            // 
            this.instructorTableAdapter2.ClearBeforeFill = true;
            // 
            // instructorTableAdapter4
            // 
            this.instructorTableAdapter4.ClearBeforeFill = true;
            // 
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nameinstrutextBox8);
            this.Controls.Add(this.surnameinstrutextBox7);
            this.Controls.Add(this.phoneinstructextBox6);
            this.Controls.Add(this.addressinstrutextBox5);
            this.Controls.Add(this.yearsInstrutextBox4);
            this.Controls.Add(this.licencetextBox3);
            this.Controls.Add(this.SpecialInstrutextBox2);
            this.Controls.Add(this.emailinstrutextBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateinstrubutton4);
            this.Controls.Add(this.addInstrubutton);
            this.Controls.Add(this.deleteInstrubutton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchtextBox1);
            this.Controls.Add(this.label1);
            this.Name = "InstructorForm";
            this.Text = "InstructorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchtextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteInstrubutton1;
        private System.Windows.Forms.Button addInstrubutton;
        private System.Windows.Forms.Button updateinstrubutton4;
        private System.Windows.Forms.DataGridViewTextBoxColumn instruEmailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearsOfExperienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource instructorBindingSource;
        private dataSet1 dataSet1;
        private dataSet1TableAdapters.InstructorTableAdapter instructorTableAdapter1;
        private dataSet1TableAdapters.InstructorTableAdapter instructorTableAdapter3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emailinstrutextBox1;
        private System.Windows.Forms.TextBox SpecialInstrutextBox2;
        private System.Windows.Forms.TextBox licencetextBox3;
        private System.Windows.Forms.TextBox yearsInstrutextBox4;
        private System.Windows.Forms.TextBox addressinstrutextBox5;
        private System.Windows.Forms.TextBox phoneinstructextBox6;
        private System.Windows.Forms.TextBox surnameinstrutextBox7;
        private System.Windows.Forms.TextBox nameinstrutextBox8;
        private System.Windows.Forms.Label label10;
        private dataSet1TableAdapters.InstructorTableAdapter instructorTableAdapter5;
        private dataSet1TableAdapters.InstructorTableAdapter instructorTableAdapter2;
        private dataSet1TableAdapters.InstructorTableAdapter instructorTableAdapter4;
    }
}