using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia_5
{
    internal class Client
    {
        public Client()
        {
            Orders = new List<order>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public List<order> Orders { get; set; }
    }
}
