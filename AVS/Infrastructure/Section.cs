using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS
{
    class Section
    {
        public int shelvesCount { get; private set; }

        public int panelsAmount { get; private set; }
        public int freePanelsAmount { get; private set; }
        public double freeRation { get; private set; } // panelsAmount/freePanelsAmount

        public Shelf[] shelves { get; private set; }

        public Section(int shelvesCount, int panelsCount)
        {
            this.panelsAmount = shelvesCount * panelsCount;
            this.freePanelsAmount = panelsAmount;
            freeRation = 1;

            shelves = new Shelf[shelvesCount];
            for (int i = 0; i < shelvesCount; i++)
            {
                shelves[i] = new Shelf(i, panelsCount);
            }
        }
    }
}
