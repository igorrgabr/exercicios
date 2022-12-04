using System;

class Boleto {

  private string codBarras = "?";
  private DateTime dataEmissao, dataVencimento;
  public DateTime dataPagamento;
  private double valorBoleto;
  public double valorPago;
  private Pagamento situacaoPagamento;

  public Boleto(string cod, DateTime emissao, DateTime venc, double valor) {
    if (String.IsNullOrEmpty(cod) != true) this.codBarras = cod;
    this.dataEmissao = emissao;
    this.dataVencimento = venc;
    this.valorBoleto = valor;
  }

  public void Pagar(double valorPago, DateTime dataPagamento) {
    if (valorPago <= this.valorBoleto) this.valorPago = valorPago;
    this.dataPagamento = dataPagamento;
  }

  public Pagamento Situacao() {
    if (this.valorPago > 0) {
      if (this.valorPago < this.valorBoleto) this.situacaoPagamento = (Pagamento) 2;
      else if (this.valorPago == this.valorBoleto) this.situacaoPagamento = (Pagamento) 3;
    } else {
      this.situacaoPagamento = (Pagamento) 1;
    }
    return this.situacaoPagamento;
  }

  public override string ToString() {
    return $"[Dados do boleto]\nCódigo de barras: {this.codBarras}\nData de emissão: {this.dataEmissao:dd/MM/yyyy}\nData de vencimento: {this.dataVencimento:dd/MM/yyyy}\nValor: R$ {this.valorBoleto:0.00}";
  }
  
}
public enum Pagamento : byte {
  EmAberto = 1, PagoParcial = 2, Pago = 3
}

class UI {

  public static void Main() {
    Console.WriteLine("Digite o número do código de barras:");
    string cod = Console.ReadLine();
    Console.WriteLine("Digite a data de emissão (YYYY/MM/DD):");
    DateTime dtEmi = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Digite a data de vencimento (YYYY/MM/DD):");
    DateTime dtVenc = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor do boleto:");
    double val = double.Parse(Console.ReadLine());
    Boleto b = new Boleto(cod, dtEmi, dtVenc, val);

    Console.WriteLine("Digite o valor do pagamento que deseja realizar:");
    double valPago = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a data do pagamento (YYYY/MM/DD):");
    DateTime dtPago = DateTime.Parse(Console.ReadLine());
    b.Pagar(valPago, dtPago);
    double valRest = val - valPago;
    Pagamento s = b.Situacao();

    Console.WriteLine(b.ToString());
    Console.WriteLine($"Status: {s}");
    if (valPago > 0) Console.WriteLine($"[Dados do pagamento]\nValor: R$ {valPago:0.00}\nValor restante: R$ {valRest:0.00}\nData: {b.dataPagamento:dd/MM/yyyy}");
  }
  
}