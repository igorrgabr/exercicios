using System; 

class URI {

    static void Main(string[] args) { 

      int hours = int.Parse(Console.ReadLine());
      int speed = int.Parse(Console.ReadLine());
      double distance = hours * speed;
      double fuelSpent = distance / 12;
      Console.WriteLine($"{fuelSpent:0.000}");
      
    }

}