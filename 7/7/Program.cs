using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
string S1 = "+ , -";
            string S2 = "+";
            char C = ' ';
 

            Console.WriteLine("Введите строку S1");
           
            Console.WriteLine("Введите строку S2");
                       
 
            Console.WriteLine("Введите символ С");
           
 
            int index = S1.IndexOf(C);
 
            
            string Temp1 = Convert.ToString(C);
            string Temp2 = S2 + C + S2;
 
            string Result = S1.Replace(Temp1, Temp2);
            
            Console.WriteLine("Полученная строка = "+Result);
            Console.ReadKey();
        }
    }
}
