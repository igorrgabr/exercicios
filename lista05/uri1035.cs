using System; 
using System.Linq;

class URI {

    static void Main(string[] args) { 

      string[] l = Console.ReadLine().Split();
      int a = int.Parse(l[0]);
      int b = int.Parse(l[1]);
      int c = int.Parse(l[2]);
      int d = int.Parse(l[3]);
      if ((b > c) && (d > a) && ((c + d) > (a + b)) && (c > 0) && (d > 0) && (a % 2 == 0)) {
        Console.WriteLine("Valores aceitos");
      } else {
        Console.WriteLine("Valores nao aceitos");
      }

    }

}