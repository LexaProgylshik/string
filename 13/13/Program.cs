using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "asdakjdhqwopdqihasdfaskldjqwiodhaspodhwqiodhpasodjkxzcvjhasdhaskdh";
            Console.WriteLine(s.All(c => c == 'a' || c =='b'));
            Console.ReadKey();
        }
    }
}
