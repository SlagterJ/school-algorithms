using System;
using System.Net.Mail;

namespace _3_controleer_emailadres {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("---");
      Console.WriteLine("Opdracht 3: Controleer E-Mail adres");
      Console.WriteLine("211252 Jordy Slagter");
      Console.WriteLine("---\n\n");

      // Ask the user for input of the email address
      Console.WriteLine("Uw E-Mail adres:");
      string userInput = Console.ReadLine();

      try {
        // Try to create a new mailaddress from the string
        new MailAddress(userInput);
      } catch (FormatException) {
        // If it fails write that it's incorrect
        Console.WriteLine("Dat is NIET een correcte E-Mail.");
        return;
      }

      // If we've gotten to this point the email is correct
      Console.WriteLine("Dat is een correcte E-Mail.");
    }
  }
}
