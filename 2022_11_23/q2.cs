using System;

class Premio {

  private string cliente = "?";
  private DateTime data;
  private object premio;

  public Premio(string c, DateTime d) {
    if (String.IsNullOrEmpty(c) != true) this.cliente = c;
    this.data = d;
  }

  public void SetPremio(object p) {
    this.premio = p;
  }
  
  public object GetPremio() {
    return this.premio;
  }

  public override string ToString() {
    return $"[Dados]\nCliente: {this.cliente}\nData: {this.data:dd/MM/yyyy}\nPrêmio: {this.premio.GetType()}";
  }
  
}

class ValeCompras {

  private DateTime dataValidade;
  private double valor;

  public ValeCompras(DateTime d, double v) {
    this.dataValidade = d;
    if (v > 0) this.valor = v;
  } 

  public override string ToString() {
    return $"[Vale-compras]\nValor: R$ {this.valor:0.00}\nData de validade: {this.dataValidade:dd/MM/yyyy}";
  }
  
}

class Produto {

  private string descricao;
  private double valor;

  public Produto(string d, double v) {
    if (String.IsNullOrEmpty(d) != true) this.descricao = d;
    if (v > 0) this.valor = v;
  }

  public override string ToString() {
    return $"[Produto]\nValor: R$ {this.valor:0.00}\nDescrição: {this.descricao}";
  }
  
}

class UI {
  
  public static void Main() {
    Console.WriteLine("Digite o nome do cliente:");
    string c = Console.ReadLine();
    Console.WriteLine("Digite a data de recebimento (YYYY/MM/DD):");
    DateTime d = DateTime.Parse(Console.ReadLine());
    Premio p = new Premio(c, d);
    
    Console.WriteLine("Qual foi o prêmio escolhido? Digite V para vale-compras ou P para produto:");
    string opc = Console.ReadLine().ToUpper();
    if (opc == "V") {
      Console.WriteLine("Você escolheu vale-compras.");
      Console.WriteLine("Digite a validade (YYYY/MM/DD):");
      DateTime validade = DateTime.Parse(Console.ReadLine());
      Console.WriteLine("Digite o valor:");
      double valor = double.Parse(Console.ReadLine());
      ValeCompras vale = new ValeCompras(validade, valor);
      p.SetPremio(vale);
    } else if (opc == "P") {
      Console.WriteLine("Você escolheu produto.");
      Console.WriteLine("Digite a descrição:");
      string desc = Console.ReadLine();
      Console.WriteLine("Digite o valor:");
      double valor = double.Parse(Console.ReadLine());
      Produto prod = new Produto(desc, valor);
      p.SetPremio(prod);
    } else {
      Console.WriteLine("Erro na escolha do prêmio!");
    }

    Console.WriteLine(p.ToString());
    Console.WriteLine(p.GetPremio().ToString());
  }
  
}