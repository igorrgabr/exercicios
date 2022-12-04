using System;

class Equacao {

  private double a, b, c;

  public Equacao(double a, double b, double c) {
    this.SetABC(a, b, c);
  }

  public void SetABC(double a, double b, double c) {
    if (a != 0) this.a = a;
    this.b = b;
    this.c = c;
  }

  public void GetABC(out double a, out double b, out double c) {
    a = this.a;
    b = this.b;
    c = this.c;
  }

  public bool RaizesReais(out double x1, out double x2) {
    x1 = x2 = 0;
    bool raiz = false;
    double d = Delta();
    if (d >= 0) {
      raiz = true;
      x1 = (-this.b + Math.Sqrt(d)) / (2 * this.a);
      x2 = (-this.b - Math.Sqrt(d)) / (2 * this.a);
    }
    return raiz;
  }

  public double Delta() {
    return Math.Pow(this.b, 2) - 4 * this.a * this.c;
  }

  public override string ToString() {
    return $"Coeficiente A: {this.a:0.0}\nCoeficiente B: {this.b:0.0}\nCoeficiente C: {this.c:0.0}";
  }
  
}

class UI {

  public static void Main() {
    Console.WriteLine("Digite os coeficientes A, B e C, respectivamente:");
    string[] valores = Console.ReadLine().Split();
    double A = double.Parse(valores[0]);
    double B = double.Parse(valores[1]);
    double C = double.Parse(valores[2]);
    Equacao e = new Equacao(A, B, C);
    Console.WriteLine(e.ToString());
    double X1, X2;
    if (e.RaizesReais(out X1, out X2)) Console.WriteLine($"Raiz x1: {X1:0.0}\nRaiz x2: {X2:0.0}");
    else Console.WriteLine("Não possui raizes reais x1 e x2.");
  }
  
}