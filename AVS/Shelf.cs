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
        public int panelCount { get; private set; }
        public int shelfSize { get; private set; }
        public Shelf()
        {
            tier = 0;
            panelCount = 0;
            shelfSize = 8;
        }
        public Shelf(int tier, int col, int paneCount)
        {
            this.tier = tier;
            this.column = column;
            panel = new Panel[paneCount];
        }
        public void Add(Panel panel)
        {
            if (panelCount <= shelfSize)
            {
                this.panel[place] = panel;
            }
            else
            {
                ErrorHandler.Print("Out of space on shelf");
            }

        }
        public Shelf(int tier, int paneCount)
        {
            this.tier = tier;        
            panel = new Panel[paneCount];
        }
    }
}
