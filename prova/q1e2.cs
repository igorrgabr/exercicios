using System;

class Pais {

  private string nome;
  private int populacao;

  public Pais(string nome, int populacao) {
    this.SetNome(nome);
    this.SetPopulacao(populacao);
  }

  public void SetNome(string nome) {
    if (nome != "")
      this.nome = nome;
  }
  public void SetPopulacao(int populacao) {
    if (populacao > 0)
      this.populacao = populacao;
  }

  public string GetNome() {
    return this.nome;
  }
  public int GetPopulacao() {
    return this.populacao;
  }

  public override string ToString() {
    return $"Cidade: {this.nome}.\nPopulação: {this.populacao} habitantes.";
  }
  
}

class UI {

  public static void Main() {

    Pais[] paises = new Pais[10];
    int count = 1;
    for (int i = 0; i < 10; i++) {
      Console.WriteLine($"Digite o nome do {count}° país:");
      string n = Console.ReadLine();
      Console.WriteLine($"Digite a população do {count}° país:");
      int p = int.Parse(Console.ReadLine());
      paises[i] = new Pais(n, p);
      count++;
    }

    Pais maior = paises[0];
    for (int j = 1; j < 10; j++) {
      if (paises[j].GetPopulacao() > maior.GetPopulacao())
        maior = paises[j];
    }

    Console.WriteLine(maior.ToString());
    
  }
  
}