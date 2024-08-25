using System;

namespace Hospital
{
    public class MedicalRecord
    {
        
        public DateTime Date { get; set; }                
        public string Diagnosis { get; set; }             
        public string TreatmentPlan { get; set; }         
        public string DoctorName { get; set; }            

        
        public MedicalRecord(DateTime date, string diagnosis, string treatmentPlan, string doctorName)
        {
            Date = date;
            Diagnosis = diagnosis;
            TreatmentPlan = treatmentPlan;
            DoctorName = doctorName;
        }

        public void RecordDiagnosis(Patient patient, string diagnosis, string treatmentPlan)
        {
            if (patient == null)
                throw new ArgumentNullException(nameof(patient));

            var medicalRecord = new MedicalRecord(
                DateTime.Now, 
                diagnosis,
                treatmentPlan,
                this.DoctorName 
            );

            patient.MedicalRecords.Add(medicalRecord);
        
        }
    }
}

