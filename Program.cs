using System;
using System.Globalization;

namespace CSharpFundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Challenge 1 */
            string text = "this is a text";
            toTitleCase(text);
            Console.WriteLine(text); // expect to see "This Is A Text"

            /* Challenge 2 */
            int[,] arrayA = { { 3, 5, 4 }, { 3, 7, 8 } };
            int[,] arrayB = { { 5, 1 }, { 8, 4 }, { 2, 9 }, { 2, 3 } };
            int[,] result = matrixMultiply(arrayA, arrayB);
            Console.WriteLine(result); //share your findings to Slack
        }
        static int[,] toTitleCase(string input)
        {
            /* Write your code here */
        }
        static void matrixMultiply(int[,] array1, int[,] array2)
        {
            /* Write your code here */
        }
    }
}