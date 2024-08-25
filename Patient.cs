using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hospital
{
    public class Patient : Person
    {
        
        public int PatientID { get; set; }
        public List<MedicalRecord> MedicalRecords { get; set; }
        public List<Appointment> Appointments { get; set; }

        
        public Patient(int patientID)
        {
            PatientID = patientID;
            MedicalRecords = new List<MedicalRecord>();
            Appointments = new List<Appointment>();     
        }


        public void ScheduleAppointment(Doctor doctor, DateTime dateTime, string reason)
        {
            var appointment = new Appointment(
                Guid.NewGuid().ToString(), 
                this,
                doctor,
                dateTime,
                reason,
                100.00m 
            );

            Appointments.Add(appointment);
            doctor.Appointments.Add(appointment);
        }


        public override void DisplayInfo()
        {
            Console.WriteLine($"Patient: {FirstName},Last Name: {LastName},Emial: {Email}, Gender: {Gender}, Cell Number: {CellNumber}");
        }
    }
}

