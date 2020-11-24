using System;

namespace _3_controleer_emailadres {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("---");
      Console.WriteLine("Opdracht 3: Controleer E-Mail adres");
      Console.WriteLine("211252 Jordy Slagter");
      Console.WriteLine("---\n\n");

      // Ask the user for input of the email address
      Console.WriteLine("Uw E-Mail adres:");
      // Convert the input string into an array of single characters
      char[] userInput = Console.ReadLine().ToCharArray();

      // If the input is less than 5 characters, it isn't an email (a@b.c)
      if (userInput.Length < 5) {
        NotCorrect();
        return;
      }

      // Check if '@' exists
      if (!Array.Exists(userInput, element => element == '@')) {
        NotCorrect();
        return;
      }

      // Check if '.' exists
      if (!Array.Exists(userInput, element => element == '.')) {
        NotCorrect();
        return;
      }

      // Check if the '.' that does exist has a higher index
      // than the '@'
      // No need to check for null values as they would've already
      // been caught
      int indexOfAt = Array.IndexOf(userInput, '@');
      // Last index, seeing as you can use multiple dots in an email
      int indexOfDot = Array.LastIndexOf(userInput, '.');
      if (indexOfDot < indexOfAt) {
        NotCorrect();
        return;
      }

      // If we've gotten to this point the email is correct
      Console.WriteLine("Dat is een correcte E-Mail!");
    }

    // Function to echo that the email isn't correct
    static void NotCorrect() {
      Console.WriteLine("Dat is GEEN correcte E-Mail!");
    }
  }
}
