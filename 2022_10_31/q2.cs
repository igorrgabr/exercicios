using System;

class Frete {

  private double distancia, peso;

  public Frete(double d, double p) {
    this.SetDistancia(d);
    this.SetPeso(p);
  }

  public void SetDistancia(double d) {
    if (d > 0) this.distancia = d;
  }
  public void SetPeso(double p) {
    if (p > 0) this.peso = p;
  }

  public double GetDistancia() {
    return this.distancia;
  }
  public double GetPeso() {
    return this.peso;
  }

  public double CalcFrete() {
    return 0.01 * (this.distancia * this.peso);
  }

  public override string ToString() {
    return $"Distância: {this.distancia} km\nPeso: {this.peso} kg";
  }
  
}

class UI {

  public static void Main() {
    Console.WriteLine("Digite a distância percorrida pela carga:");
    double d = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o peso da carga:");
    double p = double.Parse(Console.ReadLine());
    Frete f = new Frete(d, p);
    double valor = f.CalcFrete();
    Console.WriteLine(f.ToString());
    Console.WriteLine($"Valor do frete: R$ {valor:0.00}");
  }
  
}