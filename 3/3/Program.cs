using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = string.Empty;
            int count = 0;
            Console.WriteLine("Input string line");
            inputLine = Console.ReadLine();
            count = inputLine.Length;
            Console.WriteLine("First:{0}, Last{1}", inputLine[0]. ToString(), inputLine[count - 1]);
            Console.ReadKey();
        }
    }
}
