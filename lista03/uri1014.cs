using System; 

class URI {

    static void Main(string[] args) { 

      int x = int.Parse(Console.ReadLine());
      double y = double.Parse(Console.ReadLine());
      double total = x / y;
      Console.WriteLine($"{total:0.000} km/l");
      
    }

}