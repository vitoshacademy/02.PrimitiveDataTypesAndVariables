/*
Write a program that safely compares floating-point numbers with precision of 0.000001. 
Examples:(5.3 ; 6.01) IS false;  
          (5.00000001; 5.00000003) IS true;
*/

using System;

class FloatingPointCompare
{
    static void Main()
    {
        Console.WriteLine("Hello!\nPlease, enter a number to be compared");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter a second number to be compared with the first one");
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        decimal x = firstNumber - secondNumber;
        bool v = Math.Abs(x) < 0.000001m;
        Console.WriteLine("If the numbers are equal with precision of 0.000001 you will see TRUE, if they are not you will see FALSE on the next line\n\n\n{0}\n\n\n", v);
        Console.WriteLine("Thank you! Have a nice day!\n\n\n");
    }
}
