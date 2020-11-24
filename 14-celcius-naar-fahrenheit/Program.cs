using System;

namespace _14_celcius_naar_fahrenheit {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("---");
      Console.WriteLine("Opdracht 14: Celcius naar fahrenheit");
      Console.WriteLine("211252 Jordy Slagter");
      Console.WriteLine("---\n\n");

      Console.WriteLine("Uw grade in celsius:");
      string userInput = Console.ReadLine();
      double celsius;
      bool parseAttempt = Double.TryParse(userInput, out celsius);

      if (!parseAttempt) {
        Console.WriteLine("Dat is niet een nummer!");
        return;
      }
      double fahrenheit = (celsius * 9) / 5 + 32;

      Console.WriteLine($"Fahrenheit: {fahrenheit}");
    }
  }
}
