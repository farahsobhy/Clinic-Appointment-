namespace ClinicAppointmentProject.Models
{
    partial class Manage_Patient_forn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Patient_forn));
            pictureBox1 = new PictureBox();
            btn_add = new Button();
            dgv_patient = new DataGridView();
            btn_update = new Button();
            btn_delete = new Button();
            label1 = new Label();
            txt_name = new TextBox();
            txt_age = new TextBox();
            txt_phone = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btn_exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_patient).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 367);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(192, 0, 0);
            btn_add.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(59, 403);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(181, 68);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add Patient";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // dgv_patient
            // 
            dgv_patient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_patient.Location = new Point(689, 37);
            dgv_patient.Name = "dgv_patient";
            dgv_patient.RowHeadersWidth = 51;
            dgv_patient.Size = new Size(575, 476);
            dgv_patient.TabIndex = 2;
            dgv_patient.RowHeaderMouseDoubleClick += dgv_patient_RowHeaderMouseDoubleClick;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(192, 0, 0);
            btn_update.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(347, 403);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(190, 67);
            btn_update.TabIndex = 5;
            btn_update.Text = "Update Patient";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(192, 0, 0);
            btn_delete.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(59, 482);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(190, 57);
            btn_delete.TabIndex = 6;
            btn_delete.Text = "Delete Patient";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(428, 134);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 7;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(531, 139);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(125, 29);
            txt_name.TabIndex = 8;
            // 
            // txt_age
            // 
            txt_age.Location = new Point(531, 212);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(125, 29);
            txt_age.TabIndex = 9;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(531, 287);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(125, 29);
            txt_phone.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(439, 210);
            label2.Name = "label2";
            label2.Size = new Size(55, 31);
            label2.TabIndex = 11;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(428, 282);
            label3.Name = "label3";
            label3.Size = new Size(78, 31);
            label3.TabIndex = 12;
            label3.Text = "Phone";
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(192, 0, 0);
            btn_exit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(347, 482);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(190, 57);
            btn_exit.TabIndex = 13;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Manage_Patient_forn
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1276, 568);
            Controls.Add(btn_exit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_phone);
            Controls.Add(txt_age);
            Controls.Add(txt_name);
            Controls.Add(label1);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(dgv_patient);
            Controls.Add(btn_add);
            Controls.Add(pictureBox1);
            Name = "Manage_Patient_forn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage_Patient_forn";
            Load += Manage_Patient_forn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_patient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_add;
        private DataGridView dgv_patient;
        private Button btn_update;
        private Button btn_delete;
        private Label label1;
        private TextBox txt_name;
        private TextBox txt_age;
        private TextBox txt_phone;
        private Label label2;
        private Label label3;
        private Button btn_exit;
    }
}