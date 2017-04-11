using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AVS.ErrorHandler;

namespace AVS
{
	class Simulation
	{
		//temperature
		public int tempYearAvg { get; private set; }
		public int tempYearAmplitude { get; private set; }
		public int tempDayAmplitude { get; private set; }
		//air humidity -- when air cools down, humidity % goes up. 100% is catastrophic
		public static readonly double tempDeltaForHumidityPercent = 0.165; //temperature difference for change of humidity by one percent
		public static readonly double humidityPercentDeltaForTemp = 1/tempDeltaForHumidityPercent;
		//pH - priklauso nuo augalo
		//simulation time
		public int timeCurrentMM { get; private set; } //minutes since this year started
		public int timeStepMM { get; private set; } //simulation step in minutes
		//greenhouse to simulate
		public GreenHouse gHouse { get; private set; }

		public Simulation(){
			tempYearAvg = 10;
			tempYearAmplitude = 15;
			tempDayAmplitude = 10;
			timeCurrentMM = 0;
			timeStepMM = 60;
		}

		public Simulation(int tempYearAvg, int tempYearAmplitude, int tempDayAmplitude, int timeCurrentMM, int timeStepMM, GreenHouse gHouse){
			this.tempYearAvg = tempYearAvg;
			this.tempYearAmplitude = tempYearAmplitude;
			this.tempDayAmplitude = tempDayAmplitude;
			this.timeCurrentMM = Math.Max(0, timeCurrentMM);
			this.timeStepMM = Math.Max(1, timeStepMM);
			this.gHouse = gHouse;
		}

		public GreenHouse RunFor(int deltaTime){
			if (deltaTime < 0 || deltaTime > 365*24*60){
				Print(string.Format("ERR: deltaTime {0} incorrect", deltaTime));
				deltaTime = Math.Max(timeStepMM, Math.Min(365*24*60, deltaTime));
			}
			Print(string.Format("LOG: Simulation will run for {0} minutes, {1} steps {2} minutes each", deltaTime, deltaTime/timeStepMM, timeStepMM));
			while (deltaTime >= timeStepMM){
				deltaTime -= timeStepMM;
				timeCurrentMM += timeStepMM;
				Update(timeStepMM);
			}
			return gHouse;
		}
		private void Update(int dT){	
			foreach(Section section in gHouse.sections){
				foreach(Shelf shelf in section.shelves){
					foreach(Panel panel in shelf.panel){
						//Print(string.Format("LOG: Simulating {0} {1} Panel {2} plant count: {3}", section, shelf, panel, panel.plantCount));
					}
				}
			}
		}
	}
}

