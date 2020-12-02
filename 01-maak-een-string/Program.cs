using System;

namespace _1_maak_een_string {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("---");
      Console.WriteLine("Opdracht 1: Maak een string");
      Console.WriteLine("211252 Jordy Slagter");
      Console.WriteLine("---\n\n");

      // Count from char Z to char A
      for (char i = 'Z'; i >= 'A'; i--) {
        Console.WriteLine(i);
      }
    }
  }
}
