using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.unitTests._2
{
    [TestFixture]
    public class Assignment2Tests
    {
        //Я сделал поиск символа в тексте, то есть если в тексте есть похожий символ
        // на который мы ищем то он запоминает его местоположение и передает в массив
        private Assignment2 _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Assignment2();
        }

        [Test]
        [TestCase("Астана это столица Казахстана!", ' ')]
        [TestCase("Астана-столица",' ')]
        public void FindingSymbolinMassive_3(string Mchar, char letter)
        {
            
            var result = _math.FindingSymbolinMassive(Mchar,letter);
            Assert.That(result, Is.EquivalentTo(new[] { 6, 10, 18 }));
        }
    }
}