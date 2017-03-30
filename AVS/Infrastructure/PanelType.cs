﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS
{
    class PanelType
    {
        public string panelClass { get; private set; }
        public int plantCapacity { get; private set; }

        public PanelType( string classs, int capacity)
        {
            this.panelClass = classs;
            this.plantCapacity = capacity;
        }
    }
}
