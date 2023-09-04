using System;
using System.Text;

namespace Library
{
    /// <summary>
    /// Clase que proporciona servicios de validación de datos.
    /// </summary>
    public class ValidationService
    {
        /// <summary>
        /// Valida los datos de un paciente.
        /// </summary>
        /// <param name="patient">El paciente cuyos datos se van a validar.</param>
        /// <returns>True si los datos son válidos; de lo contrario, false.</returns>
        public static bool ValidatePatientData(Patient patient)
        {
            // Implementar validaciones para datos del paciente
            return !string.IsNullOrEmpty(patient.Name) && !string.IsNullOrEmpty(patient.Id);
        }

        /// <summary>
        /// Valida los datos de un médico.
        /// </summary>
        /// <param name="doctor">El médico cuyos datos se van a validar.</param>
        /// <returns>True si los datos son válidos; de lo contrario, false.</returns>
        public static bool ValidateDoctorData(Doctor doctor)
        {
            // Implementar validaciones para datos del médico
            return !string.IsNullOrEmpty(doctor.Name) && !string.IsNullOrEmpty(doctor.Speciality);
        }

        // El principio aplicado es el Single Responsibility Principle (SRP) al tener una sola responsabilidad de realizar validaciones de datos.
    }
}
