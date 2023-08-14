using System;
using System.Text;

namespace ChallangeQuestion
{
    class Program
    {
        public static void NoBlankDigits()
        {
            Console.Clear();
            Console.WriteLine("Plese enter two equal lenght numbers, and the lenght of those numbers.\nThere will be 5 different occurences you will need to iput numbers for.");
            Console.WriteLine("Enter First Number");
            int a;
            bool inputSuccessA = int.TryParse(Console.ReadLine(), out a);
            if (!inputSuccessA)
            {
                a = 1; // Set a default value of 1 when input is not a valid integer
                Console.WriteLine("Invalid input for Number 1. Using 1 as a placeholder.");
            }
            Console.Clear();
            Console.WriteLine("Plese enter two equal lenght numbers, and the lenght of those numbers.\nThere will be 5 different occurences you will need to iput numbers for.");
            Console.WriteLine($"Number 1: {a}");
            Console.WriteLine("Enter Second Number");
            int b;
            bool inputSuccessB = int.TryParse(Console.ReadLine(), out b);
            if (!inputSuccessB)
            {
                b = 1; // Set a default value of 1 when input is not a valid integer
                Console.WriteLine("Invalid input for Number 2. Using 1 as a placeholder.");
            }
            Console.Clear();
            Console.WriteLine("Plese enter two equal lenght numbers, and the lenght of those numbers.\nThere will be 5 different occurences you will need to iput numbers for.");
            Console.WriteLine($"Number 1: {a}");
            Console.WriteLine($"Number 2: {b}");
            Console.WriteLine("Enter Lenght Of Numbers");
            int c;
            bool inputSuccessC = int.TryParse(Console.ReadLine(), out c);
            if (!inputSuccessC)
            {
                c = 1; // Set a default value of 1 when input is not a valid integer
                Console.WriteLine("Invalid input for length. Using 1 as a placeholder.");
            }

            int numDigits = Math.Max(a.ToString().Length, Math.Max(b.ToString().Length, c.ToString().Length));

            if (numDigits > 10)
            {
                Console.WriteLine("Max length is 10, please be mindful!");
            }

            Console.WriteLine(SharesDigit(a, b, numDigits));
            Console.WriteLine();
            Console.WriteLine("Press any key to continue to next set of numbers.......");
            Console.ReadKey();
        }



        public static bool SharesDigit(int a, int b, int c)
        {
            string numA = a.ToString();
            string numB = b.ToString();

            //numA.ToArray();
            //numB.ToArray();

            int capture = 0;
            int capture2 = 0;

            for (int i = 0; i < numB.Length; i++)
                capture++;

            for (int i = 0; i < numA.Length; i++)
                capture2++;

            if (capture == c && capture2 == c)
            {
                int hasSame = 0;
                for (int i = 0;i<numB.Length;i++)
                {
                    if (numB[i] == numA[i])
                        hasSame++;
                    else
                        break;
                }
                if (hasSame != 0)
                    return true;
                else return false;
            }

            else
                return false;
        }

        public static void Main(string[] args)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    NoBlankDigits();
            //}
            Console.WriteLine(SharesDigit(456, 123, 3));     // should return false, because no two numbers are the same in both ints.
            Console.WriteLine(SharesDigit(456, 400, 3));     // should return true, because there is a 4 in both numbers.
            Console.WriteLine(SharesDigit(12345, 67890, 5)); // should return false because no two numbers are the same in both ints.
            Console.WriteLine(SharesDigit(12345, 12345, 5)); // should return true because the two ints share multiple digits.
            Console.WriteLine(SharesDigit(123, 423, 1));     //should return false, because the last argument should be how many digits to check.
            Console.WriteLine(SharesDigit(1, 2, 1));         //
            Console.WriteLine(SharesDigit(2, 1, 2));         //
            Console.WriteLine(SharesDigit(22, 12, 2));       //
        }
    }
}



/*
 * Try this one Jordan. If you get this one done before tonight, let me know and I'll send you another.

Write a function named SharesDigit that takes three ints as arguments. 
Your first two arguments should represent two numbers that will be compared to see if any of their digits are the same number. 
Your third argument will be the number of digits in both numbers (they should be the same length for this exercise).

Your program should use a combination of your knowledge of arrays, the remainder operator, integer division, nested loops, and if statements to determine if any two numbers exist in both integers. 
Your program should return true if the numbers share a digit, and false if they do not.
Example:

    SharesDigit(456, 123, 3); should return false, because no two numbers are the same in both ints.
    SharesDigit(456, 400, 3); should return true, because there is a 4 in both numbers.
    SharesDigit(12345, 67890, 5); should return false because no two numbers are the same in both ints.
    SharesDigit(12345, 12345, 5); should return true because the two ints share multiple digits.
    SharesDigit(123, 423, 1); should return false, because the last argument should be how many digits to check. If your function uses the last argument correctly, it will only check as many digits of the number of the last argument starting from the leftmost digit. Therefore, this function call should only compare "1" and "4".
*/