using System;
using Hospital;

public class Program
{
    public static void Main(string[] args) 
    {

        Doctor doctor = new Doctor(
                1237,            // doctorID
                "Smith",         // doctorName
                "Cardiology"     // specialization
            );


        Patient patient = new Patient(1001)
        {
            FirstName = "John",
            LastName = "Doe",
            Gender = "Male",
            Email = "john.doe@example.com",
            Address = "123 Main St",
            CellNumber = 5551234
        };

        
        DateTime appointmentDate = new DateTime(2024, 8, 22, 10, 0, 0);
        patient.ScheduleAppointment(doctor, appointmentDate, "Routine Checkup");

        
        patient.DisplayInfo();

       
        Console.WriteLine($"Doctor: {doctor.DoctorName}, Specialization: {doctor.Specialization}, Age: {doctor.Age}, Gender: {doctor.Gender}");

        
        Appointment appointment = new Appointment(
            "A123",
            patient,
            doctor,
            appointmentDate,
            "Routine Checkup",
            100.00m 
        );

        decimal billAmount = appointment.CalculateBill();
        Console.WriteLine($"The bill for appointment {appointment.AppointmentID} is ${billAmount}");
    }
}









