using System;
using NUnit.Framework;
using Calculator.Core;

namespace Calculator.Tests
{
	public class CalculatorTests
	{
		SimpleCalculator calculator;

		public CalculatorTests ()
		{
		}

		[Test]
		public void TestCalculatorForNegativeNumbers()
		{
			Assert.AreEqual(-15,calculator.AddTwoNumbers(-10,-5));
		}

		[Test]
		public void TestCalculatorForPositiveNumbers()
		{
			Assert.AreEqual(15,calculator.AddTwoNumbers(10,5));
		}

		[SetUp]
		public void SetUpCalculator()
		{
			calculator = new  SimpleCalculator();
		}
	}
}

