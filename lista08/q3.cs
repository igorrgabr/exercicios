using System;
using System.Linq;

class Travel {
  
  public double km, hour, min;

  public void SetDistance(double s) {
    km = s;
  }
  public void SetHour(double h) {
    hour = h;
  }
  public void SetMin(double m) {
    min = m;
  }

  public double AvSpeed() {
    double t = hour + (min / 60);
    return km / t;
  }
  
}

class POO {

  public static void Main(string[] args) {
    
    Travel v = new Travel();
    Console.WriteLine("Digite a distância em quilômetros (km):");
    v.SetDistance(double.Parse(Console.ReadLine()));
    Console.WriteLine("Digite o tempo em horas e minutos, respectivamente:");
    double[] time = Console.ReadLine().Split().Select(double.Parse).ToArray();
    v.SetHour(time[0]);
    v.SetMin(time[1]);
    int speed = (int) v.AvSpeed();
    Console.WriteLine($"A velocidade média é, aproximadamente, {speed} km/h.");
    
  }
  
}