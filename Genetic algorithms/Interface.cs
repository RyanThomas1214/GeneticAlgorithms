using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_algorithms
{
	interface IPopulationLogger
	{
		void LogIndividual(Individual individual);
		void LogPopulation(List<Individual> population);
		void LogMessage(string message);
	}
}
