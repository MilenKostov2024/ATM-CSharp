using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class CardHolder
    {
        public string CardNum { get; set; }        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }

        public CardHolder(string cardNum, string firstName, string lastName, decimal balance)
        {
            CardNum = cardNum;            
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }

        public CardHolder()
        {
            CardNum = "";            
            FirstName = "";
            LastName = "";
            Balance = 0;

        }

        public void PrintOptions()
        {
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        public void Deposit(CardHolder currentUser)
        {
            Console.WriteLine("How much money would you like do deposit?");
            decimal deposit = decimal.Parse(Console.ReadLine());
            currentUser.Balance += deposit;
            Console.WriteLine("Thank you for your deposit. You new balance is: " + currentUser.Balance);
        }

        public void Withdraw(CardHolder currentUser)
        {
            Console.WriteLine("How much money would you like do withdraw?");
            decimal withdraw = decimal.Parse(Console.ReadLine());
            if (currentUser.Balance < withdraw)
            {
                Console.WriteLine("Insufficient Balance :(");
            }
            else
            {
                currentUser.Balance -= withdraw;
                Console.WriteLine("Your balance is: " + Balance);
                Console.WriteLine("You are good to go! Thank you :)");
            }
        }

        public void ShowBalance(CardHolder currentUser)
        {
            Console.WriteLine("Current Balance: " + currentUser.Balance);
        }
        
        
    }
}
