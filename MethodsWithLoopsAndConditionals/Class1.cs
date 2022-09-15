using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    public static class Class1
    {
        public static void Print1000()
        {
            for (int i = 1000; i > -1000; i--)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine(-1000);
        }

        public static void PrintThrees()
        {
            for (int i = 3; i < 999; i = i + 3)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine(999);
        }

        public static void AreEqual(int x, int y)
        {
            if (x == y) Console.WriteLine("The numbers are equal.");
            else Console.WriteLine("The numbers are not equal.");
        }

        public static void IsEven(int x)
        {
            if (x % 2 == 0) Console.WriteLine("The number is even.");
            else Console.WriteLine("The number is odd.");
        }

        public static void IsPositive(int x)
        {
            if (x == 0) Console.WriteLine("The number is neither negative nor positive.");
            else if (x == Math.Abs(x)) Console.WriteLine("The number is positive.");
            else Console.WriteLine("The number is negative.");
        }

        public static void CanVote(int x)
        {
            if (x >= 18)
            {
                Console.WriteLine("You are old enough to vote!");
            }
            else if (x <= 0)
            {
                Console.WriteLine("You have not yet been born.");
            }
            else
            {
                Console.WriteLine("You can't vote yet.");
            }
        }

        public static void Range10(int x)
        {
            if (x <= 10 && x >= -10)
            {
                Console.WriteLine("Number is within range.");
            }
            else
            {
                Console.WriteLine("Number is out of range.");
            }
        }

        public static void MultiplicationTable(int x)
        {
            for (int i = 1; i < 12; i++)
            {
                Console.Write($"{x * i}, ");
            }
            Console.WriteLine(x * 12);
        }
    }
}
