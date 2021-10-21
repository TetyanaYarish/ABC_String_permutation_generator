using System;
using System.Collections.Generic;

namespace ABC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ABC_String_permutation_generator");
            Console.WriteLine();
            Generator2 generator = new();
            bool continueGame = true;
            do
            {
                generator.ReturnInputFromUser();
                generator.ReturnAllCombinations();
                Console.Write("\n");
            } while (continueGame);


        }
    }
}