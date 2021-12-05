using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            char c = (char)num;
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
