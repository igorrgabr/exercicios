using System;

class URI {

    static void Main(string[] args) { 
      int a, b, c, first = 0, second = 0, third = 0;

      string[] nums = Console.ReadLine().Split();
      a = int.Parse(nums[0]);
      b = int.Parse(nums[1]);
      c = int.Parse(nums[2]);

      if (a < b && a < c) {
        first = a;
        if (b < c) {
          second = b;
          third = c;
        } else {
          second = c;
          third = b;
        }
      } else if (b < a && b < c) {
        first = b;
        if (a < c) {
          second = a;
          third = c;
        } else {
          second = c;
          third = a;
        }
      } else if (c < a && c < b) {
        first = c;
        if (a < b) {
          second = a;
          third = b;
        } else {
          second = b;
          third = a;
        }
      }

      Console.WriteLine(first);
      Console.WriteLine(second);
      Console.WriteLine(third);
      Console.WriteLine("");
      Console.WriteLine(a);
      Console.WriteLine(b);
      Console.WriteLine(c);

    }

}