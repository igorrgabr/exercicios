using System; 

class URI {

    static void Main(string[] args) { 

        string name = Console.ReadLine();
        double salary = double.Parse(Console.ReadLine());
        double sale = double.Parse(Console.ReadLine());
        double ss = sale * 0.15;
        double total = salary + ss;
        Console.WriteLine($"TOTAL = R$ {total:0.00}");

    }

}