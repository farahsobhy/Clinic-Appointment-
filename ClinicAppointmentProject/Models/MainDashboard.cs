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
    public partial class MainDashboard : Form
    {
        private string userRole;
        private string username;
        private string role;
        private int loggedInUserId;

        public MainDashboard(string username, string role)
        {
            InitializeComponent();
            lblWelcome.Text = "Welcome, " + username;  // عرض اسم المستخدم في الـ label
            userRole = role;  // تعيين الدور بناءً على ما جاء من لوجين فور
        }

        //public MainDashboard(string role)
        //{
        //    this.role = role;
        //}

        //public MainDashboard()
        //{
        //}

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            if (userRole == "Doctor")
            {
                btn_managepatient.Visible = true;
                btn_viewappointment.Visible = true;
                btn_viewReports.Visible = true;
            }
            else if (userRole == "Admin")
            {
                btn_managepatient.Visible = true;
                btn_viewappointment.Visible = true;
                btn_viewReports.Visible = true;
                // أزرار إضافية للإدارة إذا كان الدور Admin
            }
        }

        private void btn_managepatient_Click(object sender, EventArgs e)
        {
            Manage_Patient_forn managePatientsForm = new Manage_Patient_forn(username, userRole);
            managePatientsForm.Show();
            this.Hide();
        }

        private void btn_viewReports_Click(object sender, EventArgs e)
        {
            ReportsForm frm = new ReportsForm(username,userRole);
            frm.Show();
            this.Hide();
        }

        private void btn_viewappointment_Click(object sender, EventArgs e)
        {
            View_Appointment_Form manageAppointmentsForm = new View_Appointment_Form(username, userRole);
            manageAppointmentsForm.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login_Form loginForm = new Login_Form();
            loginForm.Show();
            this.Hide();
        }

        private void btn_showprofile_Click(object sender, EventArgs e)
        {
            Show_Profile_Form showprofile= new Show_Profile_Form(username,role);
            showprofile.Show();
            this.Hide();
        }
    }
}
