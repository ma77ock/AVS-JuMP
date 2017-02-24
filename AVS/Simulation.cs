using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS
{
	class Simulation
	{
		public static readonly int[] tempAvgMonth = { -8, -5, 0, 2, 8, 18, 22, 24, 20, 10, 4, -2 };
		public int currentYear { get; private set; } //zero unless simulation runs for over a year
		public int currentTimeMM { get; private set; }
		public int stepTimeMM { get; private set; } //simulation step in minutes
	}
}
