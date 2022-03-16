using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baza_ado_lab2
{
    internal class Region
    {
        public Region(int id, string reg)
        {
            RegionID = id;
            RegionDescription = reg;
        }
        public int RegionID
        {
            get;
            set;
        }
        public string RegionDescription
        {
            get;
            set;
        }
    }
}
