using System;

namespace _18_namengenerator {
  class Program {
    static void Main(string[] args) {
      // Define the array of names to be used in the
      // bag to pull from
      string[] names = {
        "JoRdY",
        "joNas",
        "abDI",
        "lUuk",
        "wESLey"
      };

      // Define new random for use later
      Random r = new Random();

      // Pick a random name
      string name = names[r.Next(0, names.Length)];

      // Set the entire name to lower case
      name = name.ToLower();

      // Convert it to a char array so that we can capitalise the
      // first letter
      char[] nameInChar = name.ToCharArray();

      // Capitalise the first letter
      nameInChar[0] = char.ToUpper(nameInChar[0]);

      // Recreate the name string with the first letter capitalised
      name = new string(nameInChar);

      // Write the name to the console
      Console.WriteLine(name);
    }
  }
}
