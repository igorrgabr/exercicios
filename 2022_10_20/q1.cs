using System;

class Circulo {

  public double r;

  public double CalcArea() {
    return 3.14 * (r * r);
  }

  public double CalcCircun() {
    return 2 * 3.14 * r;
  }
  
}

class POO {

    public static void Main(string[] args) {

    Circulo raio;
    raio = new Circulo();
    Console.WriteLine("Digite o raio do círculo:");
    raio.r = double.Parse(Console.ReadLine());
    double areaCirculo = raio.CalcArea();
    double circunCirculo = raio.CalcCircun();
    Console.WriteLine($"A área do círculo é {areaCirculo}cm².");
    Console.WriteLine($"A circunferência do círculo é {circunCirculo}cm.");
    
  }
  
}