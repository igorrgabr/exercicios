using System; 

class URI {

    static void Main(string[] args) { 

      while (true) {
        string[] nums = Console.ReadLine().Split();
        int d = int.Parse(nums[0]);
        int vf = int.Parse(nums[1]);
        int vg = int.Parse(nums[2]);
        double dist = Math.Sqrt(d * d + 144);
        if (12 / vf >= dist / vg)
          Console.WriteLine("S");
        else
          Console.WriteLine("N");
      }
      
    }
}