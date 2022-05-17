using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_lab5
{
    internal class Autors
    {
        public Autors()
        {
            Book = new List<Books>();
        }
        
        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public List<Books> Book { get; set; }
    }
}
