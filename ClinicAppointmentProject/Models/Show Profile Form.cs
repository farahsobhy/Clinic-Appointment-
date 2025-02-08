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
          
        }


        

        private void btn_edit_Click(object sender, EventArgs e)
        {

            //using (ClinicContext db = new ClinicContext())
            //{
            //    var user = db.Users.FirstOrDefault(u => u.Id == loggedInUserId);
            //    if (user != null)
            //    {
            //        user.Username = txtname.Text; 
            //        user.Role = cmbRole.SelectedItem.ToString(); 

            //        db.SaveChanges(); 
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
            //        //user.Phone = lblPhone.Text;
            //        user.Role = cmbRole.SelectedItem.ToString();

            //        db.SaveChanges(); 
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
    

