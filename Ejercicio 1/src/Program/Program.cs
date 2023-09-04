using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {   
            // se crea una instancia de Shelve y se 
            //utilizan los métodos de esa instancia para colocar los libros en el estante.
            Book book1 = new Book("Design Patterns", "Erich Gamma & Others", "001-034");
            Book book2 = new Book("Pro C#", "Troelsen", "001-035");

            Shelve shelve = new Shelve();
            shelve.ShelveBook(book1, "A", "7");
            shelve.ShelveBook(book2, "B", "3");
        }
    }
}