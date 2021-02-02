using System.Collections.Generic;
using FinalKata;
using Xunit;

namespace TestProject1
{
    public class FinalTest
    {
        [Fact]
        public void MissingTest()
        {
            var expected = true;
            var input = new int[] {4, 1, 3, 2};
            var actual = FinalKata.FinalKata.NoneIsMissing(input);

            Assert.Equal(expected, actual);
        }
    }

    public class TwoMakesTargetTest
    {
        [Fact]
        public void TwoMakesTest()
        {
            int[] sample1 = new int[] {1, 2, 4, 5, 6,5,2};
            var target1 = 6;
            var result = new List<int[]>();
            result.Add(new int[]{1,5});
            result.Add(new int[]{2,4});

           Assert.Equal(FinalKata.FinalKata.TwoMakesTarget(sample1,target1),result);
        }

        [Fact]
        public void TwoMakesTest2()
        {
            int[] sample1 = new int[] {2,3,4,4};
            var target1 = 8;
            var result = new List<int[]>();
            result.Add(new int[]{4, 4});
            // result.Add(new int[]{2,4});

            Assert.Equal(FinalKata.FinalKata.TwoMakesTarget(sample1,target1),result);
        }
    }
}