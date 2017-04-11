using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public double freeRation { get; private set; } // panelsAmount/freePanelsAmount
        public GreenHouse(string pavadinimas,int sectCount, int shleftPerSection, int panelsPerShelf)
        {
            this.Pavadinimas = pavadinimas;
            this.panelsAmount = sectCount * shleftPerSection * panelsPerShelf;
            this.freePanelsAmount = panelsAmount;
            freeRation = 1;

            sections = new Section[sectCount];
            for (int i = 0; i < sectCount; i++)
            {
                sections[i] = new Section(shleftPerSection, panelsPerShelf);
            }
        }
    }
}


