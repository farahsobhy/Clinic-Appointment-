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
 
    public partial class ReportsForm : Form
    {
        private string username;
        private string role;
        public ReportsForm(string username, string role)
        {
            InitializeComponent();
            this.username=username;
            this.role=role;
        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadReports();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            LoadReports();
        }
        private void LoadReports()
        {
            using (ClinicContext db = new ClinicContext())
            {
                
                int totalPatients = db.Patients.Count();
                lblTotalPatients.Text = $" Total: {totalPatients}";

                
                int totalAppointments = db.Appointments.Count();
                lblTotalAppiontments.Text = $"Total: {totalAppointments}";

                int completedAppointments = db.Appointments.Count(a => a.Status == "Completed");
                lblCompletedAppointments.Text = $"Completed: {completedAppointments}";

                var doctorStats = db.Appointments
                    .GroupBy(a => a.Doctor)
                    .Select(g => new
                    {
                        Doctor = g.Key,
                        AppointmentCount = g.Count()
                    })
                    .ToList();

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            MainDashboard dashboardForm = new MainDashboard(username,role);
            dashboardForm.Show();
            this.Close();
        }
    }
}
