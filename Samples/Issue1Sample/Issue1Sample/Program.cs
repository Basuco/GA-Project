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
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Alejandro\Documents\Universidad\Penultimo Trimestre\IA2\GA\GA-Project\GA-Project\Samples\Issue1Sample\Issue1Sample\Datos.txt");
            string[] matriz = new string[690];
            int i = 0;
            int j, k, l;
            string temp;
            string resultado;
            float cont;
            char x;
            l = 0;
            foreach (string line in lines)
            {
                temp = "";
                resultado = "";

                j = 1;
                k = 0;
                while (k < line.Length)
                {
                    x = line[k];
                    if (x == ',')
                    {

                        // ######### A1 ##############
                        if (j == 1)
                        {
                            if (temp.Equals("b"))
                            {
                                resultado = resultado + "10";
                            }
                            else if (temp.Equals("?"))
                            {
                                resultado = resultado + "11";
                            }
                            else {
                                resultado = resultado + "01";
                            }
                        }// ######### A2 ##############
                        else if (j == 2)
                        {
                            if (temp.Equals("?"))
                            {
                                resultado = resultado + "111";
                            }
                            else {
                                cont = float.Parse(temp, System.Globalization.CultureInfo.InvariantCulture);
                                if (cont < 25)
                                {
                                    resultado = resultado + "100";
                                }
                                else if (cont < 39)
                                {
                                    resultado = resultado + "010";
                                }
                                else {
                                    resultado = resultado + "001";
                                }
                            }
                        }// ######### A3 ##############
                        else if (j == 3)
                        {
                            cont = float.Parse(temp, System.Globalization.CultureInfo.InvariantCulture);
                            if (cont < 1)
                            {
                                resultado = resultado + "1000";
                            }
                            else if (cont < 5)
                            {
                                resultado = resultado + "0100";
                            }
                            else if (cont < 10)
                            {
                                resultado = resultado + "0010";
                            }
                            else {
                                resultado = resultado + "0001";
                            }
                        }// ######### A4 ##############
                        else if (j == 4)
                        {
                            if (temp.Equals("u"))
                            {
                                resultado = resultado + "1000";
                            }
                            else if (temp.Equals("y"))
                            {
                                resultado = resultado + "0100";
                            }
                            else if (temp.Equals("l"))
                            {
                                resultado = resultado + "0010";
                            }
                            else if (temp.Equals("?"))
                            {
                                resultado = resultado + "1111";
                            }
                            else {
                                resultado = resultado + "0001";
                            }
                        }// ######### A5 ##############
                        else if (j == 5)
                        {
                            if (temp.Equals("g"))
                            {
                                resultado = resultado + "100";
                            }
                            else if (temp.Equals("p"))
                            {
                                resultado = resultado + "010";
                            }
                            else if (temp.Equals("?"))
                            {
                                resultado = resultado + "111";
                            }
                            else {
                                resultado = resultado + "001";
                            }
                        }// ######### A6 ##############
                        else if (j == 6)
                        {
                            if (temp.Equals("c"))
                            {
                                resultado = resultado + "10000000000000";
                            }
                            else if (temp.Equals("d"))
                            {
                                resultado = resultado + "01000000000000";
                            }
                            else if (temp.Equals("cc"))
                            {
                                resultado = resultado + "00100000000000";
                            }
                            else if (temp.Equals("i"))
                            {
                                resultado = resultado + "00010000000000";
                            }
                            else if (temp.Equals("j"))
                            {
                                resultado = resultado + "00001000000000";
                            }
                            else if (temp.Equals("k"))
                            {
                                resultado = resultado + "00000100000000";
                            }
                            else if (temp.Equals("m"))
                            {
                                resultado = resultado + "00000010000000";
                            }
                            else if (temp.Equals("r"))
                            {
                                resultado = resultado + "00000001000000";
                            }
                            else if (temp.Equals("q"))
                            {
                                resultado = resultado + "00000000100000";
                            }
                            else if (temp.Equals("w"))
                            {
                                resultado = resultado + "00000000010000";
                            }
                            else if (temp.Equals("x"))
                            {
                                resultado = resultado + "00000000001000";
                            }
                            else if (temp.Equals("e"))
                            {
                                resultado = resultado + "00000000000100";
                            }
                            else if (temp.Equals("?"))
                            {
                                resultado = resultado + "11111111111111";
                            }
                            else if (temp.Equals("aa"))
                            {
                                resultado = resultado + "00000000000010";
                            }
                            else {
                                resultado = resultado + "00000000000001";
                            }
                        }// ######### A7 ##############
                        else if (j == 7)
                        {
                            if (temp.Equals("v"))
                            {
                                resultado = resultado + "100000000";
                            }
                            else if (temp.Equals("h"))
                            {
                                resultado = resultado + "010000000";
                            }
                            else if (temp.Equals("bb"))
                            {
                                resultado = resultado + "001000000";
                            }
                            else if (temp.Equals("j"))
                            {
                                resultado = resultado + "000100000";
                            }
                            else if (temp.Equals("n"))
                            {
                                resultado = resultado + "000010000";
                            }
                            else if (temp.Equals("z"))
                            {
                                resultado = resultado + "000001000";
                            }
                            else if (temp.Equals("dd"))
                            {
                                resultado = resultado + "000000100";
                            }
                            else if (temp.Equals("ff"))
                            {
                                resultado = resultado + "000000010";
                            }
                            else if (temp.Equals("?"))
                            {
                                resultado = resultado + "111111111";
                            }
                            else {
                                resultado = resultado + "000000001";
                            }
                        }// ######### A8 ##############
                        else if (j == 8)
                        {
                            cont = float.Parse(temp, System.Globalization.CultureInfo.InvariantCulture);
                            if (cont < 0.04)
                            {
                                resultado = resultado + "1000";
                            }
                            else if (cont < 0.5)
                            {
                                resultado = resultado + "0100";
                            }
                            else if (cont < 10)
                            {
                                resultado = resultado + "0010";
                            }
                            else {
                                resultado = resultado + "0001";
                            }
                        }// ######### A9 ##############
                        else if (j == 9)
                        {
                            if (temp.Equals("t"))
                            {
                                resultado = resultado + "10";
                            }
                            else {
                                resultado = resultado + "01";
                            }
                        }// ######### A10 ##############
                        else if (j == 10)
                        {
                            if (temp.Equals("t"))
                            {
                                resultado = resultado + "10";
                            }
                            else {
                                resultado = resultado + "01";
                            }
                        }// ######### A11 ##############
                        else if (j == 11)
                        {
                            cont = float.Parse(temp, System.Globalization.CultureInfo.InvariantCulture);
                            if (cont < 1)
                            {
                                resultado = resultado + "10";
                            }
                            else {
                                resultado = resultado + "01";
                            }
                        }// ######### A12 ##############
                        else if (j == 12)
                        {
                            if (temp.Equals("t"))
                            {
                                resultado = resultado + "10";
                            }
                            else {
                                resultado = resultado + "01";
                            }
                        }// ######### A13 ##############
                        else if (j == 13)
                        {
                            if (temp.Equals("g"))
                            {
                                resultado = resultado + "100";
                            }
                            else if (temp.Equals("p"))
                            {
                                resultado = resultado + "010";
                            }
                            else {
                                resultado = resultado + "001";
                            }
                        }// ######### A14 ##############
                        else if (j == 14)
                        {
                            if (temp.Equals("?"))
                            {
                                resultado = resultado + "1111";
                            }
                            else {

                                cont = float.Parse(temp, System.Globalization.CultureInfo.InvariantCulture);
                                if (cont < 20)
                                {
                                    resultado = resultado + "1000";
                                }
                                else if (cont < 100)
                                {
                                    resultado = resultado + "0100";
                                }
                                else if (cont < 200)
                                {
                                    resultado = resultado + "0010";
                                }
                                else {
                                    resultado = resultado + "0001";
                                }
                            }
                        }// ######### A15 ##############
                        else if (j == 15)
                        {
                            cont = float.Parse(temp, System.Globalization.CultureInfo.InvariantCulture);
                            if (cont < 8)
                            {
                                resultado = resultado + "1000";
                            }
                            else if (cont < 100)
                            {
                                resultado = resultado + "0100";
                            }
                            else if (cont < 900)
                            {
                                resultado = resultado + "0010";
                            }
                            else {
                                resultado = resultado + "0001";
                            }
                        }
                        j = j + 1;
                        temp = "";
                    }
                    else if (k == line.Length - 1)
                    {
                        if (line[k] == '+')
                        {
                            resultado = resultado + "1";
                        }
                        else {
                            resultado = resultado + "0";
                        }

                    }
                    else {
                        temp = temp + x;
                    }
                    k = k + 1;
                }
                l = l + 1;
                matriz[i] = resultado;
                i = i + 1;
            }

            var selection = new EliteSelection();
            var crossover = new Issue1Crossover(0);
            var mutation = new UniformMutation(true);
            var fitness = new Issue1Fitness(matriz);
            var chromosome = new Issue1Chromosome(63);
            var population = new Population(20, 20, chromosome);

            var ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new GenerationNumberTermination(100);

            Console.WriteLine("GA running...");
            //ga.MutationProbability = 0.2f;
            ga.Start();
            Console.WriteLine("GA done in {0} generations.", ga.GenerationsNumber);

            var bestChromosome = ga.BestChromosome as Issue1Chromosome;
            int jota = 0;
            Console.WriteLine("Best solution found is");
            while (jota < (bestChromosome.getLength()/63)){
                Console.WriteLine("A1:{0}, A2:{1}, A3:{2}, A4:{3}, A5:{4}, A6:{5}, A7:{6}, A8:{7}, A9:{8}, A10:{9}, A11:{10}, A12:{11}, A13:{12}, A14:{13}, A15:{14}, A16:{15} with {16} fitness.", bestChromosome.A1[jota], bestChromosome.A2[jota], bestChromosome.A3[jota], bestChromosome.A4[jota], bestChromosome.A5[jota], bestChromosome.A6[jota], bestChromosome.A7[jota], bestChromosome.A8[jota], bestChromosome.A9[jota], bestChromosome.A10[jota], bestChromosome.A11[jota], bestChromosome.A12[jota], bestChromosome.A13[jota], bestChromosome.A14[jota], bestChromosome.A15[jota], bestChromosome.A16[jota], bestChromosome.Fitness);
                jota = jota + 1;
            }
           Console.ReadKey();
        }


        public string[] readFile(){
            string[] lines = System.IO.File.ReadAllLines(@".\Datos.txt");
            string[] matriz = new string[690];
            int i = 0;
            int j,k,l;
            string temp;
            string resultado;
            float cont;
            char x;
            l = 0;
            foreach (string line in lines)
            {
                temp = "";
                resultado = "";

                j = 1;
                k = 0;
                while (k < line.Length){
                    x = line[k];
                    if( x ==','){

                        // ######### A1 ##############
                        if (j == 1){
                            if (temp.Equals("b")){
                                resultado = resultado + "10";
                            }else if (temp.Equals("?")){
                                resultado = resultado + "11";
                            }else{
                                resultado = resultado + "01";
                            }
                        }// ######### A2 ##############
                        else if (j == 2){
                            if (temp.Equals("?")){
                                resultado = resultado + "111";
                            }else{
                                cont = float.Parse(temp,System.Globalization.CultureInfo.InvariantCulture);
                                if (cont < 25) {
                                    resultado = resultado + "100";
                                }else if (cont < 39){
                                    resultado = resultado + "010";
                                }else {
                                    resultado = resultado + "001";
                                }
                            }
                        }// ######### A3 ##############
                        else if (j == 3){
                            cont = float.Parse(temp,System.Globalization.CultureInfo.InvariantCulture);
                            if (cont < 1) {
                                resultado = resultado + "1000";
                            }else if (cont < 5){
                                resultado = resultado + "0100";
                            }else if (cont <10){
                                resultado = resultado + "0010";
                            }else {
                                resultado = resultado + "0001";
                            }
                        }// ######### A4 ##############
                        else if (j == 4){
                            if (temp.Equals("u")){
                                resultado = resultado + "1000";
                            }else if (temp.Equals("y")){
                                resultado = resultado + "0100";
                            }else if (temp.Equals("l")){
                                resultado = resultado + "0010";
                            }else if (temp.Equals("?")){
                                resultado = resultado + "1111";
                            }else{
                                resultado = resultado + "0001";
                            }
                        }// ######### A5 ##############
                        else if (j == 5){
                            if (temp.Equals("g")){
                                resultado = resultado + "100";
                            }else if (temp.Equals("p")){
                                resultado = resultado + "010";
                            }else if (temp.Equals("?")){
                                resultado = resultado + "111";
                            }else{
                                resultado = resultado + "001";
                            }
                        }// ######### A6 ##############
                        else if (j == 6){
                            if (temp.Equals("c")){
                                resultado = resultado + "10000000000000";
                            }else if (temp.Equals("d")){
                                resultado = resultado + "01000000000000";
                            }else if (temp.Equals("cc")){
                                resultado = resultado + "00100000000000";
                            }else if (temp.Equals("i")){
                                resultado = resultado + "00010000000000";
                            }else if (temp.Equals("j")){
                                resultado = resultado + "00001000000000";
                            }else if (temp.Equals("k")){
                                resultado = resultado + "00000100000000";
                            }else if (temp.Equals("m")){
                                resultado = resultado + "00000010000000";
                            }else if (temp.Equals("r")){
                                resultado = resultado + "00000001000000";
                            }else if (temp.Equals("q")){
                                resultado = resultado + "00000000100000";
                            }else if (temp.Equals("w")){
                                resultado = resultado + "00000000010000";
                            }else if (temp.Equals("x")){
                                resultado = resultado + "00000000001000";
                            }else if (temp.Equals("e")){
                                resultado = resultado + "00000000000100";
                            }else if (temp.Equals("?")){
                                resultado = resultado + "11111111111111";
                            }else if (temp.Equals("aa")){
                                resultado = resultado + "00000000000010";
                            }else{
                                resultado = resultado + "00000000000001";
                            }
                        }// ######### A7 ##############
                        else if (j == 7){
                            if (temp.Equals("v")){
                                resultado = resultado + "100000000";
                            }else if (temp.Equals("h")){
                                resultado = resultado + "010000000";
                            }else if (temp.Equals("bb")){
                                resultado = resultado + "001000000";
                            }else if (temp.Equals("j")){
                                resultado = resultado + "000100000";
                            }else if (temp.Equals("n")){
                                resultado = resultado + "000010000";
                            }else if (temp.Equals("z")){
                                resultado = resultado + "000001000";
                            }else if (temp.Equals("dd")){
                                resultado = resultado + "000000100";
                            }else if (temp.Equals("ff")){
                                resultado = resultado + "000000010";
                            }else if (temp.Equals("?")){
                                resultado = resultado + "111111111";
                            }else{
                                resultado = resultado + "000000001";
                            }
                        }// ######### A8 ##############
                        else if (j == 8){
                            cont = float.Parse(temp,System.Globalization.CultureInfo.InvariantCulture);
                            if (cont < 0.04) {
                                resultado = resultado + "1000";
                            }else if (cont < 0.5){
                                resultado = resultado + "0100";
                            }else if (cont <10){
                                resultado = resultado + "0010";
                            }else {
                                resultado = resultado + "0001";
                            }
                        }// ######### A9 ##############
                        else if (j == 9){
                            if (temp.Equals("t")){
                                resultado = resultado + "10";
                            }else{
                                resultado = resultado + "01";
                            }
                        }// ######### A10 ##############
                        else if (j == 10){
                            if (temp.Equals("t")){
                                resultado = resultado + "10";
                            }else{
                                resultado = resultado + "01";
                            }
                        }// ######### A11 ##############
                        else if (j == 11){
                            cont = float.Parse(temp,System.Globalization.CultureInfo.InvariantCulture);
                            if (cont < 1) {
                                resultado = resultado + "10";
                            }else {
                                resultado = resultado + "01";
                            }
                        }// ######### A12 ##############
                        else if (j == 12){
                            if (temp.Equals("t")){
                                resultado = resultado + "10";
                            }else{
                                resultado = resultado + "01";
                            }
                        }// ######### A13 ##############
                        else if (j == 13){
                            if (temp.Equals("g")){
                                resultado = resultado + "100";
                            }else if (temp.Equals("p")){
                                resultado = resultado + "010";
                            }else{
                                resultado = resultado + "001";
                            }
                        }// ######### A14 ##############
                        else if (j == 14){
                            if (temp.Equals("?")){
                                resultado = resultado + "1111";
                            }else{

                                cont = float.Parse(temp,System.Globalization.CultureInfo.InvariantCulture);
                                if (cont < 20) {
                                    resultado = resultado + "1000";
                                }else if (cont < 100){
                                    resultado = resultado + "0100";
                                }else if (cont <200){
                                    resultado = resultado + "0010";
                                }else {
                                    resultado = resultado + "0001";
                                }
                            }
                        }// ######### A15 ##############
                        else if (j == 15){
                            cont = float.Parse(temp,System.Globalization.CultureInfo.InvariantCulture);
                            if (cont < 8) {
                                resultado = resultado + "1000";
                            }else if (cont < 100){
                                resultado = resultado + "0100";
                            }else if (cont <900){
                                resultado = resultado + "0010";
                            }else {
                                resultado = resultado + "0001";
                            }
                        }
                        j = j + 1;
                        temp = "";
                    }else if (k == line.Length-1){
                        if (line[k]=='+'){
                            resultado = resultado + "1";
                        }else{
                            resultado = resultado + "0";
                        }

                    }else{
                        temp = temp + x;
                    }
                    k = k+1;
                }
                l = l+1;
                matriz[i] = resultado;
                i = i+1;
            }
            
            return matriz;
        }
    }
}
