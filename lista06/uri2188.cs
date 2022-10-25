using System; 
using System.Linq;

class URI {

    static void Main(string[] args) { 

      int t = 0;
      while (true) {
        int n = int.Parse(Console.ReadLine());
        t++;

        if (n == 0)
          break;

        int x = -10000;
        int v = x;
        int y = 10000;
        int u = y;

        for (int i = 0; i < n; i++) {
          int[] l = Console.ReadLine().Split().Select(int.Parse).ToArray();
          if (l[0] > x)
            x = l[0];
          if (l[1] < y)
            y = l[1];
          if (l[2] < u)
            u = l[2];
          if (l[3] > v)
            v = l[3];
        }

        Console.WriteLine($"Teste {t}");
        if (x < u && v < y)
          Console.WriteLine($"{x} {y} {u} {v}");
        else
          Console.WriteLine("nenhum");
        Console.WriteLine("");
      }

    }
}