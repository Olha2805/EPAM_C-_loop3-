using System;

namespace LoopTasks
{
    public static class LoopTasks
    {
        /// <summary>
        /// Task 1
        /// </summary>
        public static int SumOfOddDigits(int n)
        {
            int result = 0;
            for (int v = n; v > 0; v = v / 10)
            {
                if (v % 2 == 1)
                {
                    result = result + v % 10;
                }
             
            }
            return result; 

            throw new NotImplementedException();
        }

        /// <summary>
        /// Task 2
        /// </summary>
        public static int NumberOfUnitsInBinaryRecord(int n)
        {
            int result = 0;
            for (int v = n; v > 0; v = v / 2)
            {
                result = result + v % 2;
                
            }
            return result;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Task 3 
        /// </summary>
        public static int SumOfFirstNFibonacciNumbers(int n)
        {
            int result = 0;
            int count = 0;
            for (int x1 = 0, x2 = 1; count < n - 1; count++)
            {
                int xn = x1 + x2;
                result = result + x2;                
                x1 = x2;
                x2 = xn;          
            }
            return result;

            throw new NotImplementedException();
        }
    }
}
