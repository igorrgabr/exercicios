using System; 

class URI {

    static void Main(string[] args) { 

      int test = int.Parse(Console.ReadLine());
      for (int i = 1; i <= test; i++) {
        int num = int.Parse(Console.ReadLine());
        bool prime = true;
        
        if (num % 2 == 0 && num != 2 || num == 1) {
          prime = false;
        } else {
          for (int j = 3; j*j < num+1; j += 2) {
            if (num % j == 0) {
              prime = false;
              break;
            }
          }
        }
        if (prime)
          Console.WriteLine("Prime");
        else
          Console.WriteLine("Not Prime");
    }
  }
}