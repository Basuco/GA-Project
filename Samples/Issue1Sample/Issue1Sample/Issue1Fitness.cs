using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Fitnesses;

namespace Issue1Sample
{
    class Issue1Fitness : IFitness
    {

        #region Fields
        private string[] matrizEjemplos;
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
        public double Evaluate(IChromosome chromosome)
        {
            int i = 0;
            int fit = 0;
            string chrom="";
            chrom = chromosome.A1 + chromosome.A2 + chromosome.A3 + chromosome.A4 + chromosome.A5 + chromosome.A6;
            chrom = chrom + chromosome.A7 + chromosome.A8 + chromosome.A9 + chromosome.A10 + chromosome.A11 + chromosome.A12;
            chrom = chrom + chromosome.A13 + chromosome.A14 + chromosome.A15 + chromosome.A16;
            while( i < 650){
                fit = fit + checkAi(chrom,i);
// BREAK en caso de tener varios
//                if (fit > 0){
//                    i = 650;
//                }
                i = i + 1;
            }
//            double n = 9;
//            var x = (int)chromosome.GetGene(0).Value;
//            var y = (int)chromosome.GetGene(1).Value;
//            double f1 = System.Math.Pow(15 * x * y * (1 - x) * (1 - y) * System.Math.Sin(n * System.Math.PI * x) * System.Math.Sin(n * System.Math.PI * y), 2);

            return fit;
        }

        private int checkAi(string chromosome, int i){
            bool verdad = true;
            int j = 0;
            while ((verdad)&(j< chromosome.Length)){
                if ((matriz[i][j] == "1")&(chromosome[j] != "1")){
                    verdad = false;
                }

                if (j == chromosome.Length-1){
                    if ((matriz[i][j] == "0")&(chromosome[j] != "0")){
                        verdad = false;
                    }
                }

                j = j+1;
            }
            if (verdad) {
                return 1;
            }
            return 0;

        };
        #endregion
    }
}
