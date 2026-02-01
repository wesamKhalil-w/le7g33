using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.Models
{
   public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; } // Scheduled, Completed, Cancelled
        public string Notes { get; set; }

    }
}
