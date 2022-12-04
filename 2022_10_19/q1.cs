using System;

class POO {

  public static void Main() {
    Console.WriteLine("Digite o primeiro número:");
    double num1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número:");
    double num2 = double.Parse(Console.ReadLine());
    
    double m = Maior(num1, num2);
    Console.WriteLine($"O maior é {m}.");
  }

  public static double Maior(double x, double y) {
    double maior;
    
    maior = x;
    if (y > maior)
      maior = y;
    
    return maior;
  }
  
}