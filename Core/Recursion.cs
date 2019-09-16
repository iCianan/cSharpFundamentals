using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
  public class Recursion
  {
    public string TakeShower()
    {
      return "Showering";
    }
    public string CookFood()
    {
      Random random = new Random();
      string[] items = {"Oatmeal", "Eggs","Protein Shake" };
      return items[random.Next(0, items.Length)];
    }
    public string EatBreakfast()
    {
      var meal = CookFood();
      return $"Eating {meal}";
    }
    public void WakeUp()
    {
      TakeShower();
      EatBreakfast();
      Console.WriteLine("Ok ready to go to work");
    }

  }
}
