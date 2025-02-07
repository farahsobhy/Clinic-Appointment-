namespace ClinicAppointmentProject.Models
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            lblusername = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_refresh = new Button();
            lblTotalPatients = new Label();
            lblTotalAppiontments = new Label();
            lblCompletedAppointments = new Label();
            btn_exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblusername.ForeColor = Color.FromArgb(0, 0, 192);
            lblusername.Location = new Point(301, 9);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(93, 31);
            lblusername.TabIndex = 1;
            lblusername.Text = "Reports";
            lblusername.Click += lblusername_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(212, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(75, 295);
            label1.Name = "label1";
            label1.Size = new Size(153, 31);
            label1.TabIndex = 3;
            label1.Text = "Total Patients";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(48, 350);
            label2.Name = "label2";
            label2.Size = new Size(217, 31);
            label2.TabIndex = 4;
            label2.Text = "Total Appiontments";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(35, 410);
            label3.Name = "label3";
            label3.Size = new Size(279, 31);
            label3.TabIndex = 5;
            label3.Text = "Completed Appiontments";
            // 
            // btn_refresh
            // 
            btn_refresh.BackColor = Color.FromArgb(192, 0, 0);
            btn_refresh.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_refresh.ForeColor = Color.White;
            btn_refresh.Location = new Point(154, 472);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(111, 40);
            btn_refresh.TabIndex = 6;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // lblTotalPatients
            // 
            lblTotalPatients.AutoSize = true;
            lblTotalPatients.BorderStyle = BorderStyle.FixedSingle;
            lblTotalPatients.Location = new Point(358, 295);
            lblTotalPatients.Name = "lblTotalPatients";
            lblTotalPatients.Size = new Size(36, 23);
            lblTotalPatients.TabIndex = 7;
            lblTotalPatients.Text = "      ";
            // 
            // lblTotalAppiontments
            // 
            lblTotalAppiontments.AutoSize = true;
            lblTotalAppiontments.BorderStyle = BorderStyle.FixedSingle;
            lblTotalAppiontments.Location = new Point(358, 358);
            lblTotalAppiontments.Name = "lblTotalAppiontments";
            lblTotalAppiontments.Size = new Size(48, 23);
            lblTotalAppiontments.TabIndex = 8;
            lblTotalAppiontments.Text = "         ";
            // 
            // lblCompletedAppointments
            // 
            lblCompletedAppointments.AutoSize = true;
            lblCompletedAppointments.BorderStyle = BorderStyle.FixedSingle;
            lblCompletedAppointments.Location = new Point(358, 418);
            lblCompletedAppointments.Name = "lblCompletedAppointments";
            lblCompletedAppointments.Size = new Size(48, 23);
            lblCompletedAppointments.TabIndex = 9;
            lblCompletedAppointments.Text = "         ";
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(192, 0, 0);
            btn_exit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(383, 472);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(111, 40);
            btn_exit.TabIndex = 10;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(655, 541);
            Controls.Add(btn_exit);
            Controls.Add(lblCompletedAppointments);
            Controls.Add(lblTotalAppiontments);
            Controls.Add(lblTotalPatients);
            Controls.Add(btn_refresh);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lblusername);
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReportsForm";
            Load += ReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblusername;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_refresh;
        private Label lblTotalPatients;
        private Label lblTotalAppiontments;
        private Label lblCompletedAppointments;
        private Button btn_exit;
    }
}