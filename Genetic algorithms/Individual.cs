using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_algorithms
{
	[DebuggerDisplay("value = {Value} solution = {Solution}")]
	class Individual
	{
		public Individual(int individual)
		{
			Value = individual;
		}

		public Individual()
		{
			
		}

		public int Value { get; set; }
		public double Solution { get; set; }
		public int Weight { get; set; }		
		public int Age { get; set; }
	}
}
