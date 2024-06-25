namespace StructClass
{

    public class CharacterClass
    {
        public string name;
        public int level;
        
        public CharacterClass(string name, int level)
        {
          this.name = name;
          this.level = level;
        }

        public void DisplayInfo(){
          ConsoleColor currColor = Console.ForegroundColor;
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.WriteLine($"Name: {name}");
          Console.WriteLine($"Level: {level}");
          Console.ForegroundColor = currColor;
        }

    }
    
    public struct CharacterStruct
    {
        public string name;
        public int level;
        
        public CharacterStruct(string name, int level)
        {
          this.name = name;
          this.level = level;
        }

        public void DisplayInfo(){
          ConsoleColor currColor = Console.ForegroundColor;
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.WriteLine($"Name: {name}");
          Console.WriteLine($"Level: {level}");
          Console.ForegroundColor = currColor;
        }

    }
}
