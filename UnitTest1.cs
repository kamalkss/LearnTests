using Xunit;

namespace TryTest
{
	public class UnitTest1
	{
		[Fact]
		public void Should_be_equal()
        {
            var ExceptedValue = 2;
            var ActualValue = 2;
			Assert.Equal(ExceptedValue,ActualValue);
        }
	}
}