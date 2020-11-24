using System;

namespace _16_string_getal {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("---");
      Console.WriteLine("Opdracht 16: String getal");
      Console.WriteLine("211252 Jordy Slagter");
      Console.WriteLine("--\n\n");

      // Define the string versions of the numbers
      string aString = "23";
      string bString = "34";

      // Predefine the int versions of the numbers
      int a;
      int b;

      // Try to convert the strings to numbers
      bool aSuccess = Int32.TryParse(aString, out a);
      bool bSuccess = Int32.TryParse(bString, out b);

      if (!aSuccess || !bSuccess) {
        // If the strings couldn't be converted spit this out and stop
        Console.WriteLine("De input waren geen nummers.");
        return;
      }

      // Add the numbers
      int result = a + b;

      // Print the result
      Console.WriteLine($"{result}!");
    }
  }
}
