using System;
using System.Collections.Generic;

namespace ABC_String_permutation_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string varListInput = null;
            bool varIsValid = true;

            while (varIsValid)
            {
                Console.WriteLine("Welcome to ABC_String_permutation_generator");
                Console.WriteLine();
                var stringList = new List<string>();

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Enter your string number {i + 1}");
                    varListInput = Console.ReadLine();
                    stringList.Add(varListInput);
                }
                Console.WriteLine("Your list of strings are: ");
                stringList.Reverse();
                for (int i = 3; i >= 0; i--)
                {
                    if(i==0)
                    {
                        Console.Write("\n");
                        for (int a = 0; a <= 3; a++)
                        {
                            if(a==3)
                            {
                                Console.Write("\n"+stringList[0]+ stringList[2] + stringList[1]); 
                                Console.Write("\n"+stringList[1]+ stringList[0] + stringList[2]); 
                                Console.Write("\n"+stringList[1]+ stringList[2] + stringList[0]); 
                                Console.Write("\n"+stringList[2]+ stringList[0] + stringList[1]); 
                                return;                               
                            }
                            var item2 = stringList[a];
                            Console.Write(item2);
                        }
                    }
                    var item = stringList[i-1];
                    Console.Write(item);
                }
            }
           
        }
    }
}
