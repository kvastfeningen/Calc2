using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using Xunit;
using Calc1;

namespace Calc1.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Division_DivideByZero()
        {
            //Arrange

            double expected = 0;

            //Act
            double actual = Calc2.Division(5, 0);

            //Assert
            Assert.Equal(expected, actual);


        }
    }
}
