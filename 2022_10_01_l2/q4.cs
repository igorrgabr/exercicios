using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite a base e a altura do retângulo:");
    int b = int.Parse(Console.ReadLine());
    int h = int.Parse(Console.ReadLine());
    double area = b * h;
    double perimetro = (b * 2) + (h * 2);
    double diagonal = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));
    Console.WriteLine($"Área = {area:0.00} - Perímetro: {perimetro:0.00} - Diagonal: {diagonal:0.00}");
  }
}