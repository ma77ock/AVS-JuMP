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
            GreenHouse greenHouse = new GreenHouse();
            int AccesKode = Calibration(ref greenHouse);
        }
        static int Calibration(ref GreenHouse GH)
        {
            GH = FillWithData(DataFilePath); // Atminties struktūra užkrauna duombazės informacija
            CheckSensors(GH); // Tikrinima šiltnamio sensoriai, pagal paduodama simuliacija, jei keitėsi atnaujina info.
            
        }

        private static void CheckSensors(GreenHouse gH)
        {
            throw new NotImplementedException();
        }

        private static GreenHouse FillWithData( string dataFilePath)
        {
            GreenHouse greenHouse = new GreenHouse();
            string[] lines = File.ReadAllLines(dataFilePath);
            greenHouse.shelfCount = int.Parse(lines[0]);
            for (int i = 0; i < greenHouse.shelfCount; i++)
            {
                
            }
        }
    }
}
