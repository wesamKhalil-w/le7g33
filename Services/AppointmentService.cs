using System;
using DentalClinic.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.Services
{
    internal class AppointmentService
    {
        private List<Appointment> appointments;
        private DataService dataService;
        private string fileName = "appointments.json";

        public AppointmentService()

        {
            dataService = new DataService();
            appointments = dataService.LoadData<Appointment>(fileName);
        }

        public List<Appointment> GetAllAppointments()
        {
            return appointments;
        }

        public Appointment GetAppointmentById(int id)
        {
            return appointments.FirstOrDefault(a => a.Id == id);
        }

        public List<Appointment>

GetAppointmentsByPatientId(int patientId)
        {
            return appointments.Where(a => a.PatientId == patientId).ToList();
        }

        public void AddAppointment(Appointment appointment)
        {
            appointment.Id = appointments.Count > 0 ? appointments.Max(a => a.Id) + 1 : 1;
            appointments.Add(appointment);
            dataService.SaveData(appointments, fileName);
        }

        public void UpdateAppointment(Appointment appointment)
        {
            var existingAppointment =

GetAppointmentById(appointment.Id);
            if (existingAppointment != null)
            {
                existingAppointment.PatientId = appointment.PatientId;
                existingAppointment.AppointmentDate = appointment.AppointmentDate;
                existingAppointment.Reason = appointment.Reason;
                existingAppointment.Status = appointment.Status;
                existingAppointment.Notes = appointment.Notes;
                dataService.SaveData(appointments, fileName);
            }
        }

        public void DeleteAppointment(int id)

        {
            var appointment = GetAppointmentById(id);
            if (appointment != null)
            {
                appointments.Remove(appointment);
                dataService.SaveData(appointments, fileName);
            }
        }
    }
}

