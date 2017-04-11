using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS
{
    class Panel
    {
        public int ID { get; private set; }


        public double livingPercentage { get; private set; } // reikšmė tarp 1 ir 0 ;
        public bool hasDiseases { get; private set; }
        public double lightIntensity { get; private set; }
        public double pHLevel { get; private set; }

        public Panel(int size)
        {
            hasDiseases = false;
        }
    }
}
