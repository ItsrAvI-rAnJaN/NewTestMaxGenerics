using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaxGenerics
{
    public class GenricClassMax<T> where T:IComparable
    {
        //Declaring class/instance level generic variables
        T Value1, Value2, Value3;

        //Generic constructor : parameterized
        public GenricClassMax(T Value1, T Value2, T Value3)
        {
            this.Value1 = Value1;
            this.Value2 = Value2;
            this.Value3 = Value3;
        }

        //Declaring generic method for calculation
        public static T MaxAmongThree(T Value1, T Value2, T Value3)
        {
            if (Value1.CompareTo(Value2) > 0 && Value1.CompareTo(Value3) > 0)
            {
                return Value1;
            }
            if (Value2.CompareTo(Value1) > 0 && Value2.CompareTo(Value3) > 0)
            {
                return Value2;
            }
            if (Value3.CompareTo(Value1) > 0 && Value3.CompareTo(Value2) > 0)
            {
                return Value3;
            }
            return Value1;
        }

        //Internal method to pass three instance variables
        public T TestMaximum()
        {
            T maxTest = GenricClassMax<T>.MaxAmongThree(this.Value1, this.Value2, this.Value3);
            return maxTest;
        }
    }
}
