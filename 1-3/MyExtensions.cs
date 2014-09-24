using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3
{
    public class MyExtensions
    {
        public int Dispertion(int[] source){
            return (source.Min() - source.Max());
        }
        public int Median(int[] source)
        {
            int[] copy = source;
            Array.Sort(copy);
            if (copy.GetLength(0) % 2 != 0)
                return copy[copy.GetLength(0) / 2];
            else
                return (( (copy[copy.GetLength(0) / 2]-1) + (copy[copy.GetLength(0) / 2]) ) / 2 );
        }
    }
}
