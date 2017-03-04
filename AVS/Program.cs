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
            Simulation simulation = new Simulation();
            double AccesKode = Calibration(simulation);
        }
        static double Calibration(Simulation sim)
        {
            GreenHouse.FillWithData(DataFilePath); // Atminties struktūra užkrauna duombazės informacija
            GreenHouse.CheckSensors(sim); // Tikrinima šiltnamio sensoriai, pagal paduodama simuliacija, jei keitėsi atnaujina info.
            
        }
	}
}
