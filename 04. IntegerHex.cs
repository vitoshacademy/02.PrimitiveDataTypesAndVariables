/*Declare an integer variable and assign it with the value 254 in hexadecimal format. 
Use Windows Calculator to find its hexadecimal representation. */ 


using System;
class IntegerHex
{
    static void Main()
    {
        int theNum = 254;
        Console.WriteLine("{0} in hexadecimal format equals:\n", theNum);       // "\n" is new line
        Console.WriteLine("{0:X}\n\n", theNum);                                //This "{0:X} changes the result into hexadecimal.
    }
}
