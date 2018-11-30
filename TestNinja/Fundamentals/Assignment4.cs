using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestNinja.Fundamentals
{
    public class Assignment4
    {
        public string Month { get; set; }
        public void GetThisMonth(string ThisMonth)
        {       //Если наш введенный месяц соответстует текущему месяцу то параметр равняется к системнему месяцу
            if (ThisMonth == DateTime.Now.ToString("MMMM")) { Month= DateTime.Now.ToString("MMMM"); }
        }
    }
}