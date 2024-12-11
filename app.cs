using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    using System;

    class CoffeShop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Coffee Shop!");
            Console.WriteLine("1. Espresso\n2. Cappuccino\n3. Latte");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine($"You selected {choice}. Enjoy your coffee!");
        }
    }
}
