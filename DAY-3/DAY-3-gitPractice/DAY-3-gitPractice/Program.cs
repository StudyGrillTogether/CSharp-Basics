using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAY_3_gitPractice
{
    class Bank_account
    {
        public string name;
        private double balance;
        public double deposits;
        public double withdraw;

        public Bank_account(double balance)
        {
            name = "one";
            this.balance = balance;

        }
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("balance value cannot be zero");
                }
                else
                {
                    balance = value;
                }
            }
        }
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception("deposit amount must be greater than zero");
            }
            balance += amount;

        }
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception("the withradawl amountmust be greater than zero");

            }
            else if (amount > balance)
            {
                throw new Exception("insufficet funds");

            }
            else
            {
                balance -= amount;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Bank_account account = new Bank_account(100000);
            bool exit = false;
            while (!exit)
            {
                try
                {
                    Console.WriteLine("1.check bank balance");
                    Console.WriteLine("2.deposit money");
                    Console.WriteLine("3.withdrawm money");
                    Console.WriteLine("4.exit");
                    Console.WriteLine("enter your choice");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("current balance: " + account.Balance);
                            break;
                        case 2:
                            Console.WriteLine("enter deposit amount");
                            double depositamount = Convert.ToDouble(Console.ReadLine());
                            account.Deposit(depositamount);
                            Console.WriteLine("deposit is succesfull");
                            break;
                        case 3:
                            Console.WriteLine("set withdrawl amount:");
                            double withdrawamount = Convert.ToDouble(Console.ReadLine());
                            account.Withdraw(withdrawamount);
                            Console.WriteLine("withdrawl succesful");
                            break;
                        case 4:
                            exit = true;
                            Console.WriteLine("you have exited");
                            break;
                        default:
                            Console.WriteLine("invalid choice");
                            break;
                    }
                }
            catch (Exception ex)
                {
                    Console.WriteLine("error:"+ex.Message);//Exception = the type of error being caught
                   // ex = the variable name we give to the exception object(you can name it anything, like e or error)
                   //ex.Message = the actual error message inside that exception
                }
            }   

        }
    }
}
