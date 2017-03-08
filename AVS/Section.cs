using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS
{
    class Section
    {
		//temperatura ir oro dregme perkelti cia? (tiksliau ziureti GreenHouse.cs)
        public int sectionID { get; private set; }

        public Shelf[] shelves { get; private set; }

        public Section(int secNR, int tierCount, int shelfSize)
        {
            sectionID = secNR;
            shelves = new Shelf[tierCount];
            for (int i = 0; i < tierCount; i++)
            {
                shelves[i] = new Shelf(i + 1, shelfSize);
            }
        }
    }
}
