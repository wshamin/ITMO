using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WhatDay1
{
    class WhatDay
    {
        public enum MonthName { January, February, March, April, May, June, July, August, 
            September, October, November, December };
        static void Main(string[] args)
        {
            Console.Write("Введите номер дня года: ");
            string line = Console.ReadLine();
            int dayNum = int.Parse(line);
            int monthNum = 0;

        //    if (dayNum <= 31)
        //    { // January
        //        goto End;
        //    }
        //    else
        //    {
        //        dayNum -= 31;
        //        monthNum++;
        //    }

        //    if (dayNum <= 28)
        //    { // February
        //        goto End;
        //    }
        //    else
        //    {
        //        dayNum -= 28;
        //        monthNum++;
        //    }

        //    if (dayNum <= 31)
        //    { // March
        //        goto End;
        //    }
        //    else
        //    {
        //        dayNum -= 31;
        //        monthNum++;
        //    }

        //    if (dayNum <= 30)
        //    { // April
        //        goto End;
        //    }
        //    else
        //    {
        //        dayNum -= 30;
        //        monthNum++;
        //    }

        //    if (dayNum <= 31)
        //    { // May
        //        goto End;
        //    }
        //    else
        //    {
        //        dayNum -= 31;
        //        monthNum++;
        //    }


        //    if (dayNum <= 30)
        //    { // June
        //        goto End;
        //    }
        //    else
        //    {
        //        dayNum -= 30;
        //        monthNum++;
        //    }

        //    if (dayNum <= 31)
        //    { // July
        //        goto End;
        //    }
        //    else
        //    {
        //        dayNum -= 31;
        //        monthNum++;
        //    }

        //    if (dayNum <= 31)
        //    { // August
        //        goto End;
        //    }
        //    else
        //    {
        //        dayNum -= 31;
        //        monthNum++;
        //    }

        //    if (dayNum <= 30)
        //    { // September
        //        goto End;
        //    }
        //    else
        //    {
        //        dayNum -= 30;
        //        monthNum++;
        //    }

        //    if (dayNum <= 31)
        //    { // October
        //        goto End;
        //    }
        //    else
        //    {
        //        dayNum -= 31;
        //        monthNum++;
        //    }

        //    if (dayNum <= 30)
        //    {
        //        // November
        //        goto End;
        //    }
        //    else
        //    {
        //        dayNum -= 30;
        //        monthNum++;
        //    }

        //    if (dayNum <= 31)
        //    {
        //        // December
        //        goto End;
        //    }
        //    else
        //    {
        //        dayNum -= 31;
        //        monthNum++;
        //    }

        //End:

            foreach (int dayInMonth in DaysInMonths)
            {
                if (dayNum <= dayInMonth) break;
                else
                {
                    dayNum -= dayInMonth;
                    monthNum++;
                }
            }

            string monthName;

            //switch (monthNum)
            //{
            //    case 0:
            //        monthName = "january"; break;
            //    case 1:
            //        monthName = "february"; break;
            //    case 2:
            //        monthName = "march"; break;
            //    case 3:
            //        monthName = "april"; break;
            //    case 4:
            //        monthName = "may"; break;
            //    case 5:
            //        monthName = "june"; break;
            //    case 6:
            //        monthName = "july"; break;
            //    case 7:
            //        monthName = "august"; break;
            //    case 8:
            //        monthName = "september"; break;
            //    case 9:
            //        monthName = "october"; break;
            //    case 10:
            //        monthName = "november"; break;
            //    case 11:
            //        monthName = "december"; break;
            //    default:
            //        monthName = "not done yet"; break;
            //}

            MonthName temp = (MonthName)monthNum;
            monthName = temp.ToString();

            Console.WriteLine("{0} {1}", dayNum, monthName);

        }

        static System.Collections.ICollection DaysInMonths
            = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    }
}
