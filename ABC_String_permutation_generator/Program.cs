﻿using System;
using System.Collections.Generic;

namespace ABC_String_permutation_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            IStringInputFromUser inputFromUser = new ConsoleReadInputString();
            Console.WriteLine("Welcome to ABC_String_permutation_generator");
            Console.WriteLine();
            Generator generator = new();
            bool continueGame = true;
            do
            {
                generator.ReturnInputFromUser(inputFromUser);
                generator.ReturnAllCombinations();
                Console.Write("\n");
            } 
            while (continueGame);
        }
    }
}


