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
        public int column { get; private set; }

        public Panel[] panel { get; private set; }
        public int panelCount { get; private set; }

        public Shelf(int tier, int col, int paneCount)
        {
            this.tier = tier;
            this.column = column;
            panel = new Panel[paneCount];
        }
    }
}
