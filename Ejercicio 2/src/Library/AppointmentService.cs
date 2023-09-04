
using System;
using System.Text;

namespace Library
{
    /// <summary>
    /// Clase que proporciona servicios relacionados con las citas médicas.
    /// </summary>
    public class AppointmentService
    {
        /// <summary>
        /// Crea una cita médica.
        /// </summary>
        /// <param name="appointment">La cita médica que se va a crear.</param>
        /// <returns>Un mensaje que indica si la cita se creó correctamente o si hubo errores.</returns>
        public static string CreateAppointment(Appointment appointment)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            bool isValid = true;

            if (!ValidationService.ValidatePatientData(appointment.Patient))
            {
                stringBuilder.Append("Unable to schedule appointment, patient data is invalid\n");
                isValid = false;
            }

            if (!ValidationService.ValidateDoctorData(appointment.Doctor))
            {
                stringBuilder.Append("Unable to schedule appointment, doctor data is invalid\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointment.Place))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appointment place' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appointment scheduled");
            }

            return stringBuilder.ToString();
        }

        // El principio aplicado es el Single Responsibility Principle (SRP) al tener una sola responsabilidad de crear citas médicas y validar datos.
    }
}
