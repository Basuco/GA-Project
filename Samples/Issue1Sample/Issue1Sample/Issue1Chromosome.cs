using System;
using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Randomizations;

namespace Issue1Sample
{
	class Issue1Chromosome : ChromosomeBase
	{
        #region Fields
        private int longitud;
        #endregion

        public Issue1Chromosome (int lengthPadre)
			: base (lengthPadre)
		{
            longitud = lengthPadre;
            for (int i = 0; i < lengthPadre; i++)
            {
                ReplaceGene(i, GenerateGene(i));

            }
        }

        // These properties represents your phenotype.
        public string[] A1
        {
            get
            {
                int a = 0;
                string[] resultado = new string[longitud/63];
                while (a < (longitud / 63))
                {
                    resultado[a] = "" + (string)GetGene(0+(63*a)).Value + (string)GetGene(1+(63 * a)).Value;
                    a = a + 1;
                }
                return resultado;
            }
        }

        public string[] A2
        {
            get
            {
                int a = 0;
                string[] resultado = new string[longitud/63];
                while (a < (longitud / 63))
                {
                    resultado[a] = "" + (string)GetGene(2 + (63 * a)).Value + (string)GetGene(3 + (63 * a)).Value + (string)GetGene(4 + (63 * a)).Value;
                    a = a + 1;
                }
                return resultado;
            }
        }

        public string[] A3
        {
            get
            {
                int a = 0;
                string[] resultado = new string[longitud/63];
                while (a < (longitud / 63))
                {
                    resultado[a] = "" + (string)GetGene(5 + (63 * a)).Value + (string)GetGene(6 + (63 * a)).Value + (string)GetGene(7 + (63 * a)).Value + (string)GetGene(8 + (63 * a)).Value;
                    a = a + 1;
                }
                return resultado;
            }
        }

        public string[] A4
        {
            get
            {
                int a = 0;
                string[] resultado = new string[longitud/63];
                while (a < (longitud / 63))
                {
                    resultado[a] = "" + (string)GetGene(9 + (63 * a)).Value + (string)GetGene(10 + (63 * a)).Value + (string)GetGene(11 + (63 * a)).Value + (string)GetGene(12 + (63 * a)).Value;
                    a = a + 1;
                }
                return resultado;
            }
        }

        public string[] A5
        {
            get
            {
                int a = 0;
                string[] resultado = new string[longitud/63];
                while (a < (longitud / 63))
                {
                    resultado[a] = "" + (string)GetGene(13 + (63 * a)).Value + (string)GetGene(14 + (63 * a)).Value + (string)GetGene(15 + (63 * a)).Value;
                    a = a + 1;
                }
                return resultado;
            }
        }

        public string[] A6
        {
            get
            {
                int a = 0;
                string[] resultado = new string[longitud/63];
                while (a < (longitud / 63))
                {
                    resultado[a] = "" + (string)GetGene(16 + (63 * a)).Value + (string)GetGene(17 + (63 * a)).Value + (string)GetGene(18 + (63 * a)).Value + (string)GetGene(19 + (63 * a)).Value + (string)GetGene(20 + (63 * a)).Value + (string)GetGene(21 + (63 * a)).Value + (string)GetGene(22 + (63 * a)).Value + (string)GetGene(23 + (63 * a)).Value + (string)GetGene(24 + (63 * a)).Value + (string)GetGene(25 + (63 * a)).Value + (string)GetGene(26 + (63 * a)).Value + (string)GetGene(27 + (63 * a)).Value + (string)GetGene(28 + (63 * a)).Value + (string)GetGene(29 + (63 * a)).Value;
                    a = a + 1;
                }
                return resultado;
            }
        }

        public string[] A7
        {
            get
            {
                int a = 0;
                string[] resultado = new string[longitud/63];
                while (a < (longitud / 63))
                {
                    resultado[a] = "" + (string)GetGene(30 + (63 * a)).Value + (string)GetGene(31 + (63 * a)).Value + (string)GetGene(32 + (63 * a)).Value + (string)GetGene(33 + (63 * a)).Value + (string)GetGene(34 + (63 * a)).Value + (string)GetGene(35 + (63 * a)).Value + (string)GetGene(36 + (63 * a)).Value + (string)GetGene(37 + (63 * a)).Value + (string)GetGene(38 + (63 * a)).Value;
                    a = a + 1;
                }
                return resultado;
            }
        }

