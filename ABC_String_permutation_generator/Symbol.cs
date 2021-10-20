using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_String_permutation_generator
{

    public enum EnumInput
    {
        firtsLetter = 1,
        secondLetter = 2,
        therdLetter = 3

    }
    public class Symbol
    {
        public string one = "One";
        string two = "Two";
        string third = "Three";
        public EnumInput input { get; set; }
        List<string> listInput = new() {  };
        EnumInput enumInput;
        public Symbol()
        {
            var firstLetter = Enum.GetValues(typeof(EnumInput)).Cast<EnumInput>();
          foreach(var n in firstLetter)
            {
                var newLetter = new EnumInput();
                //listInput.Add();
            }
        }      
    }
}
