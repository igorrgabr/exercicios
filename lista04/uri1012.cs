using System; 
using System.Linq;

class URI {

    static void Main(string[] args) { 

      double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
      double triangle = (nums[0] * nums[2]) / 2;
      double circle = Math.Pow(nums[2], 2) * 3.14159;
      double trapezium = ((nums[0] + nums[1]) * nums[2]) / 2;
      double square = Math.Pow(nums[1], 2);
      double rectangle = nums[0] * nums[1];
      Console.WriteLine($"TRIANGULO: {triangle:0.000}");
      Console.WriteLine($"CIRCULO: {circle:0.000}");
      Console.WriteLine($"TRAPEZIO: {trapezium:0.000}");
      Console.WriteLine($"QUADRADO: {square:0.000}");
      Console.WriteLine($"RETANGULO: {rectangle:0.000}");
      
    }

}