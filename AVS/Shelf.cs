using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS
{
    class Shelf
    {
		public int ID { get; private set; }
        public int tier { get; private set; }

        public Panel[] panel { get; private set; }
        public int shelfSize { get; private set; }
		
        public Shelf(int tier, int paneCount)
        {
            this.tier = tier;
            panel = new Panel[paneCount];
        }
    }
}
