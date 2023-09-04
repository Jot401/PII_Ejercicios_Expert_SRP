using System;

namespace SRP
{
    public class Shelve
    {
        public string LibrarySector { get; set; }
        public string LibraryShelve { get; set; }


        public void ShelveBook(Book book, string sector, string shelve)
        {
            
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
    }
}
