using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS
{
    class Vegetable : Plant
    {
        public string color { get; private set; }

        public Vegetable(string color, string name, string phLow, string phHigh, string tempLow, string tempHigh, string light, string water, string mineral)
        {
            this.color = color;
        }
        :base(name,phLow, phHigh,tempLow, tempHigh, light, water,mineral);
    }
}
