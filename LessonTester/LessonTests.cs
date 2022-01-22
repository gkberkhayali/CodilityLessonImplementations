using LessonChallengeSolutions.Iterations;
using NUnit.Framework;

namespace LessonTester
{
    public class LessonTests
    {
        private BinaryGap binaryGap;
        [SetUp]
        public void Setup()
        {
            binaryGap = new BinaryGap();
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
    }
}