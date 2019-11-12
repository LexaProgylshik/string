using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (s.Length > 5)
                Console.WriteLine(s.Substring(0, 3) + s.Substring(s.Length - 3));
            else
                Console.WriteLine(new String(s[0], s.Length));
            Console.ReadKey();
        }
    }
}
