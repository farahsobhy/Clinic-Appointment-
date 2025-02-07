using ClinicAppointmentProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicAppointmentProject.Models
{
    public partial class Login_Form : Form
    {
        private int userId;

        public Login_Form()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {


            string username = username_txt.Text.Trim();
            string password = pass_txt.Text.Trim();

            // تحقق من صحة الإدخال
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("يرجى إدخال اسم المستخدم وكلمة المرور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // الاتصال بقاعدة البيانات
            using (var db = new ClinicContext())
            {
                // البحث عن المستخدم
                var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                if (user == null)
                {
                    // المستخدم غير موجود
                    MessageBox.Show("username or password are wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // تحقق من نوع المستخدم وفتح الفورم المناسب
                    if (user.Role == "Admin" || user.Role == "Doctor")
                    {
                        // فتح لوحة التحكم
                        MainDashboard dashboardForm = new MainDashboard(user.Username,user.Role);
                        dashboardForm.Show();
                    }
                    else if (user.Role == "Patient")
                    {
                        // فتح نموذج حجز المواعيد
                        Book_Appointment_Form appointmentForm = new Book_Appointment_Form(userId);
                        appointmentForm.Show();
                    }

                    // إخفاء نافذة تسجيل الدخول
                    this.Hide();
                }
            }
        }
        //using (ClinicContext db = new ClinicContext())
        //{
        //    var user = db.Users
        //                      .FirstOrDefault(u => u.Username == username_txt.Text && u.Password == pass_txt.Text);
        //    if (user != null)
        //    {
        // انتقل إلى Main Dashboard

        //MessageBox.Show("Login Successful!");
        //Show_Profile_Form profileForm = new Show_Profile_Form(user.Id);
        //profileForm.Show();

        //if (user.Role == "Patient")
        //{
        //    // افتح فورم Book Appointment إذا كان المريض
        //    Book_Appointment_Form bookAppointmentForm = new Book_Appointment_Form(user.Id);
        //    this.Hide(); // إخفاء فورم تسجيل الدخول
        //    bookAppointmentForm.ShowDialog();
        //    this.Show(); // إعادة إظهار فورم تسجيل الدخول بعد إغلاق BookAppointmentForm
        //}
        //else if (user.Role == "Admin" || user.Role == "Doctor")
        //{
        //    // افتح الفورم الخاص بالإدارة أو الطبيب
        //    MainDashboard mainDashboardForm = new MainDashboard(user.Role);
        //    this.Hide();
        //    mainDashboardForm.ShowDialog();
        //    this.Show();
        //}
        //else
        //{
        //    MessageBox.Show("Role not recognized.");
        //}
        //            var isDoctor = db.Users.Any(d => d.Id == user.Id);
        //            var isAdmin = db.Users.Any(a => a.Id == user.Id);

        //            if (isDoctor || isAdmin)
        //            {
        //                // إذا كان المستخدم دكتور أو أدمن
        //                MainDashboard mainDashboardForm = new MainDashboard(user.Username);
        //                this.Hide();
        //                mainDashboardForm.ShowDialog();
        //                this.Show();
        //            }
        //            else
        //            {
        //                // إذا كان مريضاً
        //                Book_Appointment_Form bookAppointmentForm = new Book_Appointment_Form(user.Id);
        //                this.Hide();
        //                bookAppointmentForm.ShowDialog();
        //                this.Show();
        //            }
        //        }

        //        else
        //        {
        //            MessageBox.Show("Invalid Username or Password");
        //        }
        //    }
        //}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void Registerlogin_btn_Click(object sender, EventArgs e)
        {
            Register_form register_Form = new Register_form();
            register_Form.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
