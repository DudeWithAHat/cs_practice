using System;

namespace SimpleCSharpApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello! This is a simple Division Program.");
      
      bool finished = false;
      while(!finished)
      { 
        Console.Write("Please enter the numerator: ");
        if(!int.TryParse(Console.ReadLine(), out int firstNumber)) 
        {
          WriteColor("\aInvalid Entry. Please enter an Integer Value.", ConsoleColor.Red);
          return;
        }

        Console.Write("Please ender the denominator: ");
        if(!int.TryParse(Console.ReadLine(), out int secondNumber))
        {
          WriteColor("\aInvalid Entry. Please enter an Integer Value.", ConsoleColor.Red);
          return;
        }

        int quotient = firstNumber / secondNumber;
        int remainder = firstNumber % secondNumber;
        
        string equation = $"{firstNumber} / {secondNumber} = ";
        string resultQuotient = $"{quotient}";
        string resultRemainder = $"R{remainder}";
        WriteColor(equation, ConsoleColor.Yellow);
        WriteColor(resultQuotient, ConsoleColor.Green);
        WriteColor(resultRemainder, ConsoleColor.Blue);
        finished = true;
      }
    }
    static void WriteColor(string text, ConsoleColor color)
    {
      ConsoleColor currColor = Console.ForegroundColor;
      Console.ForegroundColor = color;
      Console.Write(text);
      Console.ForegroundColor = currColor;
    }
  }
}
