using System; 
using System.Linq;

class URI {

    static void Main(string[] args) { 

      int[] x = Console.ReadLine().Split().Select(int.Parse).ToArray();
      int num = (x[0] + x[1] + Math.Abs(x[0] - x[1])) / 2;
      int maiorAB = (num + x[2] + Math.Abs(num - x[2])) / 2;
      Console.WriteLine($"{maiorAB} eh o maior");
      
    }

}