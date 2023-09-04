using System;
using System.Text;

namespace Library
{
    /// <summary>
    /// Clase que representa a un paciente.
    /// </summary>
    public class Patient
    {
       
        public string Name { get; set; }

       
        public string Id { get; set; }

      
        public string PhoneNumber { get; set; }

        

        // El principio aplicado es el Single Responsibility Principle (SRP) al tener una sola responsabilidad de representar datos del paciente.
    }
}
