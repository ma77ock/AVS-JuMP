using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS
{
    class GreenHouse
    {	
        public Section[] sections { get; private set; }

        public GreenHouse(int sectCount)
        {
            sections = new Section[sectCount];
        }
    }
}


