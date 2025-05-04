using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main()
        {
            Product apple = new Product("Яблуко", 5, 100);
            Console.WriteLine(apple.GetInfo());


        }
    }
}
