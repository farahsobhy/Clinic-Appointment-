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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ClinicAppointmentProject.Models
{
    public partial class Manage_Patient_forn : Form
    {
        private string username;
        private string role;
        public Manage_Patient_forn(string username, string role)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;
        }

        private void Manage_Patient_forn_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }
        private void LoadPatients()
        {
            using (ClinicContext db = new ClinicContext())
            {
                var patients = db.Patients.ToList(); 
                dgv_patient.DataSource = patients; 
            }
        }
        private void dgv_patient_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_patient.SelectedRows.Count > 0)
            {
                var selectedRow = dgv_patient.SelectedRows[0];
                txt_name.Text = selectedRow.Cells[1].Value.ToString();
                txt_age.Text = selectedRow.Cells[2].Value.ToString();
                txt_phone.Text = selectedRow.Cells[3].Value.ToString();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //AddPatientForm addPatientForm = new AddPatientForm();
            //addPatientForm.Show();
            using (ClinicContext db = new ClinicContext())
            {
                var newPatient = new Patient
                {
                    Name = txt_name.Text,
                    Age = Convert.ToInt32(txt_age.Text),
                    Phone = txt_phone.Text
                };
                db.Patients.Add(newPatient);
                db.SaveChanges(); 
                LoadPatients(); 
                MessageBox.Show("Patient Added!");
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            var selectedPatientId = Convert.ToInt32(dgv_patient.SelectedRows[0].Cells[0].Value);
            using (ClinicContext db = new ClinicContext())
            {
                var patient = db.Patients.Find(selectedPatientId);
                if (patient != null)
                {
                    patient.Name = txt_name.Text;
                    patient.Age = Convert.ToInt32(txt_age.Text);
                    patient.Phone = txt_phone.Text;
                    db.SaveChanges(); 
                    LoadPatients(); 
                    MessageBox.Show("Patient Updated!");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var selectedPatientId = Convert.ToInt32(dgv_patient.SelectedRows[0].Cells[0].Value);
            using (ClinicContext db = new ClinicContext())
            {
                var patient = db.Patients.Find(selectedPatientId);
                if (patient != null)
                {
                    db.Patients.Remove(patient);
                    db.SaveChanges(); 
                    LoadPatients(); 
                    MessageBox.Show("Patient Deleted!");
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            MainDashboard dashboardForm = new MainDashboard(username, role);
            dashboardForm.Show();
            this.Close();
        
    }
    }
}
