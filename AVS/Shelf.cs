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
        public int shelfSize { get; private set; }
        public Shelf()
        {
            tier = 0;
            column = 0;
            panelCount = 0;
            shelfSize = 8;
        }

        public void Add(Panel panel)
        {
            if (panelCount <= shelfSize)
            {

                for (int i = 0; i < shelfSize; i++)
                {
                    if (this.panel[i] == null)
                    {
                        this.panel[i] = panel;
                        panelCount++;
                    }
                }
            }
            else
            {
                ErrorHandler.Print("Out of space on shelf");
            }

        }

    }
}
