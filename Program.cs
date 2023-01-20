using System;
using System.Text;
using System.Globalization;

namespace CSharpFundamental
{
  class Program
  {
    static void Main(string[] args)
    {
      /* Challenge 1 */
      string text = "this is a text";
      string newText = toTitleCase(text);
      Console.WriteLine(newText); // expect to see "This Is A Text"

      /* Challenge 2 */
      int[,] arrayA = { { 3, 5, 4, 6 }, { 3, 7, 8, 3 } };
      int[,] arrayB = { { 5, 1 }, { 8, 4 }, { 2, 9 }, { 2, 3 } };
      // int[,] result = matrixMultiply(arrayA, arrayB);
      // Console.WriteLine(result); //share your findings to Slack
    }
    static string toTitleCase(string input)
    {
      /* Write your code here */
      string[] splitedText = input.Split(' ');
      string upperText = "";
      foreach (string word in splitedText)
      {
        int firstChar = (byte)word[0];
        if (firstChar >= 97 && firstChar <= 122)
        {
          firstChar = firstChar - 32;
        }
        upperText += (char)firstChar + word[1..word.Length] + ' ';
      }
      return upperText;
    }
    // static int[,] matrixMultiply(int[,] array1, int[,] array2)
    // {
    //     /* Write your code here */
    // }
  }
}
