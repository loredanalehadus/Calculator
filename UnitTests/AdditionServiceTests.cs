using System;
using Calculator.Web.Services;
using Xunit;

namespace UnitTests
{
    public class AdditionServiceTests
    {
        [Fact]
        public void Add_ShouldReturnSum()
        {
            var sum = AdditionService.Add(2, 2);
            Assert.Equal(4, sum);
        }
    }
}
