/*Declare a character variable and assign it with the symbol that has Unicode code 72.
Hint: first use the Windows Calculator to find the hexadecimal representation of 72.
72 in hexadecimal format is 48*/

using System;
class Program
{
    static void Main()
    {
        char Unicode = '\u0048';
        Console.WriteLine("Symbol Unicode code 72 (hex 48) is {0} ", Unicode);
    }
}
