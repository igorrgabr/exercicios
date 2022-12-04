using System; 
using System.Linq;

class URI {

    static void Main(string[] args) { 
      int qtd = 0;

      int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
      int[] loteria = Console.ReadLine().Split().Select(int.Parse).ToArray();

      if (nums[0] == loteria[0] || nums[0] == loteria[1] || nums[0] == loteria[2] || nums[0] == loteria[3] || nums[0] == loteria[4] || nums[0] == loteria[5]) {
        qtd++;
      }
      if (nums[1] == loteria[0] || nums[1] == loteria[1] || nums[1] == loteria[2] || nums[1] == loteria[3] || nums[1] == loteria[4] || nums[1] == loteria[5]) {
        qtd++;
      }
      if (nums[2] == loteria[0] || nums[2] == loteria[1] || nums[2] == loteria[2] || nums[2] == loteria[3] || nums[2] == loteria[4] || nums[2] == loteria[5]) {
        qtd++;
      }
      if (nums[3] == loteria[0] || nums[3] == loteria[1] || nums[3] == loteria[2] || nums[3] == loteria[3] || nums[3] == loteria[4] || nums[3] == loteria[5]) {
        qtd++;
      }
      if (nums[4] == loteria[0] || nums[4] == loteria[1] || nums[4] == loteria[2] || nums[4] == loteria[3] || nums[4] == loteria[4] || nums[4] == loteria[5]) {
        qtd++;
      }
      if (nums[5] == loteria[0] || nums[5] == loteria[1] || nums[5] == loteria[2] || nums[5] == loteria[3] || nums[5] == loteria[4] || nums[5] == loteria[5]) {
        qtd++;
      }

      if (qtd == 3) {
        Console.WriteLine("terno");
      } else if (qtd == 4) {
        Console.WriteLine("quadra");
      } else if (qtd == 5) {
        Console.WriteLine("quina");
      } else if (qtd == 6) {
        Console.WriteLine("sena");
      } else {
        Console.WriteLine("azar");
      }
      
    }

}