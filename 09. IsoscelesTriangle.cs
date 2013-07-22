/*Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
Use Windows Character Map to find the Unicode code of the © symbol. 
Note: the © symbol may be displayed incorrectly. */
//In my  case it is displayed incorrectly!
using System;
class Triangle
{
    static void Main()
    {
        char symbol = '\u00A9';
        Console.WriteLine("Look at the beautiful triangle below - created of 9 special symbols:\n\n\n\n");
        Console.WriteLine("\n       {0}\n      {0}{0}{0}\n     {0}{0}{0}{0}{0}\n\n", symbol);
    }
}
