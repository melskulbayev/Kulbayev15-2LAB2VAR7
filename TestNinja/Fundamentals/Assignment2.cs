 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestNinja.Fundamentals
{
    public class Assignment2
    {
        public IEnumerable<int> FindingSymbolinMassive(string Mchar,char letter)
        {
            //ищем символ в тексте, цикл задается в длине текста
            for (var i = 0; i < Mchar.Length; i++)
                if (Mchar[i]==letter) //если в тексте есть одинаковые символы то возвращает его местоположение как массив
                    yield return i;
        }
    }
}