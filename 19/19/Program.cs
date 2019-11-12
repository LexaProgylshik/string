using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Login1, LOgin2, login3, loGIN4";
            Console.WriteLine(str.ToLower());
            string[] login = str.Split(',');
                Console.WriteLine(login[0]);
            Console.ReadKey();

        }
    }
}
