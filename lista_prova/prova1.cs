using System;

class Pais {

  private string nome;
  private int populacao;
  private double area;

  public Pais(string nome, int populacao, double area) {
    this.SetNome(nome);
    this.SetPopulacao(populacao);
    this.SetArea(area);
  }

  public void SetNome(string nome) {
    if (String.IsNullOrEmpty(nome) == false)
      this.nome = nome;
  }
  public void SetPopulacao(int populacao) {
    if (populacao > 0)
      this.populacao = populacao;
  }
  public void SetArea(double area) {
    if (area > 0)
      this.area = area;
  }

  public string GetNome() {
    return this.nome;
  }
  public int GetPopulacao() {
    return this.populacao;
  }
  public double GetArea() {
    return this.area;
  }

  public double Densidade() {
    return this.populacao / this.area;
  }

  public override string ToString() {
    return $"Nome: {this.nome}\nPopulação: {this.populacao}\nÁrea: {this.area}";
  }
  
}

class UI {

  public static void Main() {

    Pais[] paises = new Pais[10];
    int count = 1;
    for (int i = 0; i < 10; i++) {
      Console.WriteLine($"Nome do {count}° país:");
      string name = Console.ReadLine();
      Console.WriteLine($"População do {count}° país:");
      int pop = int.Parse(Console.ReadLine());
      Console.WriteLine($"Área geográfica do {count}° país:");
      double area = double.Parse(Console.ReadLine());
      paises[i] = new Pais(name, pop, area);
      count++;
    }

    Pais maior = paises[0];
    for (int j = 1; j < 10; j++) {
      if (paises[j].Densidade() > maior.Densidade())
        maior = paises[j];
    }

    Console.WriteLine("Dados do país com maior densidade demográfica.");
    Console.WriteLine(maior.ToString());
    Console.WriteLine($"Densidade: {maior.Densidade()}");
    
  }
  
}