using System;
using System.Collections.Generic;

namespace _19_controleer_string_invoer {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Uw string:");
      string userInput = Console.ReadLine();

      string[] splitUserInput = userInput.Split(' ');

      List<string> bannedWords = new List<string>() {
        "APPEND",
        "INSERT",
        "DELETE",
        "DROP"
      };

      foreach (string word in splitUserInput) {
        if (bannedWords.Contains(word.ToUpper())) {
          Console.WriteLine("Er zit een verbannen woord in deze string.");
          return;
        }
      }

      Console.WriteLine("Er zitten geen verbannen woorden in deze string.");
    }
  }
}
