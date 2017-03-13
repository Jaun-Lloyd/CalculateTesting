using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorOps.Test
{
	[TestClass]
	public class CalculateTest
	{
		[TestMethod]
		public void ShouldReturnSeven()
		{
			Calculate cal = new Calculate();
			int result = cal.Sum(4, 3);
			Assert.AreEqual(7, result);
		}
		[TestMethod]
		public void ShouldReturnTwelve()
		{
			Calculate cal = new Calculate();
			int result = cal.Multiply(4, 3);
			Assert.AreEqual(12, result);
		}
	}
}
