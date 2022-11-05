using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divider
{
    internal class DivideIt
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первое число: ");
                string temp = Console.ReadLine();
                int i = Int32.Parse(temp);
                Console.WriteLine("Введите второе число: ");
                temp = Console.ReadLine();
                int j = Int32.Parse(temp);
                int k = i / j;
                Console.WriteLine(k);
                Console.WriteLine("Результат деления {0} на {1} равен {2}", i, j, k);
            } catch (Exception e)
            {
                Console.WriteLine("Выброшено исключение: {0}", e);
            }
        }
    }
}
