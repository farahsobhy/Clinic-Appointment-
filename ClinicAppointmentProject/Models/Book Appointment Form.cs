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
    public partial class Book_Appointment_Form : Form
    {
        private int loggedInUserId;
        private string username;
        private string role;
        public Book_Appointment_Form(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;

        }

        private void Book_Appointment_Form_Load(object sender, EventArgs e)
        {
            try
            {
                LoadPatientInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patient info: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPatientInfo()
        {
            using (ClinicContext db = new ClinicContext())
            {
                // Load patients linked to the logged-in user
                var patients = db.Patients
                    .Where(p => p.UserId == loggedInUserId)
                    .Select(p => new { p.Id, p.Name })
                    .ToList();

                if (patients.Any())
                {
                    cmb_patient.DataSource = patients;
                    cmb_patient.DisplayMember = "Name";
                    cmb_patient.ValueMember = "Id";
                }
                else
                {
                    MessageBox.Show("No patients found for this user.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
     


        private void btn_book_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (cmb_patient.SelectedValue == null || string.IsNullOrWhiteSpace(txt_doctor.Text))
                {
                    MessageBox.Show("Please fill in all fields before booking.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (ClinicContext db = new ClinicContext())
                {
                   
                    var appointment = new Appointment
                    {
                        PatientId = Convert.ToInt32(cmb_patient.SelectedValue),
                        AppointmentDate = dtpDate.Value,
                        Doctor = txt_doctor.Text,
                        Status = "notCompleted",
                        IsCompleted = false 
                    };

                    db.Appointments.Add(appointment);
                    db.SaveChanges();
                    MessageBox.Show("Appointment successfully booked!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error booking appointment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //    using (ClinicContext db = new ClinicContext())
        //    {
        //        var appointment = new Appointment
        //        {
        //            PatientId = Convert.ToInt32(cmb_patient.SelectedValue),
        //            AppointmentDate = dtpDate.Value,
        //            Doctor = txt_doctor.Text
        //        };

        //        db.Appointments.Add(appointment);
        //        db.SaveChanges();
        //        MessageBox.Show("Appointment Booked!");
        //    }
        //}

        private void btn_showprofile_Click(object sender, EventArgs e)
        {
            Show_Profile_Form show_Profile_Form = new Show_Profile_Form(username,role);
            show_Profile_Form.Show();
            this.Hide();
        }
    }
}
