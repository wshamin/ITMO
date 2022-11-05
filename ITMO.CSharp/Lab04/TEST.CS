namespace Utils
{
    using System;

    /// <summary>
    ///   This is the test harness
    /// </summary>

    public class Test
    {
        public static void Main()
        {
            // Упражнение 1

            /* 
            int x, y;
            Console.Write("Введите первое число: ");
            x = Int32.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            y = Int32.Parse(Console.ReadLine());

            int greater = Utils.Greater(x, y);
            Console.WriteLine("Большее из них это {0}", greater);
            */

            // Упражнение 2

            /*
            Console.Write("Введите значение переменной x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите значение переменной y: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Перед заменой x равен {0}, y равен {1}", x, y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("После замены x равен {0}, y равен {1}", x, y);
            */

            // Упражнение 3

            bool ok;
            int f;

            Console.Write("Введите число для рассчета факториала: ");
            int x = int.Parse(Console.ReadLine());
            ok = Utils.Factorial(x, out f);

            if (ok) Console.WriteLine("Факториал {0} равен {1}", x, f);
            else Console.WriteLine("Произошла ошибка");
        }
    }
}
