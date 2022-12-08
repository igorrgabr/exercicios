using System;
using System.Collections;

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
    
    ContaPagar c1 = new ContaPagar { Fornecedor = "Igor", Vencimento = DateTime.Parse("2023/03/07"), Valor = 25.0 };
    ContaPagar c2 = new ContaPagar { Fornecedor = "Cibele", Vencimento = DateTime.Parse("2023/04/23"), Valor = 70.0 };
    ContaPagar c3 = new ContaPagar { Fornecedor = "Marcus", Vencimento = DateTime.Parse("2023/03/07"), Valor = 45.5 };
    ContaPagar c4 = new ContaPagar { Fornecedor = "Arthur", Vencimento = DateTime.Parse("2022/12/20"), Valor = 100.5 };

    ContaPagar[] contas = new ContaPagar[4] { c1, c2, c3, c4 };
    
    ComparaFornecedor compara = new ComparaFornecedor();

    Array.Sort(contas, compara);
    Array.Sort(contas);

    foreach (ContaPagar c in contas) {
      Console.WriteLine($"Nome do fornecedor: {c.Fornecedor}");
      Console.WriteLine($"Data de vencimento: {c.Vencimento.Date}");
      Console.WriteLine($"Valor: R$ {c.Valor:0.00}");
      Console.WriteLine("");
    }
    
  }
  
}