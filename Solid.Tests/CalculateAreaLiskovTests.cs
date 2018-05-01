using System;
using Xunit;
using Solid.Liskov;

namespace Solid.Tests
{
    public class CalculateAreaLiskovTests
    {
        [Fact]
        public void Rectangle_Six_When_3X2_Test()
        {
            var rectangle = new Rectangle { Height = 3, Width = 2 };
            Assert.Equal(6, rectangle.Area());
        }

        [Fact]
        public void Square_Nine_When_3X3_Test()
        {
            var square = new Square { SideLength = 3 };
            Assert.Equal(9, square.Area());
        }
    }
}
