using System; 

class URI {

    static void Main(string[] args) { 

      int i, fib, numAnterior = 0, numAtual = 1;
      int n = int.Parse(Console.ReadLine());
      int[] nums = new int[n];
      nums[0] = 0;
      nums[1] = 1;
      for (i = 2; i < n; i++) {
        fib = numAnterior + numAtual;
        numAnterior = numAtual;
        numAtual = fib;
        nums[i] = fib;
      }
      Console.WriteLine(string.Join(" ", nums));

    }

}