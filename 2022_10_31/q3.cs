using System;
using System.Linq;

class Conversor {

  private int num;

  public Conversor(int num) {
    this.SetNum(num);
  }

  public void SetNum(int num) {
    if (num > 0) this.num = num;
  }

  public int GetNum() {
    return this.num;
  }

  public string Binario() {
    int n = this.num;
    string bin = "", invBin = "";
    while (n > 0) {
      if (n % 2 != 0) invBin += "1";
      else invBin += "0";
      n /= 2;
    }
    bin = new string(invBin.Reverse().ToArray());
    return bin;
  }

  public override string ToString() {
    return $"Número decimal: {this.num}\nRepresentação binária: {this.Binario()}";
  }
  
}

class UI {

  public static void Main() {
    Console.WriteLine("Digite um número:");
    int num = int.Parse(Console.ReadLine());
    Conversor c = new Conversor(num);
    Console.WriteLine(c.ToString());
  }
  
}