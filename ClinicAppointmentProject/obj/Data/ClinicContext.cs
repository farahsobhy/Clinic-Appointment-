using ClinicAppointmentProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppointmentProject.Data
{
    public class ClinicContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public ClinicContext() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=. \\SQLEXPRESS;Database=ClinicProject;Trusted_Connection=True; TrustServerCertificate=True;");


        }
    }
}
