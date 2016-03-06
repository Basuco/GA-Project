using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Randomizations;

namespace Issue1Sample
{
	class Issue1Chromosome : ChromosomeBase
	{
		public Issue1Chromosome ()
			: base (63)
		{
            for (int i = 0; i < 63; i++)
            {
                ReplaceGene(i, GenerateGene(i));
            }
            //ReplaceGene (0, GenerateGene (0));
            //ReplaceGene (1, GenerateGene (1));
        }

        // These properties represents your phenotype.
        public string A1
        {
            get
            {
                return ((string)GetGene(0).Value + (string)GetGene(1).Value);
            }
        }

        public string A2
        {
            get
            {
                return ((string)GetGene(2).Value + (string)GetGene(3).Value + (string)GetGene(4).Value);
            }
        }

        public string A3
        {
            get
            {
                return ((string)GetGene(5).Value + (string)GetGene(6).Value + (string)GetGene(7).Value + (string)GetGene(8).Value);
            }
        }

        public string A4
        {
            get
            {
                return ((string)GetGene(9).Value + (string)GetGene(10).Value + (string)GetGene(11).Value + (string)GetGene(12).Value);
            }
        }

        public string A5
        {
            get
            {
                return ((string)GetGene(13).Value + (string)GetGene(14).Value + (string)GetGene(15).Value);
            }
        }

        public string A6
        {
            get
            {
                return ((string)GetGene(16).Value + (string)GetGene(17).Value + (string)GetGene(18).Value + (string)GetGene(19).Value + (string)GetGene(20).Value + (string)GetGene(21).Value + (string)GetGene(22).Value + (string)GetGene(23).Value + (string)GetGene(24).Value + (string)GetGene(25).Value + (string)GetGene(26).Value + (string)GetGene(27).Value + (string)GetGene(28).Value + (string)GetGene(29).Value);
            }
        }

        public string A7
        {
            get
            {
                return ((string)GetGene(30).Value + (string)GetGene(31).Value + (string)GetGene(32).Value + (string)GetGene(33).Value + (string)GetGene(34).Value + (string)GetGene(35).Value + (string)GetGene(36).Value + (string)GetGene(37).Value + (string)GetGene(38).Value);
            }
        }

        public string A8
        {
            get
            {
                return ((string)GetGene(39).Value + (string)GetGene(40).Value + (string)GetGene(41).Value + (string)GetGene(42).Value);
            }
        }

        public string A9
        {
            get
            {
                return ((string)GetGene(43).Value + (string)GetGene(44).Value);
            }
        }

        public string A10
        {
            get
            {
                return ((string)GetGene(45).Value + (string)GetGene(46).Value);
            }
        }

        public string A11
        {
            get
            {
                return ((string)GetGene(47).Value + (string)GetGene(48).Value);
            }
        }

        public string A12
        {
            get
            {
                return ((string)GetGene(49).Value + (string)GetGene(50).Value);
            }
        }

        public string A13
        {
            get
            {
                return ((string)GetGene(51).Value + (string)GetGene(52).Value + (string)GetGene(53).Value);
            }
        }

        public string A14
        {
            get
            {
                return ((string)GetGene(54).Value + (string)GetGene(55).Value + (string)GetGene(56).Value + (string)GetGene(57).Value);
            }
        }

        public string A15
        {
            get
            {
                return ((string)GetGene(58).Value + (string)GetGene(59).Value + (string)GetGene(60).Value + (string)GetGene(61).Value);
            }
        }

        public string A16
        {
            get
            {
                return ((string)GetGene(62).Value);
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

		public override Gene GenerateGene (int geneIndex)
		{
			int value;
            value = RandomizationProvider.Current.GetInt(0, 1);
            //if (geneIndex == 0) {
            //	value = RandomizationProvider.Current.GetInt (0, 8);
            //} else {
            //	value = RandomizationProvider.Current.GetInt (0, 101);
            //}

            return new Gene(value.ToString());
		}

		public override IChromosome CreateNew ()
		{
			return new Issue1Chromosome ();
		}

		public override IChromosome Clone ()
		{
			var clone = base.Clone () as Issue1Chromosome;

			return clone;
		}
	}
}
