using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS
{
    class TypePlant
    {
        string type { get; set; }
        double pHLowLevel { get; set; }
        double pHHighLevel { get; set; }
        string properPanelType { get; set;}

        double temperatureLowLevel { get; set; }
        double temperatureHighLevel { get; set; }
        double lightIntensityLowLevel { get; set; }
        double lightIntensityHightLevel { get; set; }
        double waterNeeded { get; set; }
        double mineralsNeeded { get; set; }

        public TypePlant(string name,string paneltype, double phLow,double phHigh, double tempLow,
         double tempHigh, double lightLow, double lightHigh,double water, double mineral )
        {
            this.type = name;
            this.properPanelType = paneltype;
            pHLowLevel = phLow;
            pHHighLevel = phHigh;
            temperatureLowLevel = tempLow;
            temperatureHighLevel = tempHigh;
            lightIntensityLowLevel = lightLow;
            lightIntensityHightLevel = lightHigh;
            waterNeeded = water;
            mineralsNeeded = mineral;
        }
    }
}
