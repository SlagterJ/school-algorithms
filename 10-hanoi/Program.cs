using System;
using _10_hanoi.GameFunctions;

namespace _10_hanoi {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Welkom bij torens van Hanoi");
      Game game = new Game();
      game.Start();
    }
  }
}
