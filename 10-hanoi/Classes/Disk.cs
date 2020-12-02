using System;

namespace _10_hanoi.Classes {
  public class Disk {
    public int width { get; protected set; }

    public Disk(int width) {
      this.width = width;
    }
  }
}
