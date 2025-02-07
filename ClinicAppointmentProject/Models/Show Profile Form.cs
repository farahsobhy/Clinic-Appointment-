using ClinicAppointmentProject.Data;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Show_Profile_Form : Form
    {
        //private int loggedInUserId;
        //private string username;
        //private string role;
        ////private string username;
        ////private string role;
        //public Show_Profile_Form(int userId)
        //{
        //    loggedInUserId = userId;
        //}
        //public Show_Profile_Form(string username, string role)
        //{
        //    InitializeComponent();
        //    //loggedInUserId = userId;
        //    lblusername.Text = "Name:" + username;
        //    label2.Text = "Role:" + role;
        //    txtname.ReadOnly = true;
        //    cmbRole.Enabled=false;
        //    //this.username = username;
        //    //this.role = role;
        //    //lblusername.Text = "Name:" + username;
        //    //cmbRole.SelectedText = "Role:" + role;
        //}
        private string username;
        private string role;

        public Show_Profile_Form(string username, string role)
        {
            InitializeComponent();
            //this.username = username;
            //this.role = role;
            lblusername.Text = "Name: " + username;
            label2.Text = "Role: " + role;
        }

        private void Show_Profile_Form_Load(object sender, EventArgs e)
        {
            // عرض اسم المستخدم والدور في الحقول عند فتح الفورم
          

            // تعطيل التعديلات على الحقول
            //txtname.Text = username;
            //txtname.ReadOnly = true;

            //cmbRole.Items.Add(role);
            ////cmbRole.SelectedItem = role;
            //cmbRole.Enabled = false;
        }

//public Show_Profile_Form()
//{
//}

//public Show_Profile_Form()
//{
//}


        //private void LoadProfile()
        //{
        //    //    using (ClinicContext db = new ClinicContext())
            //    {
            //        var user = db.Users.FirstOrDefault(u => u.Id == loggedInUserId);
            //        if (user != null)
            //        {
            //            lblusername.Text = user.Username;
            //            //txtname.Text=user.Username;
            //            //lblPhone.Text = user.Phone;

            //            // تعيين الدور الحالي في ComboBox
            //            cmbRole.SelectedItem = user.Role;
            //        }
            //    }
            //}
            //using (ClinicContext db = new ClinicContext())
            //{
            //    // البحث عن المستخدم بناءً على ID
            //    var user = db.Users.FirstOrDefault(u => u.Id == loggedInUserId);
            //    if (user != null)
            //    {
            //        // تعيين القيم من قاعدة البيانات إلى الحقول
            //        //txtname.Text = user.Username; // عرض الاسم
            //        //cmbRole.SelectedItem = user.Role; // تعيين الدور

            //        lblusername.Text = "Name:" + user.Username;
            //        label2.Text = "Role:" + user.Role;
            //    }
            //    else
            //    {
            //        MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        //}
        

        private void btn_edit_Click(object sender, EventArgs e)
        {

            //using (ClinicContext db = new ClinicContext())
            //{
            //    // البحث عن المستخدم بناءً على ID
            //    var user = db.Users.FirstOrDefault(u => u.Id == loggedInUserId);
            //    if (user != null)
            //    {
            //        // تحديث البيانات من الحقول
            //        user.Username = txtname.Text; // تحديث الاسم
            //        user.Role = cmbRole.SelectedItem.ToString(); // تحديث الدور

            //        db.SaveChanges(); // حفظ التعديلات في قاعدة البيانات
            //        MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //using (ClinicContext db = new ClinicContext())
            //{
            //    var user = db.Users.FirstOrDefault(u => u.Id == loggedInUserId);
            //    if (user != null)
            //    {
            //        // تحديث البيانات الجديدة من الفورم
            //        //user.Phone = lblPhone.Text;
            //        user.Role = cmbRole.SelectedItem.ToString();

            //        db.SaveChanges(); // حفظ التعديلات في قاعدة البيانات
            //        MessageBox.Show("Updated", "Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    }
            //}
        }
    

        private void lblusername_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Login_Form form= new Login_Form();
            form.Show();
            this.Close();
        }
    }
}
    

