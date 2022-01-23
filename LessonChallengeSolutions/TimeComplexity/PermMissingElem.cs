using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonChallengeSolutions.TimeComplexity
{
    public class PermMissingElem
    {
        //An array A consisting of N different integers is given.The array contains integers in the range[1..(N + 1)], which means that
        //exactly one element is missing.
        //Your goal is to find that missing element.

        //Write a function:

        //class Solution { public int solution(int[] A); }

        //that, given an array A, returns the value of the missing element.
        //For example, given array A such that:

        //A[0] = 2
        //A[1] = 3
        //A[2] = 1
        //A[3] = 5

        //the function should return 4, as it is the missing element.

        //Write an efficient algorithm for the following assumptions:
        //N is an integer within the range[0..100, 000];
        //the elements of A are all distinct;
        //each element of array A is an integer within the range[1..(N + 1)].

        public int Solution(int[] A)
        {
            
            int result = 0; 

            if (A == null || A.Length == 0)
                return 1;

            if (A.Length == 1)
            {
                if (A[0] == 1)
                    return 2;
                else if (A[0] == 2)
                    return 1;
            }

            List<int> tempList = new List<int>(A);
            tempList.Sort();

            if (tempList[0] == 2)
                return 1;


            for (int i = 0; i < tempList.Count;i++)
            {
                try
                {
                    
                    if(tempList[i] +1 == tempList[i+1])
                    {
                        continue;
                    }

                    if(tempList[i] +2 == tempList[i+1])
                    {
                        return tempList[i] + 1;
                    }

                }
                catch
                {
                    return tempList[i] + 1;
                }
            }

            return result;

        }
    }
}
