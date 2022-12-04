using System;
using System.Linq;

class Disciplina {

  private string nome = "indefinido";
  private int n1, n2, n3, n4, nf;

  public void SetNome(string texto) {
    if (string.IsNullOrEmpty(texto) == false)
      nome = texto;
  }
  public string GetNome() {
    return nome;
  }

  public void SetN1(int x) {
    if (x >= 0 && x <= 100)
      n1 = x;
  }
  public int GetN1() {
    return n1;
  }

  public void SetN2(int x) {
    if (x >= 0 && x <= 100)
      n2 = x;
  }
  public int GetN2() {
    return n2;
  }

  public void SetN3(int x) {
    if (x >= 0 && x <= 100)
      n3 = x;
  }
  public int GetN3() {
    return n3;
  }

  public void SetN4(int x) {
    if (x >= 0 && x <= 100)
      n4 = x;
  }
  public int GetN4() {
    return n4;
  }

  public void SetNf(int x) {
    if (x >= 0 && x <= 100)
      nf = x;
  }
  public int GetNf() {
    return nf;
  }

  public int calcMediaP() {
    return (n1 * 2 + n2 * 2 + n3 * 3 + n4 * 3) / 10;
  }
  public int calcMediaF() {
    return (calcMediaP() + nf) / 2;
  }
  
}

class POO {

  public static void Main(string[] args) {

    Disciplina d = new Disciplina();
    Console.WriteLine("Digite o nome da disciplina:");
    d.SetNome(Console.ReadLine());
    Console.WriteLine("Digite suas notas do primeiro, segundo, terceiro e quarto bimestre, separadas por espaço, em ordem.");
    int[] notas = Console.ReadLine().Split().Select(int.Parse).ToArray();
    d.SetN1(notas[0]);
    d.SetN2(notas[1]);
    d.SetN3(notas[2]);
    d.SetN4(notas[3]);
    
    int notaP = d.calcMediaP();
    if (notaP >= 60) {
      Console.WriteLine($"Parabéns, você foi aprovado com média {notaP}.");
    } else {
      Console.WriteLine("Você ficou em recuperação. Digite sua nota final:");
      d.SetNf(int.Parse(Console.ReadLine()));
      int notaF = d.calcMediaF();
      if (notaF >= 60) {
        Console.WriteLine($"Parabéns, você foi aprovado com média final {notaF}.");
      } else {
        Console.WriteLine($"Você foi reprovado com nota {notaF}. =(");
      }
    }
    
  }
  
}