using System;
using System.Linq;

class Disciplina {

  private string nome = "indefinido";
  private int nota1, nota2, nota3, nota4, notaFinal;

  public void SetNome(string s) {
    if (string.IsNullOrEmpty(s) == false)
      nome = s;
  }
  public void SetNota1(int n) {
    if (n > 0)
      nota1 = n;
  }
  public void SetNota2(int n) {
    if (n > 0)
      nota2 = n;
  }
  public void SetNota3(int n) {
    if (n > 0)
      nota3 = n;
  }
  public void SetNota4(int n) {
    if (n > 0)
      nota4 = n;
  }
  public void SetNotaFinal(int n) {
    if (n > 0)
      notaFinal = n;
  }

  public string GetNome() {
    return nome;
  }
  public int GetNota1() {
    return nota1;
  }
  public int GetNota2() {
    return nota2;
  }
  public int GetNota3() {
    return nota3;
  }
  public int GetNota4() {
    return nota4;
  }
  public int GetNotaFinal() {
    return notaFinal;
  }

  public int CalcMediaParcial() {
    return (nota1 * 2 + nota2 * 2 + nota3 * 3 + nota4 * 3) / 10;
  }
  public int CalcMediaFinal() {
    return (CalcMediaParcial() + notaFinal) / 2;
  }
  
}

class UI {

  public static void Main() {

    int mediaParcial, mediaFinal;
    string n, situacao;
    
    Disciplina d = new Disciplina();
    Console.WriteLine("Digite o nome da disciplina:");
    n = Console.ReadLine();
    d.SetNome(n);
    Console.WriteLine("Digite suas notas, em ordem, separadas por espaço:");
    int[] notas = Console.ReadLine().Split().Select(int.Parse).ToArray();
    d.SetNota1(notas[0]);
    d.SetNota2(notas[1]);
    d.SetNota3(notas[2]);
    d.SetNota4(notas[3]);
    mediaParcial = d.CalcMediaParcial();
    mediaFinal = mediaParcial;
    if (mediaParcial < 60) {
      Console.WriteLine("Você ficou de recuperação. Digite sua nota final:");
      int nf = int.Parse(Console.ReadLine());
      d.SetNotaFinal(nf);
      mediaFinal = d.CalcMediaFinal();
    }
    if (mediaFinal >= 60) {
      situacao = "Aprovado";
    } else {
      situacao = "Reprovado";
    }
    Console.WriteLine($"Disciplina: {d.GetNome()}");
    Console.WriteLine($"Média parcial: {mediaParcial}");
    Console.WriteLine($"Média final: {mediaFinal}");
    Console.WriteLine($"Situação: {situacao}");
    
  }
  
}