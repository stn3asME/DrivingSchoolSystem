namespace Driving_school_login_form
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sTUDENTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookLessonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNSTRUCTORSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sCHEDULEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.log_out = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTUDENTSToolStripMenuItem,
            this.iNSTRUCTORSToolStripMenuItem,
            this.sCHEDULEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sTUDENTSToolStripMenuItem
            // 
            this.sTUDENTSToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sTUDENTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerStudentToolStripMenuItem,
            this.bookLessonToolStripMenuItem});
            this.sTUDENTSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sTUDENTSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.sTUDENTSToolStripMenuItem.Name = "sTUDENTSToolStripMenuItem";
            this.sTUDENTSToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.sTUDENTSToolStripMenuItem.Text = "Students";
            // 
            // registerStudentToolStripMenuItem
            // 
            this.registerStudentToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.registerStudentToolStripMenuItem.Name = "registerStudentToolStripMenuItem";
            this.registerStudentToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.registerStudentToolStripMenuItem.Text = "Register Student";
            this.registerStudentToolStripMenuItem.Click += new System.EventHandler(this.registerStudentToolStripMenuItem_Click);
            // 
            // bookLessonToolStripMenuItem
            // 
            this.bookLessonToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bookLessonToolStripMenuItem.Name = "bookLessonToolStripMenuItem";
            this.bookLessonToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.bookLessonToolStripMenuItem.Text = "Book Lesson";
            // 
            // iNSTRUCTORSToolStripMenuItem
            // 
            this.iNSTRUCTORSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateStudentProgressToolStripMenuItem});
            this.iNSTRUCTORSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iNSTRUCTORSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iNSTRUCTORSToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Blue;
            this.iNSTRUCTORSToolStripMenuItem.Name = "iNSTRUCTORSToolStripMenuItem";
            this.iNSTRUCTORSToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.iNSTRUCTORSToolStripMenuItem.Text = "Instructors";
            // 
            // updateStudentProgressToolStripMenuItem
            // 
            this.updateStudentProgressToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateStudentProgressToolStripMenuItem.Name = "updateStudentProgressToolStripMenuItem";
            this.updateStudentProgressToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.updateStudentProgressToolStripMenuItem.Text = "Update Student Progress";
            // 
            // sCHEDULEToolStripMenuItem
            // 
            this.sCHEDULEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewScheduleToolStripMenuItem});
            this.sCHEDULEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sCHEDULEToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sCHEDULEToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sCHEDULEToolStripMenuItem.Name = "sCHEDULEToolStripMenuItem";
            this.sCHEDULEToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.sCHEDULEToolStripMenuItem.Text = "Schedules";
            this.sCHEDULEToolStripMenuItem.Click += new System.EventHandler(this.sCHEDULEToolStripMenuItem_Click);
            // 
            // viewScheduleToolStripMenuItem
            // 
            this.viewScheduleToolStripMenuItem.Name = "viewScheduleToolStripMenuItem";
            this.viewScheduleToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.viewScheduleToolStripMenuItem.Text = "View Schedule";
            // 
            // log_out
            // 
            this.log_out.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.log_out.AutoSize = true;
            this.log_out.BackColor = System.Drawing.SystemColors.HotTrack;
            this.log_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_out.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.log_out.LinkColor = System.Drawing.Color.Transparent;
            this.log_out.Location = new System.Drawing.Point(653, 9);
            this.log_out.Name = "log_out";
            this.log_out.Size = new System.Drawing.Size(55, 13);
            this.log_out.TabIndex = 1;
            this.log_out.TabStop = true;
            this.log_out.Text = "LOG OUT";
            this.log_out.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(714, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(541, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Manage Student";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(680, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Schedule Lesson";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.log_out);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNSTRUCTORSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sCHEDULEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookLessonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentProgressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewScheduleToolStripMenuItem;
        private System.Windows.Forms.LinkLabel log_out;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}