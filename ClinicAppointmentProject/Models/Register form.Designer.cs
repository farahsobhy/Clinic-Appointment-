namespace ClinicAppointmentProject.Models
{
    partial class Register_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_form));
            label3 = new Label();
            pictureBox1 = new PictureBox();
            Register_btn = new Button();
            pass_txt = new TextBox();
            username_txt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            passconfirm_txt = new TextBox();
            label5 = new Label();
            loginreg_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Calligraphy", 16F);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(70, 9);
            label3.Name = "label3";
            label3.Size = new Size(307, 36);
            label3.TabIndex = 13;
            label3.Text = "Clinic Appointment ";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Register_btn
            // 
            Register_btn.BackColor = SystemColors.ButtonHighlight;
            Register_btn.Font = new Font("Segoe UI", 14F);
            Register_btn.ForeColor = Color.FromArgb(0, 0, 192);
            Register_btn.Location = new Point(268, 481);
            Register_btn.Name = "Register_btn";
            Register_btn.Size = new Size(109, 45);
            Register_btn.TabIndex = 11;
            Register_btn.Text = "Register";
            Register_btn.UseVisualStyleBackColor = false;
            Register_btn.Click += Register_btn_Click;
            // 
            // pass_txt
            // 
            pass_txt.Location = new Point(239, 359);
            pass_txt.Name = "pass_txt";
            pass_txt.Size = new Size(184, 29);
            pass_txt.TabIndex = 10;
            pass_txt.UseSystemPasswordChar = true;
            pass_txt.TextChanged += pass_txt_TextChanged;
            // 
            // username_txt
            // 
            username_txt.Location = new Point(239, 304);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(184, 29);
            username_txt.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(25, 351);
            label2.Name = "label2";
            label2.Size = new Size(128, 37);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(25, 296);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 7;
            label1.Text = "User Name";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(3, 413);
            label4.Name = "label4";
            label4.Size = new Size(230, 37);
            label4.TabIndex = 14;
            label4.Text = "Confirm Password";
            // 
            // passconfirm_txt
            // 
            passconfirm_txt.Location = new Point(239, 413);
            passconfirm_txt.Name = "passconfirm_txt";
            passconfirm_txt.Size = new Size(184, 29);
            passconfirm_txt.TabIndex = 15;
            passconfirm_txt.UseSystemPasswordChar = true;
            passconfirm_txt.TextChanged += passconfirm_txt_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.ForeColor = Color.FromArgb(128, 64, 64);
            label5.Location = new Point(12, 575);
            label5.Name = "label5";
            label5.Size = new Size(318, 37);
            label5.TabIndex = 16;
            label5.Text = "Already have an account?";
            label5.Click += label5_Click;
            // 
            // loginreg_btn
            // 
            loginreg_btn.BackColor = SystemColors.ButtonHighlight;
            loginreg_btn.Font = new Font("Segoe UI", 14F);
            loginreg_btn.ForeColor = Color.FromArgb(0, 0, 192);
            loginreg_btn.Location = new Point(268, 625);
            loginreg_btn.Name = "loginreg_btn";
            loginreg_btn.Size = new Size(109, 45);
            loginreg_btn.TabIndex = 17;
            loginreg_btn.Text = "Login";
            loginreg_btn.UseVisualStyleBackColor = false;
            loginreg_btn.Click += loginreg_btn_Click;
            // 
            // Register_form
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(500, 699);
            Controls.Add(loginreg_btn);
            Controls.Add(label5);
            Controls.Add(passconfirm_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(Register_btn);
            Controls.Add(pass_txt);
            Controls.Add(username_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register_form";
            Load += Register_form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private PictureBox pictureBox1;
        private Button Register_btn;
        private TextBox pass_txt;
        private TextBox username_txt;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox passconfirm_txt;
        private Label label5;
        private Button loginreg_btn;
    }
}