using System;
using TestNinja.Fundamentals;
using System.Linq;
using NUnit.Framework;

namespace TestNinja.unitTests._2
{
    [TestFixture]
    public class Math_Lab_7var
    {
        private Math_Lab1 c;
        [SetUp]
        public void SetUp()
        {
            c = new Math_Lab1();
        }

        [Test]

        [TestCase(24, 7, true)]
        [TestCase(15, 7, false)]
        public void DifferenceGreaterThan10_24and7_Return14(int a, int b, bool DifferenceGreater)
        {
            //Act  
            var result = c.DifferenceGreaterThan10(a, b);

            //Assert 
            Assert.That(result == DifferenceGreater);
        }
    }
}