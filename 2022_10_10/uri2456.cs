using System; 

class URI {

    static void Main(string[] args) { 
      
      string[] cards = Console.ReadLine().Split();
      int a = int.Parse(cards[0]), b = int.Parse(cards[1]), c = int.Parse(cards[2]), d = int.Parse(cards[3]), e = int.Parse(cards[4]);

      if (a < b && b < c && c < d && d < e) {
        Console.WriteLine("C");
      } else if (a > b && b > c && c > d && d > e) {
        Console.WriteLine("D");
      } else {
        Console.WriteLine("N");
      }
    
    }

}