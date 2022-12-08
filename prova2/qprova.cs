using System;
using System.Collections;

class Jogador : IComparable {

  public Jogador(string nome, int camisa, int numGols) {
    Nome = nome;
    Camisa = camisa;
    NumGols = numGols;
  }

  private string nome = "?";
  public string Nome {
    set { if (value != "") this.nome = value; }
    get { return this.nome; }
  }

  private int camisa = 0;
  public int Camisa {
    set { if (value > 0) this.camisa = value; }
    get { return this.camisa; }
  }

  private int numGols = 0;
  public int NumGols {
    set { if (value >= 0) this.numGols = value; }
    get { return this.numGols; }
  }

  public int CompareTo(object obj) {
    Jogador j1 = this;
    Jogador j2 = (Jogador) obj;
    return j1.Nome.CompareTo(j2.Nome);
  }

  public override string ToString() {
    return $"[Dados do Jogador]\nNome: {this.nome}\nNúmero da camisa: {this.camisa}\nQuantidade de gols: {this.numGols}";
  }
  
}

class ComparaCamisa : IComparer {

  public int Compare(object x, object y) {
    Jogador j1 = (Jogador) x;
    Jogador j2 = (Jogador) y;
    return j1.Camisa.CompareTo(j2.Camisa);
  }
  
}

class ComparaGols : IComparer {

  public int Compare(object x, object y) {
    Jogador j1 = (Jogador) x;
    Jogador j2 = (Jogador) y;
    return j2.NumGols.CompareTo(j1.NumGols);
  }
  
}

class Equipe {

  private string pais = "?";
  public string Pais { set { if (value != "") pais = value; } get { return pais; } }

  public Jogador[] jogadores;

  public int Qtd { get { return jogadores.Length; } }
  int i;

  public Equipe(string p) {
    Pais = p;
  }

  public void Inserir(Jogador j) {
    if (i < Qtd) jogadores[i++] = j;
  }

  public Jogador[] Listar() {
    Array.Sort(jogadores);
    return jogadores;
  }

  public Jogador[] Artilheiros() {
    Jogador[] artilheiros = new Jogador[3];
    ComparaGols compara = new ComparaGols();
    Array.Sort(jogadores, compara);
    this.i = 0;
    while (this.i < 3) {
      artilheiros[this.i] = jogadores[this.i];
      i++;
    }
    return artilheiros;
  }

  public Jogador[] Camisas() {
    ComparaCamisa compara = new ComparaCamisa();
    Array.Sort(jogadores, compara);
    return jogadores;
  }
  
  public override string ToString() {
    return $"[Dados da Seleção]\nPaís: {pais}\nNúmero de jogadores: {Qtd}";
  }
  
}

class UI {

  public static void Main() {
    Equipe brasil = new Equipe("Brasil");
    brasil.jogadores = new Jogador[5];

    Jogador goleiro = new Jogador("Alisson", 1, 1);
    brasil.Inserir(goleiro);

    Jogador zagueiro = new Jogador ("Marquinhos", 3, 5);
    brasil.Inserir(zagueiro);

    Jogador meia = new Jogador("Casemiro", 8, 3);
    brasil.Inserir(meia);

    Jogador ponta = new Jogador("Vinicius Jr", 11, 10);
    brasil.Inserir(ponta);

    Jogador atacante = new Jogador("Richarlison", 9, 8);
    brasil.Inserir(atacante);

    Console.WriteLine(brasil.ToString()); // dados da seleção

    Jogador[] listaJogadores = brasil.Listar(); // listar os jogadores em ordem alfabética
    foreach (Jogador j in listaJogadores) {
      Console.WriteLine($"Nome: {j.Nome}");
    }

    Console.WriteLine("\n[Artilheiros]"); // listar pelo numero de gols
    Jogador[] artilheiros = brasil.Artilheiros();
    foreach (Jogador j in artilheiros) {
      Console.WriteLine($"Nome: {j.Nome}");
      Console.WriteLine($"N° de gols: {j.NumGols}");
    }

    Console.WriteLine("\n[Ordem das camisas]");
    Jogador[] camisas = brasil.Camisas();
    foreach (Jogador j in camisas) {
      Console.WriteLine($"Nome: {j.Nome}");
      Console.WriteLine($"N° da camisa: {j.Camisa}");
    }
    
  }
  
}