using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            string str = "Text";
            foreach (char ch in str)
            {
                if (dict.ContainsKey(ch))
                    dict[ch]++;
                else
                    dict.Add(ch, 1);
            }
            foreach (char key in dict.Keys)
            {
                t.Items.Add(key.ToString() + " - " + dict[key].ToString());
                Console.ReadKey();
            }
        }
    }
}
