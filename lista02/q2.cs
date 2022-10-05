using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite seu nome completo:");
    string[] name = Console.ReadLine().Split();
    Console.WriteLine($"Bem-vindo ao C#, {name[0]}.");
  }
}