using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace AVS
{
    class GreenHouse
    {	
        public string Pavadinimas { get; private set; }
        public Section[] sections { get; private set; }
        public int shelfAmount { get; private set; }
        public int panelsAmount { get; private set; }
        public int freePanelsAmount { get; private set; }
        public double freeRatio { get; private set; } // panelsAmount/freePanelsAmount
        public GreenHouse(string pavadinimas,int sectCount, int shleftPerSection, int panelsPerShelf)
        {
            this.Pavadinimas = pavadinimas;
            this.shelfAmount = sectCount*shleftPerSection;
            this.panelsAmount = sectCount * shleftPerSection * panelsPerShelf;
            this.freePanelsAmount = panelsAmount;
            freeRatio = 1;

            sections = new Section[sectCount];
            for (int i = 0; i < sectCount; i++)
            {
                sections[i] = new Section(shleftPerSection, panelsPerShelf);
            }
        }
        public void AddPlant(int sectionNo, int shelfNo, int panelNo)
        {
            sections[sectionNo].AddPlant(shelfNo,panelNo);
            freePanelsAmount--;

        }
        internal static void LoadPlantsFromFile(string plantDataPath)
        {
            string[] lines = File.ReadAllLines(plantDataPath);
        }
    }
}


