﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonChallengeSolutions.Iterations
{
    public class BinaryGap
    {
        //Challenge
        //A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones
        //at both ends in the binary representation of N.
        //For example, number 9 has binary representation 1001 and contains a binary gap of length 2.
        //The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3.
        //The number 20 has binary representation 10100 and contains one binary gap of length 1.
        //The number 15 has binary representation 1111 and has no binary gaps.The number 32 has binary representation 100000 and has no binary gaps.
        
        //Write a function:
        
        //class Solution { public int solution(int N); }
        //that, given a positive integer N, returns the length of its longest binary gap.The function should return 0 if N doesn't contain a binary gap.
        //For example, given N = 1041 the function should return 5, because N has binary representation 10000010001 and
        //so its longest binary gap is of length 5. Given N = 32 the function should return 0, because N has binary representation '100000'
        //and thus no binary gaps.
        //Write an efficient algorithm for the following assumptions:
        //N is an integer within the range[1..2, 147, 483, 647].

        public int Solution(int N)
        {
            int maxBinaryGap = 0;
            int binaryGapCounter = 0;
        
            string binary = Convert.ToString(N, 2);

            foreach(var item in binary)
            {
                
                if (item == '1')
                {
                    if(binaryGapCounter > maxBinaryGap)
                    {
                        maxBinaryGap = binaryGapCounter;
                    }

                    binaryGapCounter = 0;
                    continue;
                }
                else if (item == '0')
                {
                    binaryGapCounter++;
                    continue;

                }

            }

            return maxBinaryGap;

        }
    }

}

