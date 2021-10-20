using System;
using System.Collections.Generic;

namespace ABC_String_permutation_generator
{
    class Program
    {
        private static object random;

        static void Main(string[] args)
        {
            var random = new Random();
            var list = new List<string> { "A", "B", "C", "D" };
            int index1 = random.Next(list.Count);
            var one = list[index1];
            Console.Write(one);
            list.Remove(one);
            int index2 = random.Next(list.Count);
            var two = list[index2];
            Console.Write(two);
            list.Remove(two);
            int index3 = random.Next(list.Count);
            var three = list[index3];
            Console.Write(three);
            list.Remove(three);
            int index4 = random.Next(list.Count);
            var four = list[index4];
            Console.Write(four);
            list.Remove(four);
        }
    }
}