        public string[] A8
        {
            get
            {
                int a = 0;
                string[] resultado = new string[longitud/63];
                while (a < (longitud / 63))
                {
                    resultado[a] = "" + (string)GetGene(39 + (63 * a)).Value + (string)GetGene(40 + (63 * a)).Value + (string)GetGene(41 + (63 * a)).Value + (string)GetGene(42 + (63 * a)).Value;
                    a = a + 1;
                }
                return resultado;
            }
        }

        public string[] A9
        {
            get
            {

                int a = 0;
                string[] resultado = new string[longitud/63];
                while (a < (longitud / 63))
                {
                    resultado[a] = "" + (string)GetGene(43 + (63 * a)).Value + (string)GetGene(44 + (63 * a)).Value;
                    a = a + 1;
                }
                return resultado;
            }
        }

        public string[] A10
        {
            get
            {
                int a = 0;
                string[] resultado = new string[longitud/63];
                while (a < (longitud / 63))
                {
                    resultado[a] = "" + (string)GetGene(45 + (63 * a)).Value + (string)GetGene(46 + (63 * a)).Value;
                    a = a + 1;
                }
                return resultado;
            }
        }

        public string[] A11
        {
            get
            {
                int a = 0;
                string[] resultado = new string[longitud/63];
                while (a < (longitud / 63))
                {
                    resultado[a] = "" + (string)GetGene(47 + (63 * a)).Value + (string)GetGene(48 + (63 * a)).Value;
                    a = a + 1;
                }
                return resultado;
            }
        }

        public string[] A12
        {
            get
            {
                int a = 0;
                string[] resultado = new string[longitud/63];
                while (a < (longitud / 63))
                {
                    resultado[a] = "" + (string)GetGene(49 + (63 * a)).Value + (string)GetGene(50 + (63 * a)).Value;
                    a = a + 1;
                }
                return resultado;
            }
        }

        public string[] A13
        {
            get
            {
                int a = 0;
                string[] resultado = new string[longitud/63];
                while (a < (longitud / 63))
                {
                    resultado[a] = "" + (string)GetGene(51 + (63 * a)).Value + (string)GetGene(52 + (63 * a)).Value + (string)GetGene(53 + (63 * a)).Value;
                    a = a + 1;
                }
                return resultado;
            }
        }

        public string[] A14
        {
            get
            {
                int a = 0;
                string[] resultado = new string[longitud/63];
                while (a < (longitud / 63))
                {
                    resultado[a] = "" + (string)GetGene(54 + (63 * a)).Value + (string)GetGene(55 + (63 * a)).Value + (string)GetGene(56 + (63 * a)).Value + (string)GetGene(57 + (63 * a)).Value;
                    a = a + 1;
                }
                return resultado;
            }
        }

        public string[] A15
        {
            get
            {
                int a = 0;
                string[] resultado = new string[longitud/63];
                while (a < (longitud / 63))
                {
                    resultado[a] = "" + (string)GetGene(58 + (63 * a)).Value + (string)GetGene(59 + (63 * a)).Value + (string)GetGene(60 + (63 * a)).Value + (string)GetGene(61 + (63 * a)).Value;
                    a = a + 1;
                }
                return resultado;
            }
        }

        public string[] A16
        {
            get
            {
                int a = 0;
                string[] resultado = new string[longitud/63];
                while (a < (longitud / 63))
                {
                    resultado[a] = "" + (string)GetGene(62 + (63 * a)).Value;
                    a = a + 1;
                }
                return resultado;
            }
        }

        
        //public int X { 
		//	get { 
		//		return (int)GetGene (0).Value; 
		//	} 
		//}

		//public int Y { 
		//	get { 
		//		return (int)GetGene (1).Value;
		//	}
		//}
        public int getLength()
        {
            return longitud;
        } 
		public override Gene GenerateGene (int geneIndex)
		{
            Random rnd = new Random();
			int value;
            value = RandomizationProvider.Current.GetInt(0, 2);
            //Console.WriteLine("VALUE: " + value);
            //if (geneIndex == 0) {
            //	value = RandomizationProvider.Current.GetInt (0, 8);
            //} else {
            //	value = RandomizationProvider.Current.GetInt (0, 101);
            //}

            return new Gene(value.ToString());
		}

		public override IChromosome CreateNew ()
		{
			return new Issue1Chromosome (Length);
		}

		public override IChromosome Clone ()
		{
			var clone = base.Clone () as Issue1Chromosome;

			return clone;
		}
	}
}
