using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingElementsFrogRiverJumpOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 5;
            int[] A = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };// espera 6
            //int X = 2;
            //int[] A = new int[] { 2, 2, 2, 2, 2 };// espera -1
            var second = solution(X, A);
        }

        private static int solution(int X, int[] A)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (!dic.ContainsKey(i + A[i]))
                {
                    dic.Add(i + A[i], 0);
                }

                if (A[i] == X)
                {

                    if (dic.Count == i + 1
                        )
                        return i;
                    else
                        return -1;
                };
            }

            return -1;
        }
    }
}
