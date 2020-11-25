using System;

namespace _8_priemgetallen {
  class Program {
    static void Main(string[] args) {
      for (int i = 0; i <= 100; i++) {
        int counter = 0;

        for (int j = 2; j <= i / 2; j++) {
          if (i % j == 0) {
            counter++;
            break;
          }
        }

        if (counter == 0 && i != 1) {
          Console.WriteLine(i);
        }
      }
    }
  }
}
