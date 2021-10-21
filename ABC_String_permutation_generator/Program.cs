using System;
using System.Collections.Generic;

namespace ABC_String_permutation_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            //  string varListInput = null;
            Console.WriteLine("Welcome to ABC_String_permutation_generator");
            Console.WriteLine();
            Generator generator = new();
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


