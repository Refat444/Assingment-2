using AssignmentStandardEdition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentStandardEdition
{
    class Account
    {
        public int accountNumber;
        public string accountName;
        public string dob;
        public double balance;
        public Address address;

        public Account()
        {
            Console.WriteLine("CreateAccount");
        }
        public Account(int accountNumber, string accountName, string dob, double balance, Address address)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.dob = dob;
            this.balance = balance;
            this.address = address;

        }
        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }
        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }
        public string Dob
        {
            set { this.Dob = value; }
            get { return this.dob; }
        }

        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }

        public Address Address
        {
            set { this.address = value; }
            get { return address; }
        }
    }
        class Savings : Account
        {
            public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    Console.WriteLine("Previous Balance: " + balance);
                    Console.WriteLine("Deposit Amount: " + amount);
                    balance += amount;
                    Console.WriteLine("Current Balance: " + balance);

                }
                else
                {
                    Console.WriteLine("Amount Should be positive");
                }
            }
            public void Withdraw(double amount)
            {
                if (amount > 0 && amount <= balance)
                {
                    Console.WriteLine("Previous Balance:	" + balance);
                    Console.WriteLine("Withdraw Amount:	" + amount);
                    balance -= amount;
                    Console.WriteLine("Current Balance:	" + balance);

                }
                else
                {
                    Console.WriteLine("Amount should be Positive");
                }
            }
            public void Transfer(double amount)
            {
                if (this.balance < amount)
                {
                    Console.WriteLine("Transfer fails");
                }
                else
                {
                    this.balance -= amount;
                    balance += amount;
                    Console.WriteLine("--" + this.balance + "Remaining" + balance);
                }
            }

        }
        class Checking : Account
        {
            public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    Console.WriteLine("Previous Balance: " + balance);
                    Console.WriteLine("Deposit Amount: " + amount);
                    balance += amount;
                    Console.WriteLine("Current Balance: " + balance);

                }
                else
                {
                    Console.WriteLine("Amount Should be positive");
                }
            }
            public void Withdraw(double amount)
            {
                if (amount > 0 && amount <= balance)
                {
                    Console.WriteLine("Previous Balance:	" + balance);
                    Console.WriteLine("Withdraw Amount:	" + amount);
                    balance -= amount;
                    Console.WriteLine("Current Balance:	" + balance);

                }
                else
                {
                    Console.WriteLine("Amount should be Positive");
                }
            }
            public void Transfer(double amount)
            {
                if (this.balance < amount)
                {
                    Console.WriteLine("Transfer fails");
                }
                else
                {
                    this.balance -= amount;
                    balance += amount;
                    Console.WriteLine("--" + this.balance + "Remaining" + balance);
                }
            }

        }
    

}
