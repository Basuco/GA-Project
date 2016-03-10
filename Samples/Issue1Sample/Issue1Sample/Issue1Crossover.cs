using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Crossovers;
using GeneticSharp.Domain.Randomizations;
using HelperSharp;

namespace Issue1Sample
{
    class Issue1Crossover : CrossoverBase
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneticSharp.Domain.Crossovers.OnePointCrossover"/> class.
        /// </summary>
        /// <param name="swapPointIndex">Swap point index.</param>
        public Issue1Crossover(int swapPointIndex) : base(2, 2)
        {
            SwapPointIndex = swapPointIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneticSharp.Domain.Crossovers.OnePointCrossover"/> class.
        /// </summary>
        public Issue1Crossover() : this(0)
        {
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the index of the swap point.
        /// </summary>
        /// <value>The index of the swap point.</value>
        public int SwapPointIndex { get; set; }
        #endregion

        #region Methods        
        /// <summary>
        /// Performs the cross with specified parents generating the children.
        /// </summary>
        /// <param name="parents">The parents chromosomes.</param>
        /// <returns>
        /// The offspring (children) of the parents.
        /// </returns>
        protected override IList<IChromosome> PerformCross(IList<IChromosome> parents)
        {
            var parent1 = parents[0];
            var parent2 = parents[1];

            int longitudParent1 = ((Issue1Chromosome)parent1).getLength();
            int longitudParent2 = ((Issue1Chromosome)parent2).getLength();


            var parent1Point = RandomizationProvider.Current.GetInt(0, 62) + 1;
            var random = RandomizationProvider.Current.GetInt(0, parent1.Length / 63);
            var parent2Point = parent1Point + 63 * random;
            //var offspring2;
            var offspring1 = CreateOffspring(parent1, parent2, parent1Point, parent2Point);
            if ((longitudParent1 == 63) & (longitudParent2 == 63))
            {
                var offspring2 = parent1.CreateNew();
                offspring2.Resize(126);
                offspring2.ReplaceGenes(0, parent1.GetGenes().ToArray());
                offspring2.ReplaceGenes(63, parent2.GetGenes().ToArray());

                int jota = 0;
                while (jota < (((Issue1Chromosome)offspring2).getLength() / 63))
                {
                    Console.WriteLine("A1:{0}, A2:{1}, A3:{2}, A4:{3}, A5:{4}, A6:{5}, A7:{6}, A8:{7}, A9:{8}, A10:{9}, A11:{10}, A12:{11}, A13:{12}, A14:{13}, A15:{14}, A16:{15} with {16} fitness.", offspring2.A1[jota], offspring2.A2[jota], offspring2.A3[jota], offspring2.A4[jota], offspring2.A5[jota], offspring2.A6[jota], offspring2.A7[jota], offspring2.A8[jota], offspring2.A9[jota], offspring2.A10[jota], offspring2.A11[jota], offspring2.A12[jota], offspring2.A13[jota], offspring2.A14[jota], offspring2.A15[jota], offspring2.A16[jota], offspring2.Fitness);
                    jota = jota + 1;
                }
                
                return new List<IChromosome>() { offspring1, offspring2 };
            }
            else
            {
                var offspring2 = CreateOffspring(parent2, parent1, parent2Point, parent1Point);
                return new List<IChromosome>() { offspring1, offspring2 };
            }
            // The minium swap point is 1 to safe generate a gene with at least two genes.
        }

        private static IChromosome CreateOffspring(IChromosome leftParent, IChromosome rightParent, int leftParentPoint, int rightParentPoint)
        {
            var offspring = leftParent.CreateNew();

            offspring.Resize(leftParentPoint + (rightParent.Length - rightParentPoint));
            offspring.ReplaceGenes(0, leftParent.GetGenes().Take(leftParentPoint).ToArray());
            offspring.ReplaceGenes(leftParentPoint, rightParent.GetGenes().Skip(rightParentPoint).ToArray());

            return offspring;
        }

        /// <summary>
        /// Creates the children.
        /// </summary>
        /// <param name="firstParent">The first parent.</param>
        /// <param name="secondParent">The second parent.</param>
        /// <returns>The children chromosomes.</returns>
        protected IList<IChromosome> CreateChildren(IChromosome firstParent, IChromosome secondParent)
        {
            var firstChild = CreateChild(firstParent, secondParent);
            var secondChild = CreateChild(secondParent, firstParent);

            return new List<IChromosome>() { firstChild, secondChild };
        }

        /// <summary>
        /// Creates the child.
        /// </summary>
        /// <returns>The child.</returns>
        /// <param name="leftParent">Left parent.</param>
        /// <param name="rightParent">Right parent.</param>
        protected virtual IChromosome CreateChild(IChromosome leftParent, IChromosome rightParent)
        {
            var cutGenesCount = SwapPointIndex + 1;
            var child = leftParent.CreateNew();
            child.ReplaceGenes(0, leftParent.GetGenes().Take(cutGenesCount).ToArray());
            child.ReplaceGenes(cutGenesCount, rightParent.GetGenes().Skip(cutGenesCount).ToArray());

            return child;
        }
        #endregion
    }
}
