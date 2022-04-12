using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia_4_
{
    internal class Client
    {
        [System.ComponentModel.DataAnnotations.Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int IDClient {get;set;}
        public string Name { get; set; }

        public decimal Balance { get; set; }

        public string Adress { get; set; }
    }
}
