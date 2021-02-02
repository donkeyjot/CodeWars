using System;
using System.Collections.Generic;
using Xunit;
using FinalKata;

namespace TestProject1
{
    public class KataTest
    {
        [Fact]
        public void PositiveTest()
        {
            //Arrange
            KataClass kataClass = new KataClass();
            var input = "There is one sentence that is a bit longer. The second one. Screw This one.";
            var result = new List<List<string>>();
            var expected1 = new List<string>(){"There", "is", "one", "sentence", "that"};
            var expected2 = new List<string>(){"is", "a", "bit", "longer."};
            var expected3 = new List<string>(){"The", "second", "one."};
            var expected4 = new List<string>(){"Screw", "This", "one."};
            
            //Act
            var testResult = kataClass.SubtitleMaker(input);
            
            //Assert

            Assert.Equal(expected1, testResult[0]);
            Assert.Equal(expected2, testResult[1]);
            Assert.Equal(expected3, testResult[2]);
            Assert.Equal(expected4, testResult[3]);

        }
    }
}