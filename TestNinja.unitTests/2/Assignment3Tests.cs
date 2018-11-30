using System;
using NUnit.Framework;
using TestNinja.Fundamentals;
using static TestNinja.Fundamentals.Assignment3;

namespace TestNinja.unitTests._2
{
    [TestFixture]
    public class Assignment3Tests
    {
        private Assignment3 _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Assignment3();
        }
        [Test]//В задании есть пункт: 'она не должна возвращать всегда одну и ту же функцию.' 
        [TestCase(21)]//По этому я создал 2 метода для теста, то есть проверка на то что он возвращает именно ту функцию которую надо
        [TestCase(16)] 
        public void ChekingTheNumberForTheRoot_ReturnNumbIsDouble(double d)
        {
            var controller = new Assignment3();
            var result = controller.CheckTheNumberOnTheSquareRoot(d); //Отправляем число
            Assert.That(result, Is.TypeOf<NumberIsDouble>());//проверяем что тип функции
            Assert.That(result, Is.InstanceOf<NumberIsDouble>());  
        }
        [Test]
        [TestCase(64)]
        [TestCase(101)]
        public void ChekingTheNumberForTheRoot_ReturnNumbIsInteger(double d)
        {
            var controller = new Assignment3();
            var result = controller.CheckTheNumberOnTheSquareRoot(d);
            Assert.That(result, Is.TypeOf<NumberIsInteger>());//проверяем тип функции
            Assert.That(result, Is.InstanceOf<NumberIsInteger>());
        }
    }
}
