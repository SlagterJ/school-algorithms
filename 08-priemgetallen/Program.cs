using System;

namespace _8_priemgetallen {
  class Program {
    static void Main(string[] args) {
      // Loop 100 times
      for (int i = 0; i <= 100; i++) {
        // Set a counter to use to detect prime numbers
        int counter = 0;

        // Only let numbers through that have potential
        for (int j = 2; j <= i / 2; j++) {
          if (i % j == 0) {
            counter++;
            break;
          }
        }

        // Print out prime numbers
        if (counter == 0 && i != 1) {
          Console.WriteLine(i);
        }
      }
    }
  }
}
