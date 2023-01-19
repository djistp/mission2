using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] totals = new int[13]; // array to keep track of totals
            int rolls; // number of rolls specified by user
            Random rand = new Random(); // random number generator

            Console.Write("Enter the number of rolls: ");
            rolls = int.Parse(Console.ReadLine());

            for (int i = 0; i < rolls; i++)
            {
                int roll1 = rand.Next(1, 7); // roll the first die
                int roll2 = rand.Next(1, 7); // roll the second die
                int total = roll1 + roll2; // calculate the total
                totals[total]++; // increment the total in the array
            }

            Console.WriteLine("Total\tPercentage\tHistogram");
            for (int i = 2; i <= 12; i++)
            {
                double percentage = ((double)totals[i] / rolls) * 100; // calculate the percentage
                Console.Write(i + "\t" + percentage + "%\t\t");
                int histogram = (int)Math.Round(percentage); // calculate the number of * to print
                for (int j = 0; j < histogram; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
