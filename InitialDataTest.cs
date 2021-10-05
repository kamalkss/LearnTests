using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TryTest
{
	public class InitialDataTest
	{
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(5, 5)]
        public void should_be_equal(int value1, int value2)
        {
            Assert.Equal(value1, value2);
        }
	}
}
