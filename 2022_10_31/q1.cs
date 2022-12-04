using System;

class Retangulo {

  private double b, h;

  public Retangulo(double b, double h) {
    this.SetBase(b);
    this.SetAltura(h);
  }

  public void SetBase(double b) {
    if (b > 0) this.b = b;
  }
  public void SetAltura(double h) {
    if (h > 0) this.h = h;
  }

  public double GetBase() {
    return this.b;
  }
  public double GetAltura() {
    return this.h;
  }

  public double CalcArea() {
    return this.b * this.h;
  }
  public double CalcDiagonal() {
    return Math.Sqrt(Math.Pow(this.b, 2) + Math.Pow(this.h, 2));
  }

  public override string ToString() {
    return $"A base do retângulo é {this.b:0.0} e a altura é {this.h:0.0}.";
  }
  
}

class UI {

  public static void Main() {
    Console.WriteLine("Digite os valores da base e altura do retângulo, respectivamente:");
    string[] valores = Console.ReadLine().Split();
    double b = double.Parse(valores[0]);
    double h = double.Parse(valores[1]);
    Retangulo r = new Retangulo(b, h);
    double area = r.CalcArea();
    double diagonal = r.CalcDiagonal();
    Console.WriteLine(r.ToString());
    Console.WriteLine($"A área do retângulo é {area:0.0} e a sua diagonal é {diagonal:0.0}, aproximadamente.");
  }
  
}