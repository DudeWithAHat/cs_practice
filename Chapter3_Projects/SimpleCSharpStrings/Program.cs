// See https://aka.ms/new-console-template for more information

using System;

namespace SimpleCSharpApp
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] numbers = {10,20,11,13,4,5,6,7,9};
      
      var subset = from i in numbers where i < 10 select i;
      
      foreach(var i in subset){
        Console.WriteLine($"{i}");
      }

      Console.WriteLine("Data Type: {0}",subset.GetType().Name);
    }
  }
}
