using System;

namespace Hospital
{
    public class Appointment
    {
        
        public string AppointmentID { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime DateTime { get; set; }
        public string ReasonForVisit { get; set; }
        public decimal ServiceFee { get; set; }  

     
        public Appointment(string appointmentID, Patient patient, Doctor doctor, DateTime dateTime, string reasonForVisit, decimal serviceFee)
        {
            AppointmentID = appointmentID;
            Patient = patient;
            Doctor = doctor;
            DateTime = dateTime;
            ReasonForVisit = reasonForVisit;
            ServiceFee = serviceFee;
        }


        public decimal CalculateBill()
        {
           
            return ServiceFee;
        }
    }
}

