using System;

class Circulo {

  private double raio;

  public void SetRaio(double v) {
    if (v > 0)
      raio = v;
  }
  public double GetRaio() {
    return raio;
  }

  public double CalcArea() {
    return 3.14 * (raio * raio);
  }
  public double CalcCircunferencia() {
    return 2 * 3.14 * raio;
  }
  
}

class UI {

  public static void Main() {

    Circulo c = new Circulo();
    Console.WriteLine("Digite o valor do raio:");
    double r = double.Parse(Console.ReadLine());
    c.SetRaio(r);
    double area = c.CalcArea();
    double circunferencia = c.CalcCircunferencia();
    Console.WriteLine($"A área do círculo é {area} e a circunferência é {circunferencia}.");
    
  }
  
}