using LessonChallengeSolutions.Arrays;
using LessonChallengeSolutions.CountingElements;
using LessonChallengeSolutions.Iterations;
using LessonChallengeSolutions.TimeComplexity;
using NUnit.Framework;
using System.Linq;

namespace LessonTester
{
    public class LessonTests
    {
        private BinaryGap binaryGap;
        private CyclicRotation cyclicRotation;
        private OddOccurrencesInArray oddOccurrencesInArray;
        private FrogJmp frogJmp;
        private PermMissingElem permMissingElem;
        private TapeEquilibrium tapeEquilibrium;
        private FrogRiverOne frogRiverOne;
        private PermCheck permCheck;
        private MaxCounters maxCounters;

        [SetUp]
        public void Setup()
        {
            binaryGap               = new BinaryGap();
            cyclicRotation          = new CyclicRotation();
            oddOccurrencesInArray   = new OddOccurrencesInArray();
            frogJmp                 = new FrogJmp();
            permMissingElem         = new PermMissingElem();
            tapeEquilibrium         = new TapeEquilibrium();
            frogRiverOne            = new FrogRiverOne();
            permCheck               = new PermCheck();
            maxCounters             = new MaxCounters();
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

        [Test]
        public void FrogJmp()
        {

            var result1 = frogJmp.Solution(10,80,30);
            var result2 = frogJmp.Solution(-10, 10, 10);
            var result3 = frogJmp.Solution(100, 10, 30);
            var result4 = frogJmp.Solution(-100, 25, 20);


            if (result1 != 3)
            {
                Assert.Fail();
            }

            if (result2 != 2)
            {
                Assert.Fail();
            }

            if (result3 != 0)
            {
                Assert.Fail();
            }

            if (result4 != 7)
            {
                Assert.Fail();
            }

        }

        [Test]
        public void PermMissingElem()
        {

            var result1 = permMissingElem.Solution(new int[] {});
            var result2 = permMissingElem.Solution(new int[] { 1 });
            var result3 = permMissingElem.Solution(new int[] { 2 });
            var result4 = permMissingElem.Solution(new int[] { 1, 2 });
            var result5 = permMissingElem.Solution(new int[] { 2, 3 });
            var result6 = permMissingElem.Solution(new int[] { 1,2,3,7,4,5});
            


            if (result1 != 1)
            {
                Assert.Fail();
            }


            if (result2 != 2)
            {
                Assert.Fail();
            }

            if (result3 != 1)
            {
                Assert.Fail();
            }

            if (result4 != 3)
            {
                Assert.Fail();
            }

            if (result5 != 1)
            {
                Assert.Fail();
            }

            if (result6 != 6)
            {
                Assert.Fail();
            }

        }

        [Test]
        public void TapeEquilibrium()
        {

            var result1 = tapeEquilibrium.Solution(new int[] { 3, 1, 2, 4, 3 });
            var result2 = tapeEquilibrium.Solution(new int[] { 1, 1, 3 });
            var result3 = tapeEquilibrium.Solution(new int[] { -10, -20, -30, -40, 100 });

            

            if (result1 != 1)
            {
                Assert.Fail();
            }

            if (result2 != 1)
            {
                Assert.Fail();
            }

            if (result3 != 20)
            {
                Assert.Fail();
            }



        }

        [Test]
        public void FrogRiverOne()
        {

            var result1 = frogRiverOne.Solution(5,new int[] { 1, 3, 1, 4, 2, 3, 5, 4 });
            
            if (result1 != 6)
            {
                Assert.Fail();
            }

        }

        [Test]
        public void PermCheck()
        {
            var result1 = permCheck.Solution(new int[] {4,1,3,2});
            var result2 = permCheck.Solution(new int[] { 4, 1, 2 });
            var result3 = permCheck.Solution(new int[] { });
            var result4 = permCheck.Solution(new int[] { 1});
            var result5 = permCheck.Solution(new int[] { 3 });


            if (result1 != 1)
            {
                Assert.Fail();
            }

            if (result2 != 0)
            {
                Assert.Fail();
            }

            if (result3 != 0)
            {
                Assert.Fail();
            }

            if (result4 != 1)
            {
                Assert.Fail();
            }

            if (result5 != 0)
            {
                Assert.Fail();
            }

        }

        [Test]
        public void MaxCounters()
        {
            var result1 = maxCounters.Solution(5, new int[] { 3, 4, 4, 6, 1, 4, 4 });
      
            //if (result1 != 1)
            //{
            //    Assert.Fail();
            //}

           

        }


    }
}