using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS
{
    class Plant
    {
        string name { get; set; }
        double pHLowLevel { get; set; }
        double pHHighLevel { get; set; }

        double temperatureLowLevel { get; set; }
        double temperatureHighLevel { get; set; }
        double lightIntensity { get; set; }
        double waterNeeded { get; set; }       
        double mineralsNeeded { get; set; }

        public Plant(string name, string phLow, string phHigh, string tempLow, string tempHigh, string light, string water, string mineral)
        {
            this.name = name;
            pHLowLevel = double.Parse(phLow);
            pHHighLevel = double.Parse(phHigh);
            temperatureLowLevel = double.Parse(tempLow);
            temperatureHighLevel = double.Parse(tempHigh);
            lightIntensity = double.Parse(light);
            waterNeeded = double.Parse(water);
            mineralsNeeded = double.Parse(mineral);
        }
		
		/* Proposed changes:
		//Plant death is not instant. If values are better than LD50 some plants might still receive small amount of damage thanks to rngod
		//LD50 is Lethal_Dose_50%, meaning that half of the population dies
		
		double pHOptimal { get; private set; } //optimal pH, mostly inbetween 6 and 7
		double pHLD50Deviation { get; private set; } //deviation from optimal pH at which half of plants die (2 is a good value)
		
		double tempOptimal { get; private set; } //optimal temperature, should be between 15-35 *C
		double tempLD50Low { get; private set; } //low temperature limit at which half of plants die, should be 5-15 *C
		double tempLD50High { get; private set; } //high temperature limit at which half of plants dies, should be 35-50 *C
		
		double lightOptimal { get; private set; }
		double humidityOptimal { get; private set; } //paleteje visada yra vandens. O va oro dregme kitas reikalas - ziema jos ore maziau
		string mineralsNeeded { get; private set; } //formatas: mineralo_formule kiekis_gramais_litre Ca 55 Mg 30 K 16 Zn 10
		*/
    }
}
