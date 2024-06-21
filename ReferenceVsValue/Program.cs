using StructClass;

namespace ReferenceVsValue
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("\n\nGenerating a character. . .");
      Console.WriteLine("\nCharacter Information:");
      CharacterClass leopold = new CharacterClass("Leopold Von Huffgram", CharacterRole.Fighter, 17);
      leopold.DisplayInfo();
      
      Console.WriteLine("\n\nGenerating a simulacrum. . .");
      Console.WriteLine("\nSimulacrum Information:");
      CharacterClass simulacrum = leopold;
      simulacrum.DisplayInfo();

      Console.WriteLine("\n\nUpdating Simulacrum Information. . .");
      simulacrum.name = "Simulacrum of Leopold Von Huffgram";
      simulacrum.level = -1;
        
      Console.WriteLine("\nCharacter Information:");
      leopold.DisplayInfo();
      Console.WriteLine("\nSimulacrum Information:");
      simulacrum.DisplayInfo();

      Console.WriteLine("\n\nMutating Character. . .");
      LevelUp(ref leopold);
      
      Console.WriteLine("\nCharacter Information:");
      leopold.DisplayInfo();
      Console.WriteLine("\nSimulacrum Information:");
      simulacrum.DisplayInfo();
    }

    public static void LevelUp(ref CharacterClass c)
    {
      c.level++;
      c = new CharacterClass("Mutated Leopold",CharacterRole.Rogue,-404);
    }
  }
}
