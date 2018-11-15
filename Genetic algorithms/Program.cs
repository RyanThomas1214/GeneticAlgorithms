using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_algorithms
{
	class Program
	{
		private static ConsoleUI ConsoleUI;
		private static Random Random;
		private static List<Individual> Population;
		

		static Program()
		{
			ConsoleUI = new ConsoleUI();
			Random = new Random();
			Population = new List<Individual>();
		}
		static void Main(string[] args)
		{
			
			initialisePopulation();
			for (int i = 0; i < 600; i++)
			{
				ConsoleUI.LogMessage($"Current genneration: {i}");
				evaluateFitness();
				ConsoleUI.LogIndividual(Population.First());
				pickParents();
				generateOffspring();
			}

			//ConsoleUI.LogPopulation(Population);
			Console.ReadLine();
		}

		
		private static void generateOffspring()
		{
			var offspringValue = parent1.Value + parent2.Value / 2;
			var offspring = new Individual
			{
				Value = offspringValue
			};
			Population.Add(offspring);
		}

		private static Individual parent1;
		private static Individual parent2;
		private static void pickParents()
		{
			parent1 = pickParent();
			parent2 = pickParent();
		}

		private static Individual pickParent()
		{
			var randomNumber = Random.Next(0, Population.Sum(item => item.Weight));

			Individual parent = null;

			foreach (var individual in Population)
			{
				

				if (randomNumber <= individual.Weight)
				{
					parent = individual;
					break;
				}

				randomNumber = randomNumber - individual.Weight;
			}


			return parent;
		}

		private static void evaluateFitness()
		{
			foreach (var individual in Population)
			{
				individual.Solution =
					(-1d * (individual.Value * (double) individual.Value) - (23d * individual.Value)) + 4;
			}

			Population = Population.OrderByDescending(e => e.Solution).ToList();

			for (int i = 0; i < Population.Count; i++)
			{
				var individual = Population[i];
				individual.Weight = (Population.Count - i + 2) / 2;
			}
		}

		private static void initialisePopulation()
		{
			for (int i = 0; i < 30; i++)
			{
				var individual = Random.Next(-2147483647, 2147483647);
				Population.Add(new Individual(individual));
			}
		}
	}
}
