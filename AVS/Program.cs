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

        static void Main(string[] args)
		{
            GreenHouse greenHouse = FillWithData(DataFilePath);
            //int AccesKode = Calibration(ref greenHouse);
        }
        //static int Calibration(ref GreenHouse GH)
        //{
        //    GH = FillWithData(DataFilePath); // Atminties struktūra užkrauna duombazės informacija
        //    CheckSensors(GH); // Tikrinima šiltnamio sensoriai, pagal paduodama simuliacija, jei keitėsi atnaujina info.
            
        //}

        private static void CheckSensors(GreenHouse gH)
        {
            throw new NotImplementedException();
        }

        private static GreenHouse FillWithData( string DataFilePath)
        {
            string[] lines = File.ReadAllLines(DataFilePath);
            GreenHouse greenHouse = new GreenHouse(int.Parse(lines[0]),1);
            for (int i = 1; i < greenHouse.sections.Length; i++)
            {
                string[] parts = lines[i].Split(';');
                Section section = new Section(i, int.Parse(parts[0]), int.Parse(parts[1]));
            }
            for (int i = greenHouse.sections.Length; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(';');
                Plant plant = ChosePlant(parts);
                greenHouse.AddPlant(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]), plant);
            }
            return greenHouse;
        }
                
        private static Plant ChosePlant(string[] parts)
        {
            switch (char.Parse(parts[3]))
            {
                case 'V':
                    return new Vegetable(parts[4], parts[5], parts[6], parts[7], parts[8], parts[9], parts[10], parts[11], parts[12]);
                    break;
                default:
                    return new Plant(parts[4], parts[5], parts[6], parts[7], parts[8], parts[9], parts[10], parts[11]);
            }
        }
    }
}
