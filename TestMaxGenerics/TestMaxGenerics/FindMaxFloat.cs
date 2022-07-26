using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaxGenerics
{
    public class FindMaxFloat
    {
        // Method to Find Max Float Number
        public float FindMaxAmongFloat(float Num1, float Num2, float Num3)
        {
            // Use CompareTO Comparision B/W Three Flloat Number
            if (Num1.CompareTo(Num2) > 0 && Num1.CompareTo(Num3) > 0)
            {
                return Num1; //Return The Greater Float Number
            }
            if (Num2.CompareTo(Num1) > 0 && Num2.CompareTo(Num3) > 0)
            {
                return Num2;
            }
            if (Num3.CompareTo(Num1) > 0 && Num3.CompareTo(Num2) > 0)
            {
                return Num3;
            }
            return Num1; // Return While All Among Three are Equal

        }
    }
}
