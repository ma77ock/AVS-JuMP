using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS
{
    class Section
    {
        public int sectionNumber { get; private set; }

        public Shelf[] shelves { get; private set; }
        public int shelvesCount { get; private set; }

        public Section(int secNR, int tierCount)
        {
            sectionNumber = secNR;
            shelves = new Shelf[tierCount];
        }



    }


}
