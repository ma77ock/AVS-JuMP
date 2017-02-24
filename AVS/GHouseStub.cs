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
        public int sensorDelayMM { get; private set; } //how often sensors 

        /// <Little schemme of Shelter >
        /// _______________________
        /// |                     |     @ pods in panel
        /// | |@| |@| |@| |@| |@| |    |@| panel in shelf
        /// | |@| |@| |@| |@| |@| |    
        /// | |@| |@| |@| |@| |@| |    | | -on row on Shelfs
        /// | |@| |@| |@| |@| |@| |    | |  *There is a few levels of shelfs too
        /// | |@| |@| |@| |@| |@| |    | |
        /// | |@| |@| |@| |@| |@| |
        /// |                     |       
        /// ______________________|
        /// </summary>
        private int NumberOfRows{ get; private set; } // Number Of Shelf rows in GreenHouse
}
}
