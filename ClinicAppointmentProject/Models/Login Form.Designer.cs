namespace ClinicAppointmentProject.Models
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            label1 = new Label();
            label2 = new Label();
            username_txt = new TextBox();
            pass_txt = new TextBox();
            login_btn = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            Registerlogin_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(535, 123);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(535, 204);
            label2.Name = "label2";
            label2.Size = new Size(128, 37);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // username_txt
            // 
            username_txt.Location = new Point(692, 133);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(184, 29);
            username_txt.TabIndex = 2;
            // 
            // pass_txt
            // 
            pass_txt.Location = new Point(692, 204);
            pass_txt.Name = "pass_txt";
            pass_txt.Size = new Size(184, 29);
            pass_txt.TabIndex = 3;
            pass_txt.UseSystemPasswordChar = true;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.SteelBlue;
            login_btn.Font = new Font("Segoe UI", 14F);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(752, 287);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(109, 45);
            login_btn.TabIndex = 4;
            login_btn.Text = "login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(471, 430);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Calligraphy", 16F);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(554, 43);
            label3.Name = "label3";
            label3.Size = new Size(307, 36);
            label3.TabIndex = 6;
            label3.Text = "Clinic Appointment ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(521, 353);
            label4.Name = "label4";
            label4.Size = new Size(245, 37);
            label4.TabIndex = 7;
            label4.Text = "Create an account !";
            // 
            // Registerlogin_btn
            // 
            Registerlogin_btn.BackColor = Color.SteelBlue;
            Registerlogin_btn.Font = new Font("Segoe UI", 14F);
            Registerlogin_btn.ForeColor = Color.White;
            Registerlogin_btn.Location = new Point(752, 428);
            Registerlogin_btn.Name = "Registerlogin_btn";
            Registerlogin_btn.Size = new Size(109, 45);
            Registerlogin_btn.TabIndex = 12;
            Registerlogin_btn.Text = "Register";
            Registerlogin_btn.UseVisualStyleBackColor = false;
            Registerlogin_btn.Click += Registerlogin_btn_Click;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(918, 525);
            Controls.Add(Registerlogin_btn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(login_btn);
            Controls.Add(pass_txt);
            Controls.Add(username_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_Form";
            Load += Login_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox username_txt;
        private TextBox pass_txt;
        private Button login_btn;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Button Registerlogin_btn;
    }
}