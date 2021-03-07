using AssignmentStandardEdition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentStandardEdition
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank mybank = new Bank("",10);
           
            Console.WriteLine("Chose an option");
            Console.WriteLine("1. Type the following commands>>>'open'- to Creat an Account------'account' to manage---------quit to exit");
           

            string option = Console.ReadLine();
            switch (option)
            {
                case "open":
                    Console.WriteLine("You selected to open an account");
                    Console.WriteLine("Enter Account Number");
                    int accountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter name");
                    string accountName = Console.ReadLine();
                    Console.WriteLine("Enter Date of Birth");
                    string dob = Console.ReadLine();
                    Console.WriteLine("Enter Address");
                    string address = Console.ReadLine();
                    Console.WriteLine("Enter Starting Balance");
                    double balance = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter type of account: 1.savings 2.checking ");
                    string option1 = Console.ReadLine();
                    switch (option1)
                    {
                        case "savings":
                            Console.WriteLine("You have created a savings account with the following information:" + accountNumber  + accountName + dob + balance) ;
                            Address ad = new Address("c/5", "Pagla Garod cell 101", "Pabna", "Bangladesh");
                            ad.Details();
                            Console.WriteLine("LoL");
                            break;
                        case "checking":
                            Console.WriteLine("You have created a savings account with the following information:" + accountNumber + accountName + dob + balance);
                            Address cd = new Address("c/5", "Pagla Garod cell 101", "Pabna", "Bangladesh");
                            cd.Details();
                            Console.WriteLine("LoL");
                            break;
                        case "quit":
                            Console.WriteLine("You chose to quit");
                            break;


                    }
                    break;
                case "account":
                    Console.WriteLine("You chosed to manage account");
                    Console.WriteLine("type the any of the commads 1.deposit...2.withdraw ---3.transfer...4.change.....5.show ....6.quit");
                    string option2 = Console.ReadLine();
                    switch (option2)
                    {
                        case "deposit":
                            Console.WriteLine("You chosed to deposit");
                            Console.WriteLine("Enter amount :");

                            double amount = Convert.ToDouble(Console.ReadLine());
                            Savings s = new Savings();
                            s.Deposit(amount);
                            Checking c = new Checking();
                            c.Deposit(amount);


                            break;
                        case "withdraw":
                            Console.WriteLine("Enter amount :");

                            double howmuch = Convert.ToDouble(Console.ReadLine());
                            Savings s1 = new Savings();
                            s1.Withdraw(howmuch);
                            Checking c1 = new Checking();
                            c1.Withdraw(howmuch);
                            break;
                        case "transfer":
                            Console.WriteLine("You chosed to Transfer");
                            Savings s2 = new Savings();
                            s2.Transfer(25000.0);
                            Checking c2 = new Checking();
                            c2.Transfer(25000.0);
                            break;
                        case "change":
                            Console.WriteLine("Enter name");
                            string AN = Console.ReadLine();

                            Account ac = new Savings();
                            ac.accountName = AN;
                     break;
                        case "SHow":
                            Console.WriteLine("There is nothing to show here");
                            break;
                        case "quit":
                            Console.WriteLine("You chose to exit application");
                            Console.WriteLine("Press any key to continue......");
                            break;

            }

            break;
                case "quit":
                    Console.WriteLine("You chose to exit application");
                    Console.WriteLine("Press any key to continue......");
                    break;




            }

        }
    }
}
//Standard edition 73%
//Exclusive edition 85%
//premium edition 100%