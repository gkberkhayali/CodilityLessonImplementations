using LessonChallengeSolutions.Arrays;
using LessonChallengeSolutions.Iterations;
using NUnit.Framework;
using System.Linq;

namespace LessonTester
{
    public class LessonTests
    {
        private BinaryGap binaryGap;
        private CyclicRotation cyclicRotation;
        private OddOccurrencesInArray oddOccurrencesInArray;

        [SetUp]
        public void Setup()
        {
            binaryGap = new BinaryGap();
            cyclicRotation = new CyclicRotation();
            oddOccurrencesInArray = new OddOccurrencesInArray();
        }

        [Test]
        public void BinaryGapCounter()
        {

            var result1 = binaryGap.Solution(1041);
            var result2 = binaryGap.Solution(32);
            var result3 = binaryGap.Solution(999);
            var result4 = binaryGap.Solution(0);
            var result5 = binaryGap.Solution(147483647);
            var result6 = binaryGap.Solution(328);

            if (result1 != 5)
            {
                Assert.Fail();
            }

            if (result2 != 0)
            {
                Assert.Fail();
            }

            if (result3 != 2)
            {
                Assert.Fail();
            }


            if (result4 != 0)
            {
                Assert.Fail();
            }

            if (result5 != 3)
            {
                Assert.Fail();
            }

            if (result6 != 2)
            {
                Assert.Fail();
            }

        }

        [Test]
        public void CyclicRotation()
        {
            
            var result1 = cyclicRotation.Solution(new int[] { 3, 8, 9, 7, 6 }, 3);
            var result2 = cyclicRotation.Solution(new int[] {0,0,0 }, 1);
            var result3 = cyclicRotation.Solution(new int[] { 1, 2, 3, 4 }, 4);
            var result4 = cyclicRotation.Solution(new int[] { }, 3);

            if (!Helpers.Helper.Instance.IsSequenceEqual(new int[] { 9,7,6,3,8 }, result1))
            {
                Assert.Fail();
            }

            if (!Helpers.Helper.Instance.IsSequenceEqual(new int[] { 0,0,0 }, result2))
            {
                Assert.Fail();
            }

            if (!Helpers.Helper.Instance.IsSequenceEqual(new int[] { 1, 2, 3, 4 }, result3))
            {
                Assert.Fail();
            }

            if (!Helpers.Helper.Instance.IsSequenceEqual(new int[] { }, result4))
            {
                Assert.Fail();
            }

        }

        [Test]
        public void OddOccurencesInArray()
        {

            var result1 = oddOccurrencesInArray.Solution(new int[] { 1,2,3,3,2,1,7 });
            var result2 = oddOccurrencesInArray.Solution(new int[] { 7, 1, 2, 2, 1 });
            var result3 = oddOccurrencesInArray.Solution(new int[] { 1,3,3,4,1 });
            var result4 = oddOccurrencesInArray.Solution(new int[] { });
  

            if (result1 != 7)
            {
                Assert.Fail();
            }

            if (result2 != 7)
            {
                Assert.Fail();
            }

            if (result3 != 4)
            {
                Assert.Fail();
            }

            if (result4 != 0)
            {
                Assert.Fail();
            }

        }



    }
}