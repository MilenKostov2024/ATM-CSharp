using System;
using ATM;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            CardHolder cardHolder = new CardHolder();
            Console.WriteLine("ATM");
            Console.WriteLine("Enter number on debit card: ");
            string cardNum = Console.ReadLine();
            Console.WriteLine("Enter your name on card: ");
            string cardHolderName = Console.ReadLine();            

            Console.WriteLine("Welcome " + cardHolderName + " :)");
            int option = 0;
            do
            {
                cardHolder.PrintOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input, please enter a number.");
                    continue;
                }
                if (option == 1)
                {
                    cardHolder.Deposit(cardHolder);
                }
                else if (option == 2)
                {
                    cardHolder.Withdraw(cardHolder);
                }
                else if (option == 3)
                {
                    cardHolder.ShowBalance(cardHolder);
                }
                else if (option == 4)
                {
                    Console.WriteLine("Thank you! Have a nice day :)");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option, please choose again.");
                }
            } while (option != 4);            
        }
    }
}
                   