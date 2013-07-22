/*A marketing firm wants to keep record of its employees. 
Each record would have the following characteristics – 
                                                         first name, 
                                                         family name, 
                                                         age, 
                                                         gender (m or f), 
                                                         ID number, 
                                                         unique employee number (27560000 to 27569999). 
Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.
*/
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("The Great Big Bad Company");
        Console.WriteLine("Please, enter your first name below:");
        string fName = String.Concat(Console.ReadLine());
        Console.WriteLine("Please, enter your family name:");
        string lName = String.Concat(Console.ReadLine());
        Console.WriteLine("Enter your age:");
        int ages = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your gender (male or female):");
        string gender = String.Concat(Console.ReadLine());
        Console.WriteLine("Enter your ID number:");
        int idNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your unique employee number:");
        int emplNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Employee by name {0} {1} is {2} years old and its gender is {3}. His ID number is {4} and unique employee number is {5}", fName, lName, ages, gender, idNum, emplNum);

    }
}
