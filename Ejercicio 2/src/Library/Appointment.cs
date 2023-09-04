using System;
using System.Text;

namespace Library
{
    /// <summary>
    /// Clase que representa una cita médica.
    /// </summary>
    public class Appointment
    {
        
        public string Id { get; set; }

        
        public DateTime Date { get; set; }

      
        public string Place { get; set; }

        
        public Patient Patient { get; set; }

       
        public Doctor Doctor { get; set; }

        // El principio aplicado es el Single Responsibility Principle (SRP) al tener una sola responsabilidad de representar una cita médica.
    }
}
