using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestNinja.Fundamentals
{
    public class Assignment3
    {
        //В 3 пункт индивидуальной задании 2
        //Проверка числа на целостность, то есть проверка на квадратный корень
        public ActionResult CheckTheNumberOnTheSquareRoot(double number)
        {
                if (Math.Sqrt(number) %1 == 0)//Проверяем число на квадратный корень, если число разделяется на единичку без остатка 
                    return new NumberIsInteger();//то возвращаем функцию что число целое
                return new NumberIsDouble();//а если число разделяется на единичку с остатком то возвращаем функцию что число дробное
        } 

        public class ActionResult
        {
        }

        public class NumberIsInteger : ActionResult
        { 
        }

        public class NumberIsDouble : ActionResult
        {
        }
    }
}