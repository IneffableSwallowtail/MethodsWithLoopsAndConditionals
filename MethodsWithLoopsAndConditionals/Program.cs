// See https://aka.ms/new-console-template for more information
using MethodsWithLoopsAndConditionals;
using System.Security.Cryptography.X509Certificates;
using static MethodsWithLoopsAndConditionals.Class1;

Console.WriteLine("Type \"count backwards\" and the console will print out all of the numbers from 1000 to -1000.");
bool cont = true;
do
{
    if (Console.ReadLine().ToLower() == "count backwards")
    {
        cont = false;
    }
    else
    {
        cont = true;
        Console.WriteLine("Program will not continue until you type \"count backwards\"");
    }
} while (cont == true);
Print1000();

Console.WriteLine("\nType \"count threes\" and the program will count by threes to 999.");
cont = true;
do
{
    if (Console.ReadLine().ToLower() == "count threes")
    {
        cont = false;
    }
    else
    {
        cont = true;
        Console.WriteLine("Program will not continue until you type \"count threes\".");
    }
} while (cont == true);
PrintThrees();

/*Past this point, I wanted to prevent the program from breaking if you inputed the wrong value type,
but it was too time consuming to figure out for now.
*/

Console.Write("\nInput two numbers to see if they are equal.\n First number: ");
int isEqual1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Second number: ");
int isEqual2 = Convert.ToInt32(Console.ReadLine());
AreEqual(isEqual1, isEqual2);

Console.WriteLine("\n Input a number to see if it is even.");
IsEven(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("\nInput a number to see if it is positive or negative.");
IsPositive(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("\nPlease input your age");
CanVote(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("\nPlease input an integer to see if it's within the range -10 to 10.");
Range10(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("\nPlease input an integer to see its multiplication table.");
MultiplicationTable(Convert.ToInt32(Console.ReadLine()));