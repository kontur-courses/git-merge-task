using NUnit.Framework;

namespace Kontur.Courses.Git
{
	[TestFixture]
	public class Calculator_Should
	{
		[Test]
		public void OneArg()
		{
			var calc = new Calculator();
			Assert.AreEqual(42, calc.Calculate(new[] { "42" }).Value);
			Assert.AreEqual(43, calc.Calculate(new[] { "43" }).Value);
		}

		[Test]
		public void ZeroArg()
		{
			var calc = new Calculator();
			Assert.AreEqual(42, calc.Calculate(new[] { "42" }).Value);
			Assert.AreEqual(42, calc.Calculate(new string[] { }).Value);
			Assert.AreEqual(42, calc.Calculate(new string[] { }).Value);
		}

		[Test]
		public void ThreeArg()
		{
			var calc = new Calculator();
			Assert.AreEqual(55, calc.Calculate(new[] { "42", "+", "13" }).Value);
			Assert.AreEqual(1, calc.Calculate(new[] { "2", "-", "1" }).Value);
		}
	}
}