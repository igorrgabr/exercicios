using System;
using System.Collections;

class Empresa {

  public ContaPagar[] contas;
  
  private string nome = "?";
  public string Nome { set { if (value != "") nome = value; } get { return nome; } }

  public int Quantidade { get { return contas.Length; } }
  public int i = 0;

  public void Inserir(ContaPagar conta) {
    if (i < Quantidade) contas[i++] = conta;
  }

  public ContaPagar[] Listar() {
    ComparaFornecedor compara = new ComparaFornecedor();
    Array.Sort(contas, compara);
    Array.Sort(contas);
    return contas;
  }

  public ContaPagar[] Pesquisar(int mes, int ano) {
    ContaPagar[] pesquisa = new ContaPagar[Quantidade];
    int i = 0;
    foreach (ContaPagar c in contas) {
      if (c.Vencimento.Month == mes && c.Vencimento.Year == ano) pesquisa[i++] = c;
    }
    return pesquisa;
  }

  public double Total(int mes, int ano) {
    double total = 0;
    foreach (ContaPagar c in contas) {
      if (c.Vencimento.Month == mes && c.Vencimento.Year == ano) total += c.Valor;
    }
    return total;
  }
  
}

class ContaPagar : IComparable {

  private string f = "?";
  public string Fornecedor { set {if (value != "") f = value; } get { return f; } }
  
  private DateTime venc;
  public DateTime Vencimento { set { venc = value; } get { return venc; } }

  private double v;
  public double Valor { set { if (value > 0) v = value; } get { return v; } }

  public int CompareTo(object obj) {
    ContaPagar c1 = this;
    ContaPagar c2 = (ContaPagar) obj;
    return c1.Vencimento.CompareTo(c2.Vencimento);
  }

  public override string ToString() {
    return $"Nome do fornecedor: {Fornecedor}\nData de vencimento: {Vencimento.Date:dd/MM/yyyy}\nValor: R$ {Valor:0.00}";
  }
  
}

class ComparaFornecedor : IComparer {

  public int Compare(object x, object y) {
    ContaPagar c1 = (ContaPagar) x;
    ContaPagar c2 = (ContaPagar) y;
    return c1.Fornecedor.CompareTo(c2.Fornecedor);
  }
  
}

class UI {

  public static void Main() {
    
    Empresa cnat = new Empresa();
    cnat.contas = new ContaPagar[4];
    cnat.Nome = "IFRN-CNAT";
    
    ContaPagar c1_cnat = new ContaPagar { Fornecedor = "Luz", Vencimento = DateTime.Parse("2022/12/20"), Valor = 3475.5 };
    cnat.Inserir(c1_cnat);

    ContaPagar c2_cnat = new ContaPagar { Fornecedor = "Água", Vencimento = DateTime.Parse("2022/12/17"), Valor = 2530.37 };
    cnat.Inserir(c2_cnat);

    ContaPagar c3_cnat = new ContaPagar { Fornecedor = "Internet", Vencimento = DateTime.Parse("2023/01/10"), Valor = 1500 };
    cnat.Inserir(c3_cnat);

    ContaPagar c4_cnat = new ContaPagar { Fornecedor = "Alimentação", Vencimento = DateTime.Parse("2023/01/07"), Valor = 6480.43 };
    cnat.Inserir(c4_cnat);

    Console.WriteLine("[Lista de contas]");
    foreach (ContaPagar c in cnat.Listar()) {
      Console.WriteLine(c.ToString());
      Console.WriteLine("");
    }

    Console.WriteLine("");

    ContaPagar[] pesquisa = cnat.Pesquisar(1, 2023);
    Console.WriteLine("[Contas de Janeiro, 2023]");
    foreach (ContaPagar c in pesquisa) {
      Console.WriteLine(c.ToString());
      Console.WriteLine("");
    }

    Console.WriteLine("");

    double total = cnat.Total(1, 2023);
    Console.WriteLine("[Valor total das contas de Janeiro, 2023]");
    Console.WriteLine($"R$ {total:0.00}");
    
  }
  
}