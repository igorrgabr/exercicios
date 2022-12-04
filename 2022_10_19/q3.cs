using System;

class POO {

  public static void Main() {
    Console.WriteLine("Digite um número:");
    double num = double.Parse(Console.ReadLine());
    int i, f;
    Intervalo(num, out i, out f);
    Console.WriteLine($"O intervalo é [{i}, {f}].");
  }

  public static void Intervalo(double x, out int inicio, out int fim) {
    inicio = (int) x;
    fim = inicio + 1;
  }
  
}