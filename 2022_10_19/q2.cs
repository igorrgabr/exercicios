using System;

class POO {

  public static void Main() {
    Console.WriteLine("Escreva três números:");
    string[] nums = Console.ReadLine().Split();
    int n1 = int.Parse(nums[0]);
    int n2 = int.Parse(nums[1]);
    int n3 = int.Parse(nums[2]);
    Ordenar(ref n1, ref n2, ref n3);
    int[] ord = new int[3] {n1, n2, n3};
    Console.WriteLine("Em ordem:");
    Console.WriteLine(String.Join(" ", ord));
  }

  public static void Ordenar(ref int x, ref int y, ref int z) {
    int p = x, s = y, t = z;
    if (y < p && y < t) {
      x = y;
      y = p;
      if (z < p) {
        y = z;
        z = p;
      }
    }
    else if (z < p && z < s) {
      x = z;
      z = p;
      if (z < s) {
        y = z;
        z = s;
      }
    }
    else if (x < s && x < t) {
      if (t < y) {
        y = z;
        z = s;
      }
    }
  }
  
}