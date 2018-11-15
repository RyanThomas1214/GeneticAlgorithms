using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_algorithms
{
	class ConsoleUI : IPopulationLogger
	{
		public void LogIndividual(Individual individual)
		{
			Console.WriteLine(string.Format("value: {0}", individual.Solution));
		}

		public void LogMessage(string message)
		{
			Console.WriteLine(message);
		}

		public void LogPopulation(List<Individual> population)
		{
			foreach (var individual in population)
			{
				LogIndividual(individual);
			}
		}
	}
}
