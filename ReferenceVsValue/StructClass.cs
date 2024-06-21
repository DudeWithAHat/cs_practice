namespace StructClass
{
    public enum CharacterRole
    {
        Fighter = 1,
        Rogue = 2,
        Wizard = 3,
        Priest = 4
    }
  

    public struct CharacterStruct
    {
        public string name;
        public CharacterRole role;
        public int level;
        
        public CharacterStruct(string name, CharacterRole role, int level)
        {
          this.name = name;
          this.role = role;
          this.level = level;
        }

        public CharacterStruct()
        {
            this.name = "John Doe";
            this.role = CharacterRole.Fighter;
            this.level = 1;
        }

        public void DisplayInfo(){
          ConsoleColor currentColor = Console.ForegroundColor;
          
          Console.ForegroundColor = ConsoleColor.White;
          Console.Write("Character Name: ");
          Console.ForegroundColor = ConsoleColor.Cyan;
          Console.WriteLine($"{name}");

          Console.ForegroundColor = ConsoleColor.White;
          Console.Write("Character Class: ");
          Console.ForegroundColor = GetClassColor();
          Console.WriteLine($"{role.ToString()}");

          Console.ForegroundColor = ConsoleColor.White;
          Console.Write("Character Level: ");
          Console.ForegroundColor = ConsoleColor.Magenta;
          Console.WriteLine($"{level}");
          
          Console.ForegroundColor = currentColor;
        }

        private ConsoleColor GetClassColor() => this.role switch {
          CharacterRole.Fighter => ConsoleColor.DarkRed,
          CharacterRole.Rogue => ConsoleColor.Gray,
          CharacterRole.Wizard => ConsoleColor.DarkMagenta,
          CharacterRole.Priest => ConsoleColor.Yellow,
          _ => ConsoleColor.Red
       };
    }

    public class CharacterClass
    {
        public string name;
        public CharacterRole role;
        public int level;
        
        public CharacterClass(string name, CharacterRole role, int level)
        {
          this.name = name;
          this.role = role;
          this.level = level;
        }

        public CharacterClass()
        {
            this.name = "John Doe";
            this.role = CharacterRole.Fighter;
            this.level = 1;
        }

        public void DisplayInfo(){
          ConsoleColor currentColor = Console.ForegroundColor;
          
          Console.ForegroundColor = ConsoleColor.White;
          Console.Write("Character Name: ");
          Console.ForegroundColor = ConsoleColor.Cyan;
          Console.WriteLine($"{name}");

          Console.ForegroundColor = ConsoleColor.White;
          Console.Write("Character Class: ");
          Console.ForegroundColor = GetClassColor();
          Console.WriteLine($"{role.ToString()}");

          Console.ForegroundColor = ConsoleColor.White;
          Console.Write("Character Level: ");
          Console.ForegroundColor = ConsoleColor.Magenta;
          Console.WriteLine($"{level}");
          
          Console.ForegroundColor = currentColor;
        }

        private ConsoleColor GetClassColor() => this.role switch {
          CharacterRole.Fighter => ConsoleColor.DarkRed,
          CharacterRole.Rogue => ConsoleColor.Gray,
          CharacterRole.Wizard => ConsoleColor.DarkMagenta,
          CharacterRole.Priest => ConsoleColor.Yellow,
          _ => ConsoleColor.Red
       };
    }
}
