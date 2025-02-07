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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ClinicAppointmentProject.Models
{
    public partial class View_Appointment_Form : Form
    {
        private string username;
        private string role;
        public View_Appointment_Form(string username, string role)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;
        }

        private void View_Appointment_Form_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }
        private void LoadAppointments()
        {
            using (ClinicContext db = new ClinicContext())
            {
                dataGridViewAppointments.DataSource = db.Appointments
                    .Select(a => new
                    {
                        a.Id,
                        PatientName = a.Patient.Name,  // تعديل الاسم ليكون واضحًا
                        a.AppointmentDate,
                        a.Doctor
                    })
                    .ToList();
            }
        }
        private void dataGridViewAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            MainDashboard dashboardForm = new MainDashboard(username, role);
            dashboardForm.Show();
            this.Close();
        }
    }
}
