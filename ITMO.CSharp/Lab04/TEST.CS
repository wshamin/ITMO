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
            // ���������� 1

            /* 
            int x, y;
            Console.Write("������� ������ �����: ");
            x = Int32.Parse(Console.ReadLine());
            Console.Write("������� ������ �����: ");
            y = Int32.Parse(Console.ReadLine());

            int greater = Utils.Greater(x, y);
            Console.WriteLine("������� �� ��� ��� {0}", greater);
            */

            // ���������� 2

            /*
            Console.Write("������� �������� ���������� x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("������� �������� ���������� y: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("����� ������� x ����� {0}, y ����� {1}", x, y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("����� ������ x ����� {0}, y ����� {1}", x, y);
            */

            // ���������� 3

            bool ok;
            int f;

            Console.Write("������� ����� ��� �������� ����������: ");
            int x = int.Parse(Console.ReadLine());
            ok = Utils.Factorial(x, out f);

            if (ok) Console.WriteLine("��������� {0} ����� {1}", x, f);
            else Console.WriteLine("��������� ������");
        }
    }
}
