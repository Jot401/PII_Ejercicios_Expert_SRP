using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de pacientes y médicos
            Patient patient1 = new Patient
            {
                Name = "Steven Johnson",
                Id = "986782342",
                PhoneNumber = "5555-555-555"
            };

            Doctor doctor1 = new Doctor
            {
                Name = "Armand",
                Speciality = "Cardiologist"
            };

            // Crear una cita médica
            Appointment appointment1 = new Appointment
            {
                Id = "123456",
                Date = DateTime.Now,
                Place = "Wall Street",
                Patient = patient1,
                Doctor = doctor1
            };

            // Crear una instancia de ValidationService si es necesario
             ValidationService validationService = new ValidationService();

            // Validar datos si es necesario
             bool isPatientDataValid = ValidationService.ValidatePatientData(patient1);
             bool isDoctorDataValid = ValidationService.ValidateDoctorData(doctor1);

            // Crear una cita médica utilizando AppointmentService
            string appointmentResult1 = AppointmentService.CreateAppointment(appointment1);

            // Imprimir el resultado
            Console.WriteLine(appointmentResult1);
     
        }
    }
}
