using System; 

class URI {

    static void Main(string[] args) { 

      int num = int.Parse(Console.ReadLine());
      int x = num / 100;
      int y = num % 100;
      Console.WriteLine($"{num}");
      Console.WriteLine($"{x} nota(s) de R$ 100,00");
      Console.WriteLine($"{y / 50} nota(s) de R$ 50,00");
      Console.WriteLine($"{(y % 50) / 20} nota(s) de R$ 20,00");
      Console.WriteLine($"{((y % 50) % 20) / 10} nota(s) de R$ 10,00");
      Console.WriteLine($"{(((y % 50) % 20) % 10) / 5} nota(s) de R$ 5,00");
      Console.WriteLine($"{((((y % 50) % 20) % 10) % 5) / 2} nota(s) de R$ 2,00");
      Console.WriteLine($"{(((((y % 50) % 20) % 10) % 5) % 2) / 1} nota(s) de R$ 1,00");
      
    }

}