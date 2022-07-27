using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaxGenerics
{

    internal class GenericFindMax<T> where T : IComparable
    {
        public T[] Values;

        public GenericFindMax(T[] Values)
        {
            this.Values = Values;
        }

        public T[] SortValues(T[] Values)
        {
            Array.Sort(Values);
            return Values;
        }

        // Creating Method to Sort & Find Max Value..
        public T FindMax(T[] values)
        {
            var sortedValues = SortValues(this.Values);
            return sortedValues[sortedValues.Length - 1];
        }

        public T FindMaxMethod()
        {
            var maxValue = FindMax(this.Values);
            return maxValue;
        }
    }
}
