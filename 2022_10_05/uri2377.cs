using System; 
using System.Linq;

class URI {

    static void Main(string[] args) { 

      int[] ld = Console.ReadLine().Split().Select(int.Parse).ToArray();
      int[] kp = Console.ReadLine().Split().Select(int.Parse).ToArray();
      int qtd = ld[0] / ld[1];
      int cost = (ld[0] * kp[0]) + (kp[1] * qtd);
      Console.WriteLine(cost);
      
    }

}