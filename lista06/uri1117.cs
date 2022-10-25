using System; 

class URI {

    static void Main(string[] args) { 

      double num, valid = 0;
      int qtdVal = 0;
      while (qtdVal < 2) {
        num = double.Parse(Console.ReadLine());
        if (num < 0 || num > 10) {
          Console.WriteLine("nota invalida");
        }
        else {
          valid += num;
          qtdVal += 1;
        }
        if (qtdVal == 2) {
            Console.WriteLine($"media = {(valid / 2):0.00}");
        }
      }
    }
  
}