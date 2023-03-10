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
      int[,] result = matrixMultiply(arrayA, arrayB);
      Console.WriteLine(result); //share your findings to Slack
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
    static int[,] matrixMultiply(int[,] array1, int[,] array2)
    {
      /* Write your code here */
      if (array1.GetLength(1) != (array2.GetLength(0)))
      {
        throw new ArgumentException("These 2 arrays cannot multiply with each other");
      }
      int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
      for (int i = 0; i < array1.GetLength(0); i++)
      {
        for (int n = 0; n < array2.GetLength(1); n++)
        {
          var loopResult = 0;
          for (int j = 0; j < array1.GetLength(1); j++)
          {
            loopResult += array1[i, j] * array2[j, n];
          }
          result[i, n] = loopResult;
          // Console.WriteLine(result[i, n]);
        }
      }
      return result;
    }
  }
}
