using System;
using System.Collections.Generic;

namespace _10_hanoi.Classes {
  public class Stick {
    public List<Disk> disks { get; set; }

    public Stick() {
      this.disks = new List<Disk>();
    }

    public Stick(List<Disk> disks) {
      this.disks = disks;
    }

    public void Spit() {
      Console.WriteLine("\n---");
      foreach (Disk disk in this.disks) {
        Console.WriteLine(disk.width);
      }
      Console.WriteLine("---\n");
    }
  }
}
