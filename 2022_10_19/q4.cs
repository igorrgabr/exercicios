using System;

class POO {

  public static void Main() {
    Console.WriteLine("Digite dois números:");
    string[] nums = Console.ReadLine().Split();
    int n1 = int.Parse(nums[0]);
    int n2 = int.Parse(nums[1]);
    int mmc = MMC(n1, n2);
    Console.WriteLine($"O MMC de {n1} e {n2} é {mmc}.");
  }

  public static int MMC(int x, int y) {
    int resto, a = x, b = y;
    do {
      resto = a % b;
      a = b;
      b = resto;
    } while (resto != 0);
    return (x * y) / a;
  }
  
}