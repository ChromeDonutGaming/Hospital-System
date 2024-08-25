using System;
using System.Collections.Generic;

namespace Hospital
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
        public int Age { get; set; }
        public string? Gender { get; set; }
        public string Specialization { get; set; }
        public List<Appointment> Appointments { get; set; }

        
        public Doctor(int doctorID, string doctorName, string specialization)
        {
            DoctorID = doctorID;
            DoctorName = doctorName;
            Specialization = specialization;
            Appointments = new List<Appointment>();
        }
    }
}

