using System;

namespace MonteCarloAlgorithm
{
    class Program
    {
        //function for simulating a roulette
        private static char MonteCarlo(char [] symbols,double [] weights)
        {
            Random rnd = new Random();
            double sum_weights = 0;

            for(int index=0;index<weights.Length;index++) //calculating sum of the symbols weights
            {
                sum_weights += weights[index];
            }

            double roulette_nr = rnd.NextDouble() * sum_weights; // gemerate a random number between 0 amd wights sum
            int symbol_index = 0;

            while(roulette_nr>weights[symbol_index]) // decreasing the random number by each symbol's weight to find out which symbol is extracted
            {
                roulette_nr -= weights[symbol_index];
                symbol_index++;
            }
            return symbols[symbol_index];
        }
        static void Main(string[] args)
        {
            
            char[] symbols = { 'd', 's', 'g','a','b','c' };
            double[] weights = { 12, 15, 10, 1, 2, 4 };
            int[] counts = new int[symbols.Length];

            for(int index=0;index<1000;index++) //extracting 1000times a random symbol
            {
                char result = MonteCarlo(symbols, weights);
                for(int ndindex=0;ndindex<symbols.Length;ndindex++)
                {
                    if (symbols[ndindex] == result)
                        counts[ndindex]++;
                }
            }

            for(int index=0;index<counts.Length;index++)
            {
                Console.WriteLine($"{ symbols[index]}={counts[index]}");
            }
        }
    }
}
