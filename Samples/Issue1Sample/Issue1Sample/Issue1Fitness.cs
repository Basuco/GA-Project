using System;
using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Fitnesses;

namespace Issue1Sample
{
    class Issue1Fitness : IFitness
    {

        #region Fields
        private string[] matriz;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneticSharp.Domain.Mutations.UniformMutation"/> class.
        /// </summary>
        /// <param name="mutableGenesIndexes">Mutable genes indexes.</param>
        public Issue1Fitness(string[] matrizEjemplos)
        {
            matriz = matrizEjemplos;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Evaluates the Fitness of a specific chromosome
        /// </summary>
        /// <param name="parents">The chromosome.</param>
        /// <returns>
        /// The fitness of the chromosome
        /// </returns>
        public double Evaluate(IChromosome chromo)
        {
            int i = 0;
            int fit = 0;
            string chrom="";
            Issue1Chromosome chromosome = (Issue1Chromosome) chromo;
            int a = 0;
            int tope = (chromosome.getLength() / 63);
            while (i < matriz.Length){
                a = 0;
                while (a < tope){
                    chrom = chromosome.A1[a] + chromosome.A2[a] + chromosome.A3[a] + chromosome.A4[a] + chromosome.A5[a] + chromosome.A6[a];
                    chrom = chrom + chromosome.A7[a] + chromosome.A8[a] + chromosome.A9[a] + chromosome.A10[a] + chromosome.A11[a] + chromosome.A12[a];
                    chrom = chrom + chromosome.A13[a] + chromosome.A14[a] + chromosome.A15[a] + chromosome.A16[a];
                    if (checkAi(chrom, i))
                    {
                        fit = fit + 1;
                        a = tope;
                    }
                    a = a + 1;
                }
                i = i + 1;
            }
            //Console.WriteLine(fit);
            return fit;
        }

        public bool checkAi(string chromosome, int i){
            int j = 0;
            while (j< chromosome.Length){
                if ((matriz[i][j] == '1')&(chromosome[j] != '1')){
                    return false;
                }

                if (j == chromosome.Length-1){
                    if ((matriz[i][j] == '0')&(chromosome[j] != '0')){
                        return false;
                    }
                }

                j = j+1;
            }
            return true;

        }
        #endregion
    }
}
