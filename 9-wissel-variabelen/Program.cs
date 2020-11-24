using System;

namespace _9_wissel_variabelen {
  class Program {
    static void Main(string[] args) {
      int a = 10;
      int b = 20;
      int c;

      Console.WriteLine($"A is {a}");
      Console.WriteLine($"B is {b}\n");

      c = a;
      a = b;
      b = c;

      Console.WriteLine($"A is {a}");
      Console.WriteLine($"B is {b}");
    }
  }
}
