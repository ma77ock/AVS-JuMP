using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AVS
{
	class Program
	{
        const string DataFilePath = "duomenys.txt";
        const string PlantDictionaryPath = "plantTypes.txt";
        const string PanelTypes = "panelTypes.txt";

        static void Main(string[] args)
		{
            Dictionary<string, TypePlant> PlantDictionary;
            List<GreenHouse> greenhouses;


            PlantDictionary = GetDictionaryData(PlantDictionaryPath);
        }

        private static void CheckSensors(GreenHouse gH)
        {
            throw new NotImplementedException();
        }

        private static GreenHouse FillWithData( string DataFilePath)
        {
            throw new NotImplementedException();
        }
    }
}
