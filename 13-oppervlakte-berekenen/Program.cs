using System;

namespace _13_oppervlakte_berekenen {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("De diameter:");
      string userInput = Console.ReadLine();

      double diameter;
      bool parseSucceed = Double.TryParse(userInput, out diameter);

      if (!parseSucceed) {
        Console.WriteLine("That isn't a number!");
        return;
      }

      double radius = diameter / 2;

      double surface = Math.PI * (radius * radius);
      double circumference = Math.PI * diameter;

      Console.WriteLine($"De oppervlakte is {surface}");
      Console.WriteLine($"De omtrek is {circumference}");
    }
  }
}
