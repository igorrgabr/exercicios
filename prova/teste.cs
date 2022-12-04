using System;

class Triangulo {

  private int b, h;

  public Triangulo(int b, int h) {
    this.SetBase(b);
    this.SetAltura(h);
  }

  public void SetBase(int b) {
    if (b > 0)
      this.b = b;
  }
  public void SetAltura(int h) {
    if (h > 0)
      this.h = h;
  }

  public int GetBase() {
    return this.b;
  }
  public int GetAltura() {
    return this.h;
  }

  public int CalcArea() {
    return (b * h) / 2;
  }

  public override string ToString() {
    return $"A base do triângulo é {this.b} e a altura é {this.h}.";
  }
  
}

class UI {

  public static void Main() {
    int b, h, area;
    b = int.Parse(Console.ReadLine());
    h = int.Parse(Console.ReadLine());
    Triangulo t = new Triangulo(b,h);
    area = t.CalcArea();
    Console.WriteLine(t.ToString());
    Console.WriteLine($"Logo, a área é {area}.");
  }
  
}