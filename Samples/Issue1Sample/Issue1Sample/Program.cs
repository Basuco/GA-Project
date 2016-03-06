using System;
using GeneticSharp.Domain;
using GeneticSharp.Domain.Crossovers;
using GeneticSharp.Domain.Mutations;
using GeneticSharp.Domain.Populations;
using GeneticSharp.Domain.Selections;
using GeneticSharp.Domain.Terminations;

namespace Issue1Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var selection = new EliteSelection();
            var crossover = new OnePointCrossover(0);
            var mutation = new UniformMutation(true);
            var fitness = new Issue1Fitness();
            var chromosome = new Issue1Chromosome();
            var population = new Population(50, 50, chromosome);

            var ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new GenerationNumberTermination(100);

            Console.WriteLine("GA running...");
            ga.Start();
            Console.WriteLine("GA done in {0} generations.", ga.GenerationsNumber);

            var bestChromosome = ga.BestChromosome as Issue1Chromosome;
            Console.WriteLine("Best solution found is A1:{0}, A2:{1}, A3:{2}, A4:{3}, A5:{4}, A6:{5}, A7:{6}, A8:{7}, A9:{8}, A10:{9}, A11:{10}, A12:{11}, A13:{12}, A14:{13}, A15:{14}, A16:{15} with {15} fitness.", bestChromosome.A1, bestChromosome.A2, bestChromosome.A3, bestChromosome.A4, bestChromosome.A5, bestChromosome.A6, bestChromosome.A7, bestChromosome.A8, bestChromosome.A9, bestChromosome.A10, bestChromosome.A11, bestChromosome.A12, bestChromosome.A13, bestChromosome.A14, bestChromosome.A15, bestChromosome.A16, bestChromosome.Fitness);
		    Console.ReadKey();
        }
    }
}
