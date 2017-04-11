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
        const string greenHousesParamsPath ="GreenHouseParams.txt";
        const string plantDictionaryPath = "plantTypes.txt";
        const string panelTypesPath = "panelTypes.txt";
        const string plantDataPath = "plants.txt";

        static void Main(string[] args)
		{
            Dictionary<string, TypePlant> PlantsDictionary;
            Dictionary<string, PanelType> PanelsDictionary;
            List<GreenHouse> Greenhouses;

            PanelsDictionary = GetPanelDictionaryData(panelTypesPath);
            PlantsDictionary = GetPlantDictionaryData(plantDictionaryPath);
            Greenhouses = LoadGreenHouse(greenHousesParamsPath);
            GreenHouse.LoadPlantsFromFile(plantDataPath);
        }

        private static List<GreenHouse> LoadGreenHouse(string greenHousesParamsPath)
        {
            List<GreenHouse> Gh = new List<GreenHouse>();
            string data = File.ReadAllText(greenHousesParamsPath);
            string[] GHparams = data.Split('!');
            foreach (string GHparam in GHparams)
            {
                string[] parts = GHparam.Split(';');
                GreenHouse greenhouse = new GreenHouse(parts[0],
                 int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
                Gh.Add(greenhouse);
            }
            return Gh;
        }
        private static Dictionary<string, TypePlant> GetPlantDictionaryData(string plantDictionaryPath)
        {
            Dictionary<string, TypePlant> temp = new Dictionary<string, TypePlant>();
            string[] source = File.ReadAllLines(plantDictionaryPath, Encoding.GetEncoding(1257));
            foreach (string line in source)
            {
                string[] parts = line.Split(';');
                TypePlant plant = new TypePlant(parts[0],parts[1],
                 double.Parse(parts[2]),double.Parse(parts[3]),
                 double.Parse(parts[4]),double.Parse(parts[5]),
                 double.Parse(parts[6]), double.Parse(parts[7]),
                 double.Parse(parts[8]), double.Parse(parts[9]));
                temp.Add(parts[0], plant);
            }
            return temp;
        }
        private static Dictionary<string, PanelType> GetPanelDictionaryData(string panelTypesPath)
        {
            Dictionary<string, PanelType> temp = new Dictionary<string, PanelType>();
            string[] source = File.ReadAllLines(panelTypesPath);
            foreach (string line in source)
            {
                string[] parts = line.Split(';');
                PanelType panel = new PanelType(parts[0], int.Parse(parts[1]));
                temp.Add(parts[0], panel);
            }
            return temp;
        }
        private static void CheckSensors(GreenHouse gH)
        {
            throw new NotImplementedException();
        }
    }
}
