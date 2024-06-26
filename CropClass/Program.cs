using Crops;

namespace CropClass{
  class Program{
    static void Main(){
      Crop carrot = new Crop("Carrot");

      while(carrot.stage < carrot.stageNames.Length){
        carrot.PrintStage();
        carrot.Grow();
      }

      string[] size = {
        "Tiny",
        "Small",
        "Medium",
        "Large",
        "Huge",
        "Gargantuan"
      };
      Crop mandrake = new Crop("Mandrake Root", stageNames: size);
      while(mandrake.stage < mandrake.stageNames.Length){
        mandrake.PrintStage();
        mandrake.Grow();
      }
    }
  }
} 
