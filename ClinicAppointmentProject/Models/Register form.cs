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
    public partial class Register_form : Form
    {
        public Register_form()
        {
            InitializeComponent();
        }

        private void Register_form_Load(object sender, EventArgs e)
        {

        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(username_txt.Text) ||
                    string.IsNullOrWhiteSpace(pass_txt.Text) ||
                    string.IsNullOrWhiteSpace(passconfirm_txt.Text))
                {
                    MessageBox.Show("Please fill all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                if (pass_txt.Text != passconfirm_txt.Text)
                {
                    MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (ClinicContext db = new ClinicContext())
                {
                    
                    if (db.Users.Any(u => u.Username == username_txt.Text))
                    {
                        MessageBox.Show("The username already exists! Please choose another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    
                    var newUser = new User
                    {
                        Username = username_txt.Text,
                        Password = pass_txt.Text, 
                        Role = "Patient",
                        Phone="0123456789"
                    };

                    db.Users.Add(newUser);
                    db.SaveChanges();
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Login_Form form = new Login_Form();
                    form.Show();
                    this.Close();
                    // Close the form after successful registration
                    //this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        //    // التحقق من أن جميع الحقول ممتلئة
        //    if (string.IsNullOrWhiteSpace(username_txt.Text) ||
        //        string.IsNullOrWhiteSpace(pass_txt.Text) ||
        //        string.IsNullOrWhiteSpace(passconfirm_txt.Text))
        //    {
        //        MessageBox.Show("plese fill all", "wrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    // التحقق من تطابق كلمة المرور وتأكيدها
        //    if (pass_txt.Text != passconfirm_txt.Text)
        //    {
        //        MessageBox.Show("password does not match", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    using (ClinicContext db = new ClinicContext())
        //    {
        //        // التحقق من عدم وجود اسم مستخدم مكرر
        //        if (db.Users.Any(u => u.Username == username_txt.Text))
        //        {
        //            MessageBox.Show("choose another name ,username you entered already exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        var newUser = new User
        //        {
        //            Username = username_txt.Text,
        //            Password = pass_txt.Text // *يُفضَّل تشفيرها بدلًا من تخزينها مباشرة*
        //        };

        //        db.Users.Add(newUser);
        //        db.SaveChanges();
        //        MessageBox.Show("register done", "succsessful", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        // غلق الفورم بعد التسجيل الناجح
        //        this.Close();
        //    }
        //}


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passconfirm_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void loginreg_btn_Click(object sender, EventArgs e)
        {
            Login_Form loginForm=new Login_Form();
            loginForm.Show();
            this.Hide();
        }
    }
}
