using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS
{
    class Shelf
    {
        public int tier { get; private set; }

        public Panel[] panel { get; private set; }
        public int shelfSize { get; private set; }

        public int panelsAmount { get; private set; }
        public int freePanelsAmount { get; private set; }
        public double freeRation { get; private set; } // panelsAmount/freePanelsAmount

        public Shelf(int tier, int paneCount)
        {
            panelsAmount = paneCount;
            freePanelsAmount = paneCount;
            freeRation = 1;

            this.tier = tier;
            panel = new Panel[paneCount];
        }
    }
}
