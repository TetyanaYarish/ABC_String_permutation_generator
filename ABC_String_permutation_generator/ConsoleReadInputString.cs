using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_String_permutation_generator
{
    public class ConsoleReadInputString : IStringInputFromUser
    {
        public string StringFromUser()
        {
            string stringInput = Console.ReadLine().ToUpper();
            return stringInput;
        }
    }
}
