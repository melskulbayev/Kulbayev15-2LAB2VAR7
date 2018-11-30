using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.unitTests._2
{
    [TestFixture]
    public class Assignment1Tests
    { 
        private Assignment1 _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Assignment1();
        }

        [Test]
        [TestCase("Сегодня в Усть-Каменогорске идет снег", "снег")]//берем 2 строки а и б (правильный вариант)
        [TestCase("Сегодня в Усть-Каменогорске идет снег", "дождь")]//берем 2 строки а и б (неправильный вариант)
        public void DoesContainWord(string a, string b)
        {
            var result = _math.DoesContainWord(a); //в значение 'a' передаем значение с TestCase

            Assert.That(result,Does.Contain(b)); //в значение 'b' передаем значение с TestCase и ищем есть ли наше слово 
        }
    }
}