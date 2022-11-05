using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greetings
{
    internal class Greeter
    {
        static void Main(string[] args)
        {
            string myName;
            Console.WriteLine("Введите имя пользователя: ");
            myName = Console.ReadLine();
            Console.WriteLine("Hello " + myName);
        }
    }
}
