using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaxGenerics
{
    public class FindMaxNumber
    {
        //Method to Find Max Integer Number
        public int FindMaxAmongInt(int Num1, int Num2, int Num3)
        {
            // Use CompareTO Comparision B/W Three Integer Number
            if (Num1.CompareTo(Num2) > 0 && Num1.CompareTo(Num3) > 0)
            {
                return Num1; //Return The Greater Number
            }
            if (Num2.CompareTo(Num1) > 0 && Num2.CompareTo(Num3) > 0)
            {
                return Num2;
            }
            if (Num3.CompareTo(Num1) > 0 && Num3.CompareTo(Num2) > 0)
            {
                return Num3;
            }
            return Num1; // Rturn While All Among Three are Equal



        }

    }
}
