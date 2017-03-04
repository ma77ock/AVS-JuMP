using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS
{
    class GreenHouse
    {
        public int tempCapacity { get; private set; } //volume*mass in joules or smth, not scientifically accurate
        public int tempConductivity { get; private set; } //quality of insulation, a*deltaT^2
        public int[] tempHeaterMaxPower; //Heater=Cooler, but most probably we won't need this
        public double[] tempHeaterEfficiency = { 0.7, 0.8, 0.9, 1.0, 1.0, 0.9, 0.8, 0.7, 0.6, 0.5, 0.4 }; //100%=0.7, 70%=1.0, 0%=0.4
        public int sensorDelayMM { get; private set; } //how often sensors check

        public int grenHouseNumber { get; private set; }
        public double temperature { get; private set; }
        public double airHumidity { get; private set; }
       
        public Section[] sections { get; private set; }
        public int sectionCount { get; private set; }

        public GreenHouse(int sectCount,int number)
        {
            grenHouseNumber = number;
            sections = new Section[sectCount];
        }
    }
    }

}
