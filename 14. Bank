/*A bank account has a holder name (first name, middle name and last name),
 * available amount of money (balance), bank name, IBAN, BIC code and 3 credit 
 * card numbers associated with the account. Declare the variables needed to keep
 * the information for a single bank account using the appropriate data types and descriptive names */
using System;
class Bank
{
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine(new string('-', 60));

        Console.WriteLine("Personal Information:");
        Console.WriteLine(); //empty row
        string firstName = "Valentino";
        string middleName = "Berbatov";
        string lastName = "Rossi";
        object fullName = firstName + " " + middleName + " " + lastName;
        Console.WriteLine(fullName);

        Console.WriteLine(new string('-', 60));

        Console.WriteLine("Account Information:");
        Console.WriteLine(); //empty row
        decimal balance = 10;
        string bankName = "Champions League Bank";
        string IBAN = "AA 22 2222 2222 2222 2222 11";
        string bicCode = "CHAM01";
        Console.WriteLine("{0} has a balance of {1} USD. \nHis IBAN is {2}.\nHis BIC code is {3}. \nThe name of the bank is {4}.", fullName, balance, IBAN, bicCode, bankName);

        Console.WriteLine(new string('-', 60));

        Console.WriteLine("Available Credit Cards:");
        Console.WriteLine(); //empty row
        long firstCreditCard = 123412341234;
        long secondCreditCard = 565656565656;
        long thirdCreditCard = 787878787878; // or Int64 thirdCreditCard = 5 466 160 175 050 358;
        Console.WriteLine("First credit card has {0} number.\nSecond credit card has {1} number.\nThird credit card has {2} number.", firstCreditCard, secondCreditCard, thirdCreditCard);
        Console.WriteLine(new string('-', 60));
        Console.WriteLine("\n\nThank you for your interest in our bank! Welcome again!\n\n");
        Console.WriteLine(new string('-', 60));

    }
}

