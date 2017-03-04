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

    }
}
