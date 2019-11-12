using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Convert.ToString(Console.ReadLine()); 
for (int i = 0; i < s.Length - 1; i+=3) 
{ 

Console.Write(s[i]+ ","); 

} 
Console.ReadKey(); 

string c = Convert.ToString(Console.ReadLine()); 
int x = s.Length; 
if (s.Length > 5) 
{ 
Console.WriteLine(s[0] + "," + c[1] + "," + c[2] + "," + c[s.Length - 3] + "," + c[s.Length - 2] + "," + c[s.Length - 1]); 

} 
else 
while(x>0){ 
x -= 1; 
Console.WriteLine(s[0]); 
} 

Console.ReadKey();

        }
    }
}
