/* Which of the following values can be assigned to a variable 
of type float and which to a variable of type double: 
34.567839023, 12.345, 8923.1234857, 3456.091? */

using System;
class FloatAndDouble
{
    static void Main()
    {
        double n1 = 34.567839023d;
        float n2 = 12.345f;
        double n3 = 8923.1234857f;
        float n4 = 3456.091f;
        Console.Write("This is the way the numbers are assigned:\n {0} is double\n {1} is float\n {2} is double\n {3} is float\n",
                        n1,n2,n3,n4);
    }
}

