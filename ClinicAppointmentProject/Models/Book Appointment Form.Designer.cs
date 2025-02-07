namespace ClinicAppointmentProject.Models
{
    partial class Book_Appointment_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Appointment_Form));
            patient = new Label();
            txt_doctor = new TextBox();
            cmb_patient = new ComboBox();
            btn_book = new Button();
            label2 = new Label();
            label3 = new Label();
            dtpDate = new DateTimePicker();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btn_showprofile = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // patient
            // 
            patient.AutoSize = true;
            patient.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patient.ForeColor = Color.FromArgb(0, 0, 192);
            patient.Location = new Point(21, 442);
            patient.Name = "patient";
            patient.Size = new Size(85, 31);
            patient.TabIndex = 0;
            patient.Text = "Patient";
            // 
            // txt_doctor
            // 
            txt_doctor.Location = new Point(130, 511);
            txt_doctor.Name = "txt_doctor";
            txt_doctor.Size = new Size(163, 29);
            txt_doctor.TabIndex = 1;
            // 
            // cmb_patient
            // 
            cmb_patient.FormattingEnabled = true;
            cmb_patient.Location = new Point(130, 447);
            cmb_patient.Name = "cmb_patient";
            cmb_patient.Size = new Size(163, 29);
            cmb_patient.TabIndex = 2;
            // 
            // btn_book
            // 
            btn_book.BackColor = Color.FromArgb(192, 0, 0);
            btn_book.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_book.ForeColor = Color.White;
            btn_book.Location = new Point(230, 646);
            btn_book.Name = "btn_book";
            btn_book.Size = new Size(159, 54);
            btn_book.TabIndex = 3;
            btn_book.Text = "Book";
            btn_book.UseVisualStyleBackColor = false;
            btn_book.Click += btn_book_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(23, 506);
            label2.Name = "label2";
            label2.Size = new Size(83, 31);
            label2.TabIndex = 4;
            label2.Text = "Doctor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(23, 564);
            label3.Name = "label3";
            label3.Size = new Size(62, 31);
            label3.TabIndex = 5;
            label3.Text = "Date";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(130, 566);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(163, 29);
            dtpDate.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(377, 357);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(79, 18);
            label1.Name = "label1";
            label1.Size = new Size(237, 31);
            label1.TabIndex = 9;
            label1.Text = "Book an Appointment";
            // 
            // btn_showprofile
            // 
            btn_showprofile.BackColor = Color.FromArgb(192, 0, 0);
            btn_showprofile.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_showprofile.ForeColor = Color.White;
            btn_showprofile.Location = new Point(23, 642);
            btn_showprofile.Name = "btn_showprofile";
            btn_showprofile.Size = new Size(164, 58);
            btn_showprofile.TabIndex = 10;
            btn_showprofile.Text = "Show Profile";
            btn_showprofile.UseVisualStyleBackColor = false;
            btn_showprofile.Click += btn_showprofile_Click;
            // 
            // Book_Appointment_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(419, 712);
            Controls.Add(btn_showprofile);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dtpDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_book);
            Controls.Add(cmb_patient);
            Controls.Add(txt_doctor);
            Controls.Add(patient);
            Name = "Book_Appointment_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book_Appointment_Form";
            Load += Book_Appointment_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label patient;
        private TextBox txt_doctor;
        private ComboBox cmb_patient;
        private Button btn_book;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpDate;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_showprofile;
    }
}