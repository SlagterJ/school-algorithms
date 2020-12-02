using System;

namespace _7_fibonacci {
  class Program {
    static void Main(string[] args) {
      int a = 0;
      int b = 1;

      int i = 0;

      while (i < 10) {
        int temp = a;
        a = b;
        b = temp + b;

        Console.WriteLine(b);
        i++;
      }
    }
  }
}
