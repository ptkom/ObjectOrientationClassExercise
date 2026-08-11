using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClass.Encapsulation
{
    internal class EncapsulationSample
    {
        public void Run()
        {
            DateTime expiryDate = new DateTime(2030, 10, 31);
            BankAccount bankAccount = new BankAccount(1234, "Barbie Roberts", AccountType.Savings, 3000000, 56789, expiryDate);

            Console.WriteLine($"Welcome {bankAccount.AccountHolder}");
            Console.WriteLine($"Your balance is {bankAccount.Balance}");
            Console.WriteLine("-------------------------");

            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine("Would you like to make a transaction?");
                string userInput = Console.ReadLine();


                if (userInput.ToUpper() == "Y")
                {
                    if (bankAccount.Transactions.Count > 0)
                    {
                        //To show how the last transaction made
                        Transaction lasttransaction = bankAccount.Transactions
                             [bankAccount.Transactions.Count - 1];

                        Console.WriteLine($"Last Transaction:Amount {lasttransaction.Amount} Description: {lasttransaction.Description}");
                    }
                    else
                    {
                        Console.WriteLine("No previous transactions found.");
                    }

                    Console.WriteLine("1. Desposit");
                    Console.WriteLine("2. Withdrawal");
                    Console.WriteLine("3. Bank Statement");

                    userInput = Console.ReadLine();
                    if (userInput == "1")
                    {
                        Console.WriteLine("How much would you like to deposit");
                        string userAmount = Console.ReadLine();


                        Console.WriteLine("What is the reference?");
                        string userReference = Console.ReadLine();

                        Console.WriteLine("What is the description?");
                        string userDescription = Console.ReadLine();

                        TransactionResult transactionResult = bankAccount.MakeDeposit(decimal.Parse(userAmount), userReference, userDescription);

                        if (transactionResult == TransactionResult.Successful)
                        {
                            Console.WriteLine($"Transaction Successfu!!! Your new balance is: {bankAccount.Balance}");

                        }
                        else
                        {
                            Console.WriteLine("Transaction denied!");
                        }
                    }
                    else if (userInput == "2")
                    {

                        Console.WriteLine("How much would you like to withdraw");
                        string userAmount = Console.ReadLine();


                        Console.WriteLine("What is the reference?");
                        string userReference = Console.ReadLine();

                        Console.WriteLine("What is the description?");
                        string userDescription = Console.ReadLine();

                        TransactionResult transactionResult = bankAccount.MakeWithdrawal(decimal.Parse(userAmount), userReference, userDescription);

                        if (transactionResult == TransactionResult.Successful)
                        {
                            Console.WriteLine($"Transaction Successfu!!! Your new balance is {bankAccount.Balance:C}");

                        }
                        else if (transactionResult == TransactionResult.InsufficientFunds)
                        {
                            Console.WriteLine($"Insufficient Funds! Your Balance is: {bankAccount.Balance}");
                        }
                        else
                        {
                            Console.WriteLine("Transaction denied!");
                        }
                    }
                    else if (userInput == "3")
                    {
                        foreach (Transaction transaction in bankAccount.Transactions)
                        {
                            if (transaction.TransactionType == TransactionType.Deposit)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;

                            }
                            //Console.ForegroundColor defaultColour =

                            Console.WriteLine($"Transaction Date: {transaction.TransactionDateTime} Amount: {transaction.Amount} Reference: {transaction.Reference} Description: {transaction.Description} Transaction Type: {transaction.TransactionType}");
                        }

                    }
                }
                else
                {
                    Console.WriteLine($"Have a good day, {bankAccount.AccountHolder}");
                }

            }


            bankAccount.MakeDeposit(4.7m, "Stipend", "UWC");
            bankAccount.MakeDeposit((decimal)1000, "Salary", "Innovation Lab");


            Console.WriteLine("Hello, World!");
        }
    }
    
}
