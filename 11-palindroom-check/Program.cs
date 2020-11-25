using System;

namespace _11_palindroom_check {
  class Program {
    static void Main(string[] args) {
      // Ask the user for their string
      Console.WriteLine("Uw string:");
      string userInput = Console.ReadLine();

      // Reverse the string
      char[] userInputInChar = userInput.ToCharArray();
      Array.Reverse(userInputInChar);
      string userInputReversed = new string(userInputInChar);

      // If it's the same reversed, it's paldindrome
      if (userInput == userInputReversed) {
        Console.WriteLine("De string is palindroom!");
        return;
      }

      // If we've gotten to this point it's not palindrome
      Console.WriteLine("De string is niet palindroom!");
    }
  }
}
