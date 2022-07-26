using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaxGenerics
{
    public class FindMaxString
    {
        // Method to Find Max String Value
        public string FindMaxAmongString(string String1, string String2, string String3)
        {
            // Use CompareTO Comparision B/W Three String Value
            if (String1.CompareTo(String2) > 0 && String1.CompareTo(String3) > 0)
            {
                return String1; //Return The Greater String Value
            }
            if (String2.CompareTo(String1) > 0 && String2.CompareTo(String3) > 0)
            {
                return String2;
            }
            if (String3.CompareTo(String1) > 0 && String3.CompareTo(String2) > 0)
            {
                return String3;
            }
            return String1; // Return While All Among Three are Equal

        }
    }
}
