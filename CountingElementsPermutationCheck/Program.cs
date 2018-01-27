using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingElementsPermutationCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = new int[] { 4,1,3,2 }; //sim
            //int[] A = new int[] { 4, 1, 3 }; //não
            int[] A = new int[] { 1, 4, 1 }; //não
            int isPermutation = solution(A);
        }

        private static int solution(int[] A)
        {
            if (A.Length == 1)
            {
                if (A[0] == 1)
                    return 1;
                else
                    return 0;
            }

            int expectedSum = 0;
            int sum = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (dic.ContainsKey(A[i]))
                {
                    return 0;
                }
                else
                {
                    dic.Add(A[i], 0);
                }

                sum += A[i];
                expectedSum += (i + 1);
            }

            return Convert.ToInt32(expectedSum == sum);
        }
    }
}
