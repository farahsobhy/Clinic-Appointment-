namespace ClinicAppointmentProject.Models
{
    partial class View_Appointment_Form
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
            dataGridViewAppointments = new DataGridView();
            btn_exit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAppointments
            // 
            dataGridViewAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAppointments.Location = new Point(39, 30);
            dataGridViewAppointments.Name = "dataGridViewAppointments";
            dataGridViewAppointments.RowHeadersWidth = 51;
            dataGridViewAppointments.Size = new Size(605, 382);
            dataGridViewAppointments.TabIndex = 0;
            dataGridViewAppointments.CellContentClick += dataGridViewAppointments_CellContentClick;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(192, 0, 0);
            btn_exit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(472, 432);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(111, 40);
            btn_exit.TabIndex = 11;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // View_Appointment_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 484);
            Controls.Add(btn_exit);
            Controls.Add(dataGridViewAppointments);
            Name = "View_Appointment_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View_Appointment_Form";
            Load += View_Appointment_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewAppointments;
        private Button btn_exit;
    }
}