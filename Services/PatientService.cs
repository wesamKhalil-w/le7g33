using System;
using DentalClinic.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.Services
{
    internal class PatientService
    {
        private List<Patient> patients;
        private DataService dataService;
        private string fileName =

"patients.json";

        public PatientService()
        {
            dataService = new DataService();
            patients = dataService.LoadData<Patient>(fileName);
        }

        public List<Patient> GetAllPatients()
        {
            return patients;
        }

        public Patient GetPatientById(int id)
        {
            return patients.FirstOrDefault(p => p.Id == id);
        }

        public void AddPatient(Patient patient)

        {
            patient.Id = patients.Count > 0 ? patients.Max(p => p.Id) + 1 : 1;
            patient.RegistrationDate = System.DateTime.Now;
            patients.Add(patient);
            dataService.SaveData(patients, fileName);
        }

        public void UpdatePatient(Patient patient)
        {
            var existingPatient = GetPatientById(patient.Id);
            if (existingPatient != null)
            {
                existingPatient.FullName = patient.FullName;
                existingPatient.Phone = patient.Phone;

                existingPatient.Address = patient.Address;
                existingPatient.DateOfBirth = patient.DateOfBirth;
                existingPatient.MedicalHistory = patient.MedicalHistory;
                dataService.SaveData(patients, fileName);
            }
        }

        public void DeletePatient(int id)
        {
            var patient = GetPatientById(id);
            if (patient != null)
            {
                patients.Remove(patient);
                dataService.SaveData(patients, fileName);
            }
        }

    }
}



