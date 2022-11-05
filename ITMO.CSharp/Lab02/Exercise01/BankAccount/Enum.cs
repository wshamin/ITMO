﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Enum
    {
        public enum AccountType { Checking, Deposit };
        static void Main(string[] args)
        {
            AccountType goldAccount = AccountType.Checking;
            AccountType platinumAccount = AccountType.Deposit;

            Console.WriteLine("The Customer Account Type is {0}", goldAccount);
            Console.WriteLine("The Customer Account Type is {0}", platinumAccount);
        }
    }
}
