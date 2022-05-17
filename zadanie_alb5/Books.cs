using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_lab5
{
    internal class Books
    {
        public int Id {get;set;}
        public string Title { get; set; }
        public int Year { get; set; }

        public int Autor_Id { get; set; }

        public Autors Autor { get; set; }
    }
}
