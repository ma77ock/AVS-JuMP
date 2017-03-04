using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS
{
	class Program
	{
        const string DataFilePath = "duomenys.txt";

        static void Main(string[] args)
		{
            GreenHouse greenHouse = new GreenHouse();
            int AccesKode = Calibration(greenHouse);
        }
        static int Calibration(GreenHouse GH)
        {
            FillWithData(GH, DataFilePath); // Atminties struktūra užkrauna duombazės informacija
            CheckSensors(GH); // Tikrinima šiltnamio sensoriai, pagal paduodama simuliacija, jei keitėsi atnaujina info.
            
        }

        private static void CheckSensors(GreenHouse gH)
        {
            throw new NotImplementedException();
        }

        private static void FillWithData(GreenHouse gH, string dataFilePath)
        {
            throw new NotImplementedException();
        }
    }
}
