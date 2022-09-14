using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using Xunit;
using Calc2;

namespace Calc2Testing
{
    public class UnitTest1
    {
        //public object Calc2 { get; private set; }

        [Fact]
        public void Division_DivideByZero()
        {

            //Arrange

            double expected = 0;

            //Act
            //var CalcDiv = new Calc2();
            double actual = CalcClass.Division(5, 0);

            //Assert
            Assert.Equal(expected, actual);


        }

        [Theory]
        [InlineData(4, 3, 7)]
        [InlineData(20.3, 3.7, 24)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        [InlineData(-309, -101, -410)]
        [InlineData(9, -9, 0)]
        public void ShouldAddTwoNumbers(double x, double y, double expected)
        {
            //Act
            double actual = CalcClass.Addition(x, y);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 3, 1)]
        [InlineData(20.3, 3.7, 16.6)]
        [InlineData(double.MaxValue, double.MaxValue, 0)]
        [InlineData(-309, -101, -208)]
        [InlineData(-9, -9, 0)]
        public void ShouldSubtractTwoNumbers(double x, double y, double expected)
        {
            double actual = CalcClass.Subtraction(x, y);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(4, 3, 12)]
        [InlineData(20.3, 3.7, 75.11)]
        [InlineData(-309, -101, 31209)]
        [InlineData(9, -9, -81)]
        [InlineData(0, 3, 0)]
        public void ShouldMultiplyTwoNumbers(double x, double y, double expected)
        {
            double actual = CalcClass.Multiplication(x, y);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 4, 1)]
        [InlineData(20.3, 0, 0)]
        [InlineData(-300, -100, 3)]
        [InlineData(9, -9, -1)]
        [InlineData(0, 3, 0)]
        public void ShouldDivideTwoNumbers(double x, double y, double expected)
        {
            double actual = CalcClass.Division(x, y);
            Assert.Equal(expected, actual);
        }
    }
}
