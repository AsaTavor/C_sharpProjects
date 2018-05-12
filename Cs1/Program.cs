using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string str1=Console.ReadLine();
            string str2 = Console.ReadLine();
            Console.WriteLine(Convert.ToChar(str1) - Convert.ToChar(str2));
        }
    }
}
