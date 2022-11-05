﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructType
{
    internal class Struct
    {
        public enum AccountType { Checking, Deposit };

        public struct BankAccount
        {
            public long accNo;
            public decimal accBal;
            public AccountType accType;
        }

        static void Main(string[] args)
        {
            BankAccount goldAccount;
            goldAccount.accType = AccountType.Checking;
            goldAccount.accBal = (decimal)3200.00;
            goldAccount.accNo = 123;

            Console.WriteLine("*** Account Summary ***");
            Console.WriteLine("Acct Number {0}", goldAccount.accNo);
            Console.WriteLine("Acct Number {0}", goldAccount.accType);
            Console.WriteLine("Acct Balance ${0}", goldAccount.accBal);
        }
    }
}
