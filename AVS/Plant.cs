using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS
{
    abstract class Plant // bazinė klasė, dirbti tik su išvestinėm klasėm.
    {
        string name { get; set; }
        double pHLowLevel { get; set; }
        double pHHighLevel { get; set; }

        double temperatureLowLevel { get; set; }
        double temperatureHighLevel { get; set; }
        double lightIntensityLowLevel { get; set; }
        double lightIntensityHightLevel { get; set }
        double waterNeeded { get; set; }
        double mineralsNeeded { get; set; }


        bool isMature { get; set; }

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
            isMature = false;
        }
    }
}
