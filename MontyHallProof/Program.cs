
namespace MontyHallProof;

public static class Program
{

   private static readonly Random Rnd = new();

   private static List<bool> GetDoors()
   {
      return new List<bool>{ true, false, false }.OrderBy(x => Rnd.Next()).ToList();
   }

   private static int PickDoorAtRandom(List<bool> doors)
   {
      return Rnd.Next(0, 100) < 50 ? PickDoorAlwaysSwitch(doors) : PickDoorAlwaysStay(doors);
   }

   private static int PickDoorAlwaysStay(List<bool> doors)
   {
      return Rnd.Next(doors.Count);
   }

   private static int PickDoorAlwaysSwitch(List<bool> doors)
   {
      var index = Rnd.Next(doors.Count);
      return doors[index] ?
         doors.Select((d, i) => new { d, i }).First(d => d.i != index ).i :
         doors.Select((d, i) => new { d, i }).First(d => d.i != index && d.d ).i;
   }

   private static double GetStatistic(int runTimes, Func<List<bool>, int> pick)
   {
      var correctCount = 0;
      for (var i = 0; i < runTimes; i++)
      {
         var doors = GetDoors();
         if (doors[pick(doors)])
         {
            correctCount++;
         }
      }
      return Math.Round(correctCount / (double)runTimes, 2);
   }

   public static void Main(string[] args)
   {
      Console.WriteLine("Staying: " + GetStatistic(100000, PickDoorAlwaysStay) * 100 + "%");
      Console.WriteLine("Switching: " + GetStatistic(100000, PickDoorAlwaysSwitch)* 100 + "%");
      Console.WriteLine("Randomly staying and switching: " + GetStatistic(100000, PickDoorAtRandom)* 100 + "%");
   }
}