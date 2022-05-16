using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia_5
{
    internal class order
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public int ClientId{ get; set; }

        public Client Client { get; set; }

    }
}
