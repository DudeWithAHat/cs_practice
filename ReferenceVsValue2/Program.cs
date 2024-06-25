using StructClass;

namespace ReferenceVsValue
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Creating Characters. . .");
      CharacterClass exampleClass = new CharacterClass("Example [c]", 3);
      CharacterStruct exampleStruct = new CharacterStruct("Example [s]", 3);
      
      exampleClass.DisplayInfo();
      Console.WriteLine();
      exampleStruct.DisplayInfo();
      Console.WriteLine();
      
      Console.WriteLine("Running Mutation (Non-Ref)");
      Mutate(exampleClass);
      Mutate(exampleStruct);
      
      exampleClass.DisplayInfo();
      Console.WriteLine();
      exampleStruct.DisplayInfo();
      Console.WriteLine();

      Console.WriteLine("Resetting Classes to Defaults - Running Mutation (Ref)");
      exampleClass = new CharacterClass("Example [c]", 3);
      exampleStruct = new CharacterStruct("Example [s]", 3);
      Mutate(ref exampleClass);
      Mutate(ref exampleStruct);

      exampleClass.DisplayInfo();
      Console.WriteLine();
      exampleStruct.DisplayInfo();
      Console.WriteLine();
    }
    static void Mutate(CharacterStruct c){
      c.level++;
      c.name = c.name + " (Leveled Up) [s]";
      c = new CharacterStruct("New Character [s]", 1);
    }
    static void Mutate(ref CharacterStruct c){
      c.level++;
      c.name = c.name + " (Leveled Up) [sr]";
      c = new CharacterStruct("New Character [sr]", 1);
    }
    static void Mutate(CharacterClass c){
      c.level++;
      c.name = c.name + " (Leveled Up) [c]";
      c = new CharacterClass("New Character [c]", 1);
    }
    static void Mutate(ref CharacterClass c){
      c.level++;
      c.name = c.name + " (Leveled Up) [cr]";
      c = new CharacterClass("New Character [cr]", 1);
    }
  }
}
