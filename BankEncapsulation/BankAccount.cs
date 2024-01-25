using System;
using System.Collections.Generic;


namespace BankEncapsulation
{
	public class BankAccount
	{
		public BankAccount()
		{
			GenerateAccountNumber();
		}

		private double _balance = 0;

		public string FirstName { get; set; }

		public string LastName { get; set; }

		private static Random ang = new Random();

		private int _accountNumber { get; set; }

		private int GenerateAccountNumber()
		{
            _accountNumber = ang.Next(100000000, 1000000000);
			while (_allAccountNumbers.Contains(_accountNumber))
			{
				_accountNumber = ang.Next(100000000, 1000000000);
			}
			_allAccountNumbers.Add(_accountNumber);
			return _accountNumber;
		}

		public int GetAccountNumber() { return _accountNumber; }

		private List<int> _allAccountNumbers = new List<int>();

        public void Deposit(double x)
		{
			_balance += x;
		}

		public void Withdraw(double x)
		{
			_balance -= x;
		}

		public double GetBalance()
		{
			return _balance;
		}
	}
}

