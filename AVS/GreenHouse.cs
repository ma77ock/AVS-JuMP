using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS
{
    class GreenHouse
    {
		//gal perkelti i simuliacija?
        public int sensorDelayMM { get; private set; } //how often sensors check

        public int greenHouseNumber { get; private set; }
		//Algirdas: vidutine, minimali, maksimali paros/savaites/menesio temperatura/dregme ar kazkas tokio
		//temperatura cia butu kaip ir laikinai saugoma issaugojimui i duomenu baze, tam, kad butu zinoma kaip daznai vyksta anomalijos
		//bet viena aisku: geriau temperatura tureti skyriuose atskirai
		
		//pats geriausias variantas issaugoti tik temperaturos/dregmes/kt anomalijas. 
		//klausimas lieka tik kaip tai prijungti prie simuliacijos, greiciausiai tai kas X minuciu is simuliacijos klases kviesti sensorius
        public double temperature { get; private set; } 
        public double airHumidity { get; private set; }
		
        public Section[] sections { get; private set; }
		//galbut nereikalingas - sekciju yra tiek, kiek telpa siltnamyje, o kurios neirengtos tas paprasta ignoruoti
        public int sectionCount { get; private set; }

        public GreenHouse(int sectCount, int number)
        {
            grenHouseNumber = number;
            sections = new Section[sectCount];
        }
    }
}


