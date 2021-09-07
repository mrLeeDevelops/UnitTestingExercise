using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(5,5,5,15)]
        public void Add(int one, int two, int three, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Add(one, two, three);

            //Assert
            Assert.Equal(expected, actual);


        }

        [Theory]
        [InlineData(5, 5, 0)]
        public void Subtract(int menuend, int subtrahend, int expected)
        {
            //Arrange
            var test2 = new UnitTestMethods();

            //Act   
            var actual = test2.Subtract(menuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);
        }
        [InlineData(3, 3, 9)]
        [InlineData(2, 2, 4)]
        [Theory]
        public void Multiply(int one, int two, int expected)
        {
            //Arrange
            var test3 = new UnitTestMethods();

            //Act
            var actual = test3.Multiply(one, two);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(25, 5, 5)]
        [InlineData(24, 3, 8)]


        public void Divide(int dividend, int divisor, int expected)
        {
            //Arrange
            var test4 = new UnitTestMethods();

            //Act
            var actual = test4.Divide(dividend, divisor);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange
            string expected = "Smooth";
            var test5 = new UnitTestMethods();

            //Act
            string actual = test5.YourMethodName();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange
            string expected = "C. L. Smooth";
            var test6 = new UnitTestMethods();

            //Act
            string actual = test6.YourMethodName2();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
