using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonChallengeSolutions.TimeComplexity
{
    public class TapeEquilibrium
    {

        //A non-empty array A consisting of N integers is given.Array A represents numbers on a tape.
        //Any integer P, such that 0 < P<N, splits this tape into two non-empty parts: A[0], A[1], ..., A[P − 1] and A[P], A[P + 1], ..., A[N − 1].
        //The difference between the two parts is the value of: |(A[0] + A[1] + ... + A[P − 1]) − (A[P] + A[P + 1] + ... + A[N − 1])|
        //In other words, it is the absolute difference between the sum of the first part and the sum of the second part.

        //For example, consider array A such that:

        //  A[0] = 3
        //  A[1] = 1
        //  A[2] = 2
        //  A[3] = 4
        //  A[4] = 3
        //We can split this tape in four places:

        //P = 1, difference = | 3 − 10| = 7
        //P = 2, difference = | 4 − 9| = 5
        //P = 3, difference = | 6 − 7| = 1
        //P = 4, difference = | 10 − 3| = 7
        //Write a function:

        //class Solution { public int solution(int[] A); }

        //that, given a non-empty array A of N integers, returns the minimal difference that can be achieved.

        //For example, given:

        //  A[0] = 3
        //  A[1] = 1
        //  A[2] = 2
        //  A[3] = 4
        //  A[4] = 3

        //the function should return 1, as explained above.

        //Write an efficient algorithm for the following assumptions:

        //N is an integer within the range[2..100, 000];
        //each element of array A is an integer within the range[−1, 000..1, 000].

        public int Solution(int[] A)
        {

            int minDifference = int.MaxValue;
            int totalCountOfList = 0;
            int FirstPartOfListCount = 0; 

            if (A == null || A.Length == 0)
                return 0;

            if (A.Length == 1)
                return A[0];

            if (A.Length == 2)
            {
                return Math.Abs(A[0] - A[1]);
            }

            List<int> tempList = new List<int>(A);

            totalCountOfList = tempList.Sum();

            for (int i = 0; i < tempList.Count -1 ; i++)
            {
                try
                {
                    FirstPartOfListCount = FirstPartOfListCount + tempList[i];
                    int SecondPartSum = totalCountOfList - FirstPartOfListCount;

                    var tempValue = Math.Abs(FirstPartOfListCount - SecondPartSum);

                    if (tempValue < minDifference)
                    {
                        minDifference = tempValue;
                    }

                }
                catch
                {
                    return minDifference;
                }
            }

            return minDifference;

        }
    }
}
