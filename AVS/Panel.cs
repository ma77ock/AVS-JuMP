using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS
{
    class Panel
    {

        public Plant[] plant { get; private set; }
        public int plantCount { get; private set; }
        public int panelSize { get; private set; }
        public double lightIntensity { get; private set; }
        public double pHLevel { get; private set; }

        public Panel()
        {
            plantCount = 0;
            plant[plantCount] = null;
            panelSize = 16;
            lightIntensity = 0;
            pHLevel = 7;
        }
     

    }
}
