using System;
using System.Text;

namespace Library
{
    /// <summary>
    /// Clase que representa a un médico.
    /// </summary>
    public class Doctor
    {
        
        public string Name { get; set; }

      
        public string Speciality { get; set; }

        
        // El principio aplicado es el Single Responsibility Principle (SRP) al tener una sola responsabilidad de representar datos del médico.
    }
}
