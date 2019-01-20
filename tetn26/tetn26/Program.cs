using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetn26
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = "Button9";
            string[] stringSeparators = new string[] { "Button" };
            string[] result;

            string i1 = "строка для изменения в мейн";
            string i2 = "строка для изменения в первой ветке";
            string i3 = "строка для изменения в первой второй";

            result = source.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
