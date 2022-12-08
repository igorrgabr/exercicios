using System;

class Retangulo {

  private double b, h;

  public double Base {
    get { return b; }
    set { if (value > 0) b = value; }
  }

  public double Altura {
    get { return h; }
    set { if (value > 0) h = value; }
  }

  public double Area {
    get { return b * h; }
  }

  public double Diagonal {
    get { return Math.Sqrt(b*b + h*h); }
  }

  public override string ToString() {
    return $"Base: {b:0.00}\nAltura: {h:0.00}";
  }
  
}

class UI {

  public static void Main() {
    Retangulo r = new Retangulo { Base = int.Parse(Console.ReadLine()), Altura = int.Parse(Console.ReadLine()) };
    Console.WriteLine(r.ToString());
    Console.WriteLine($"Área: {r.Area:0.00}");
    Console.WriteLine($"Diagonal: {r.Diagonal:0.00}");
  }
  
}