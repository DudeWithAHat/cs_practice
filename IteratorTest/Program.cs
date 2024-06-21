using static IteratorClass.Iterator;

namespace SimpleCsharpIterator
{
  class Program{
    static void Main(){
      Console.WriteLine("Iterating from 1 to 10. Press Enter to iterate.");
      Console.WriteLine("Using ref var:");
      for(int i = 0; i <= 10; iterate(ref i)){
        Console.WriteLine("i = {0}", i);
        Console.ReadLine();
      }

      Console.WriteLine("Using var:");
      for(int i = 0; i <= 10; iterate(i)){
        Console.WriteLine("i = {0}", i);
        Console.ReadLine();
      }
    }
  }
}
