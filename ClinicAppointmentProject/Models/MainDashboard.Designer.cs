namespace ClinicAppointmentProject.Models
{
    partial class MainDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblWelcome = new Label();
            btn_managepatient = new Button();
            btn_logout = new Button();
            btn_viewappointment = new Button();
            btn_viewReports = new Button();
            btn_showprofile = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(65, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 254);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(440, 159);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(735, 533);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(192, 0, 0);
            lblWelcome.Location = new Point(78, 32);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(50, 31);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "      ";
            // 
            // btn_managepatient
            // 
            btn_managepatient.BackColor = Color.FromArgb(192, 0, 0);
            btn_managepatient.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_managepatient.ForeColor = Color.White;
            btn_managepatient.Location = new Point(65, 458);
            btn_managepatient.Name = "btn_managepatient";
            btn_managepatient.Size = new Size(252, 68);
            btn_managepatient.TabIndex = 3;
            btn_managepatient.Text = "Manage Patient";
            btn_managepatient.UseVisualStyleBackColor = false;
            btn_managepatient.Click += btn_managepatient_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(192, 0, 0);
            btn_logout.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(65, 709);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(252, 68);
            btn_logout.TabIndex = 4;
            btn_logout.Text = "Log out";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_viewappointment
            // 
            btn_viewappointment.BackColor = Color.FromArgb(192, 0, 0);
            btn_viewappointment.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_viewappointment.ForeColor = Color.White;
            btn_viewappointment.Location = new Point(65, 624);
            btn_viewappointment.Name = "btn_viewappointment";
            btn_viewappointment.Size = new Size(252, 68);
            btn_viewappointment.TabIndex = 5;
            btn_viewappointment.Text = "Mange Appointments";
            btn_viewappointment.UseVisualStyleBackColor = false;
            btn_viewappointment.Click += btn_viewappointment_Click;
            // 
            // btn_viewReports
            // 
            btn_viewReports.BackColor = Color.FromArgb(192, 0, 0);
            btn_viewReports.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_viewReports.ForeColor = Color.White;
            btn_viewReports.Location = new Point(65, 541);
            btn_viewReports.Name = "btn_viewReports";
            btn_viewReports.Size = new Size(252, 68);
            btn_viewReports.TabIndex = 6;
            btn_viewReports.Text = "View Reports";
            btn_viewReports.UseVisualStyleBackColor = false;
            btn_viewReports.Click += btn_viewReports_Click;
            // 
            // btn_showprofile
            // 
            btn_showprofile.BackColor = Color.FromArgb(192, 0, 0);
            btn_showprofile.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_showprofile.ForeColor = Color.White;
            btn_showprofile.Location = new Point(65, 367);
            btn_showprofile.Name = "btn_showprofile";
            btn_showprofile.Size = new Size(252, 68);
            btn_showprofile.TabIndex = 7;
            btn_showprofile.Text = "Show Profile";
            btn_showprofile.UseVisualStyleBackColor = false;
            btn_showprofile.Click += btn_showprofile_Click;
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1204, 789);
            Controls.Add(btn_showprofile);
            Controls.Add(btn_viewReports);
            Controls.Add(btn_viewappointment);
            Controls.Add(btn_logout);
            Controls.Add(btn_managepatient);
            Controls.Add(lblWelcome);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "MainDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainDashboard";
            Load += MainDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblWelcome;
        private Button btn_managepatient;
        private Button btn_logout;
        private Button btn_viewappointment;
        private Button btn_viewReports;
        private Button btn_showprofile;
    }
}