using System;

namespace _4_bubblesort {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Uw string:");
      char[] userInput = Console.ReadLine().ToCharArray();
      // Use a temp char for switching
      char temp;

      // For every item
      for (int j = 0; j <= userInput.Length - 2; j++) {
        for (int i = 0; i <= userInput.Length - 2; i++) {
          if (userInput[i] > userInput[i + 1]) {
            // Switch the items if the value is higher than the next
            temp = userInput[i + 1];
            userInput[i + 1] = userInput[i];
            userInput[i] = temp;
          }
        }
      }

      // Print the result
      foreach (char c in userInput) {
        Console.Write(c);
      }
    }
  }
}
