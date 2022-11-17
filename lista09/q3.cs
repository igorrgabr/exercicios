using System;

class Viagem {
  
  private double distancia, tempo;

  public void SetDistancia(double d) {
    if (d > 0)
      distancia = d;
  }
  public void SetTempo(double t) {
    if (t > 0)
      tempo = t;
  }

  public double GetDistancia() {
    return distancia;
  }
  public double GetTempo() {
    return tempo;
  }

  public double VelocidadeMedia() {
    return distancia / tempo;
  }
  
}

class UI {

  public static void Main() {

    Viagem v = new Viagem();
    Console.WriteLine("Digite a distância em quilômetros (km):");
    double d = double.Parse(Console.ReadLine());
    v.SetDistancia(d);
    Console.WriteLine("Digite o tempo gasto em horas e minutos (HH:MM):");
    string[] t = Console.ReadLine().Split(":");
    double h = double.Parse(t[0]);
    double m = double.Parse(t[1]);
    v.SetTempo(h + m / 60);
    int velocidade = (int) v.VelocidadeMedia();
    Console.WriteLine($"A velocidade média é, aproximadamente, {velocidade} km/h.");
    
  }
  
}