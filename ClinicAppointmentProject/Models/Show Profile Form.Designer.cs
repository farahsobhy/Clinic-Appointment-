namespace ClinicAppointmentProject.Models
{
    partial class Show_Profile_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_Profile_Form));
            lblusername = new Label();
            label2 = new Label();
            btn_edit = new Button();
            pictureBox1 = new PictureBox();
            btn_exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblusername.ForeColor = Color.FromArgb(0, 0, 192);
            lblusername.Location = new Point(519, 108);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(50, 31);
            lblusername.TabIndex = 0;
            lblusername.Text = "      ";
            lblusername.Click += lblusername_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(556, 183);
            label2.Name = "label2";
            label2.Size = new Size(50, 31);
            label2.TabIndex = 1;
            label2.Text = "      ";
            label2.Click += label2_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(192, 0, 0);
            btn_edit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_edit.ForeColor = Color.White;
            btn_edit.Location = new Point(536, 312);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(94, 40);
            btn_edit.TabIndex = 4;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 323);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(192, 0, 0);
            btn_exit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(536, 388);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(94, 40);
            btn_exit.TabIndex = 6;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Show_Profile_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_exit);
            Controls.Add(pictureBox1);
            Controls.Add(btn_edit);
            Controls.Add(label2);
            Controls.Add(lblusername);
            Name = "Show_Profile_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show_Profile_Form";
            Load += Show_Profile_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblusername;
        private Label label2;
        private Button btn_edit;
        private PictureBox pictureBox1;
        private Button btn_exit;
    }
}