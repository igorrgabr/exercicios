using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite o intervalo de tempo no formato “HH:MM:SS”:");
    string[] time = Console.ReadLine().Split(':');
    long h = long.Parse(time[0]);
    long m = long.Parse(time[1]);
    long sec = long.Parse(time[2]);
    long hToSec = h * 3600;
    long mToSec = m * 60;
    long total = (hToSec + mToSec + sec) * 300000;
    Console.WriteLine($"A luz percorreu {total} km nesse intervalo!");
  }
}