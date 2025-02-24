﻿using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppointmentProject.Models
{
    public class Appointment
    {
       
        public int Id { get; set; }
        [Required]
        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public virtual Patient Patient { get; set; }
        public string Doctor { get; set; }
        [Required]
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; }
        public bool IsCompleted { get; set; }
    }
}
