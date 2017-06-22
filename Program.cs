using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Tommy");
            names.Add(1);
            names.Add(true);

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            string n = names[0];
            Console.WriteLine(n);
                }
    }
}
