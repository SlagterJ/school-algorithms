using System;

namespace _5_controleer_telefoonnummer {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Uw telefoonnummer:");
      string userInput = Console.ReadLine();

      // Not correct if it doesn't start with +316 or +32
      if (!userInput.StartsWith("+316") && !userInput.StartsWith("+32")) {
        Console.WriteLine("StartsWith test negative");
        Console.WriteLine("Dat is niet een correct telefoonnummer!");
        return;
      }

      // Not correct if it's shorter than 10 or longer than 12
      if (userInput.Length < 10 || userInput.Length > 12) {
        Console.WriteLine("Length test negative");
        Console.WriteLine("Dat is niet een correct telefoonnummer!");
        return;
      }

      char[] userInputInChar = userInput.ToCharArray();

      foreach(char singleChar in userInputInChar) {
        // Convert to string to be used in TryParse
        string c = singleChar.ToString();

        // If the character is +, ignore the number test
        if (c == "+") { continue; }
        // Test if the character is a number
        if (!Int32.TryParse(c, out int num)) {
          Console.WriteLine("Number test negative");
          Console.WriteLine("Dat is niet een correct telefoonnummer!");
          return;
        }
      }

      Console.WriteLine("Dat is een correct telefoonnummer!");
    }
  }
}
