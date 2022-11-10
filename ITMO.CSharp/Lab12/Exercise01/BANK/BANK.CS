using System.Collections;

namespace Banking
{
	public class Bank
	{
		private static Hashtable accounts = new Hashtable();

		private Bank()
		{
		}
		public static long CreateAccount()
		{
			BankAccount newAcc = new BankAccount();
			long accNo = newAcc.Number;
			accounts[accNo] = newAcc;
			return accNo;
		}

		public static long CreateAccount(AccountType aType, decimal aBal)
		{
			BankAccount newAcc = new BankAccount(aType, aBal);
			long accNo = newAcc.Number;
			accounts[accNo] = newAcc;
			return accNo;
		}

		public static long CreateAccount(AccountType aType)
		{
			BankAccount newAcc = new BankAccount(aType);
			long accNo = newAcc.Number;
			accounts[accNo] = newAcc;
			return accNo;
		}

		public static long CreateAccount(decimal aBal)
		{
			BankAccount newAcc = new BankAccount(aBal);
			long accNo = newAcc.Number;
			accounts[accNo] = newAcc;
			return accNo;
		}

		public static bool CloseAccount(long accNo)
		{
			try
			{
				BankAccount closing = (BankAccount)accounts[accNo];
				accounts.Remove(accNo);
				closing.Dispose();
				return true;
			}
			catch
			{
				return false;
			}
		}

		public static BankAccount GetAccount (long accNo)
		{
			return (BankAccount)accounts[accNo];
		}
	}
}
