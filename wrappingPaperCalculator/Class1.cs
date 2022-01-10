using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrappingPaperCalculator
{
    public class WrappingCalculations
    {
        int area = 0;
        int smallestArea = 0;
        int sum1;
        int sum2;
        int sum3;

        public int findArea(int a, int b)
        {
            area = a * b;
            return area;
        }
        public int findSmallestSide(int a, int b, int c)
        {
            sum1 = a * b;
            sum2 = a * c;
            sum3 = b * c; 

            if(sum1 <= smallestArea)

            return smallestArea;
        }
    }
}
