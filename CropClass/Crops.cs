namespace Crops
{
    public class Crop
    {
        private static readonly string[] defaultStages = { 
            "Germinating",
            "Sprouting",
            "Vegetating",
            "Budding",
            "Blooming",
            "Ripe"};
        public string cropName;
        public int stage;
        public string[] stageNames;


        public Crop(string cropName = "Weed", int stage = 0, string[]? stageNames = null){
          this.cropName = cropName;
          this.stage = stage;
          this.stageNames = stageNames ?? defaultStages;
        }

        public void PrintStage()
        {
            ConsoleColor currColor = Console.ForegroundColor;
            if (stage == stageNames.Length - 1) Console.ForegroundColor = ConsoleColor.Green;
            else Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"This {cropName} is {stageNames[stage]}.");
            Console.ForegroundColor = currColor;
        }

        public void Grow()
        {
            stage++;
        }
    }
}
