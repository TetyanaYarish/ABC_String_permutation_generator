﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_String_permutation_generator
{
   public class Generator
    {
        List<string> stringList = new List<string>();
        public Generator(IStringInputFromUser stringInput)
        {
            stringInput.StringFromUser();
        }
        public Generator()
        {

        }
        public void ReturnInputFromUser(IStringInputFromUser inputFromUser)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter your string number {i + 1}");
                inputFromUser.StringFromUser();
            }
            //stringList.Reverse();
        }
        public void ReturnAllCombinations()
        {
            for (int i = 3; i >= 0; i--)
            {
                //var item = stringList[i - 1];
                var item = (stringList[i - 1]);
                if (i == 0)
                {
                    Console.Write("\n");
                    for (int a = 0; a <= 3; a++)
                    {
                        if (a == 3)
                        {
                            Console.Write("\n" + stringList[0] + stringList[2] + stringList[1]);
                            Console.Write("\n" + stringList[1] + stringList[0] + stringList[2]);
                            Console.Write("\n" + stringList[1] + stringList[2] + stringList[0]);
                            Console.Write("\n" + stringList[2] + stringList[0] + stringList[1]);
                            return;
                        }
                        var item2 = stringList[a];
                        Console.Write(item2);
                    }
                }
                Console.Write(item);
            }
        }
    }
}
