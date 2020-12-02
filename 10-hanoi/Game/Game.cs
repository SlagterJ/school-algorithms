using System;
using System.Collections.Generic;
using _10_hanoi.Classes;

namespace _10_hanoi.GameFunctions {
  public class Game {
    public List<Stick> sticks { get; protected set; }

    public Game() {
      this.sticks = new List<Stick>();

      List<Disk> defaultDisks = new List<Disk>() {
        new Disk(1),
        new Disk(2),
        new Disk(3)
      };

      Stick stick1 = new Stick(defaultDisks);
      this.sticks.Add(stick1);
      Stick stick2 = new Stick();
      this.sticks.Add(stick2);
      Stick stick3 = new Stick();
      this.sticks.Add(stick3);
    }

    public int AskForInput(string question) {
      Console.WriteLine(question);
      int output;
      bool didParse = Int32.TryParse(
        Console.ReadLine(),
        out output
      );

      if (!didParse) {
        Console.WriteLine("U moet een nummer invullen");
        this.AskForInput(question);
      }

      if (output < 1 || output > 3) {
        Console.WriteLine("U moet een nummer kiezen tussen 1 en 3");
        this.AskForInput(question);
      }

      return output;
    }

    public void Start() {
      this.Loop();
    }

    public void Loop() {
      // First, spit out the sticks
      Console.WriteLine("Sticks:");
      foreach (Stick stick in this.sticks) {
        stick.Spit();
      }

      int stickToPickFrom = this.AskForInput("Kies de stok om van te pakken:");
      stickToPickFrom--;

      Disk disk = this.sticks[stickToPickFrom].disks[0];
      this.sticks[stickToPickFrom].disks.RemoveAt(0);

      Console.WriteLine($"U heeft disk {disk.width} vast");

      int stickToMoveTo = this.AskForInput(
          "Kies de stok om de disk naar te verplaatsen:"
      );
      stickToMoveTo--;

      this.sticks[stickToMoveTo].disks.Insert(0, disk);

      bool wonTheGame = this.CheckForWin();

      if (!wonTheGame) {
        this.Loop();
        return;
      }

      this.End();
    }

    public bool CheckForWin() {
      int capacity = this.sticks[2].disks.Capacity;
      List<Disk> disks = this.sticks[2].disks;

      if (this.sticks[2].disks.Capacity < 3) {
        return false;
      }

      for (int i = 0; i < this.sticks[2].disks.Capacity; i++) {
        if (disks[i].width > disks[i + 1].width) {
          return false;
        }
      }

      return true;
    }

    public void End() {
      Console.WriteLine("Gewonnen!");
    }
  }
}
