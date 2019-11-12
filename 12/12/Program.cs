using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "a4n287b898";
            char[] ch = s.ToCharArray();
            var count = ch.Where((n) => n >= '0' && n <= '9').Count();
            Console.WriteLine("Кол-во цифр в строке:" + count);
            Console.ReadKey();
        }
    }
}
