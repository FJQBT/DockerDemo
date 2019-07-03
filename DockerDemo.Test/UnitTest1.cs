using System;
using Xunit;

namespace DockerDemo.Test
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			Action act = () =>
			{
				dynamic a = null;
				var d = a.ddd;
			};

			Assert.Throws<Microsoft.CSharp.RuntimeBinder.RuntimeBinderException>(act);
		}

		[Theory]
		[InlineData(1, 2, 3)]
		[InlineData(11, 22, 33)]
		[InlineData(111, 222, 333)]
		public void SumTest(int a, int b, int sum)
		{
			Assert.Equal(sum, a + b);
		}
	}
}
