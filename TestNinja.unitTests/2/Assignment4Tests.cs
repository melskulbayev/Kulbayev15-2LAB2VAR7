using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.unitTests._2
{
    [TestFixture]
    public class Assignment4Tests
    {
        [Test]
        public void WhenCalled_SetThisMonth()
        {       //Проверка текущего месяца
            var _month = new Assignment4();
            _month.GetThisMonth("Декабрь");
            Assert.That(_month.Month, Is.EqualTo("Декабрь"));
        }
    }
}
