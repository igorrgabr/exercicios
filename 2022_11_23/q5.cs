using System;

class Estagio {

  private string estagiario, empresa;
  private DateTime dataInicio, dataCancelamento, dataFim;
  private SituacaoEstagio situacao;

  public Estagio(string est, string emp) {
    if (String.IsNullOrEmpty(est) == false) this.estagiario = est;
    if (String.IsNullOrEmpty(emp) == false) this.empresa = emp;
    this.situacao = (SituacaoEstagio) 0;
  }

  public bool Iniciar(DateTime data) {
    if (this.situacao == (SituacaoEstagio) 0) {
      this.dataInicio = data;
      this.situacao = (SituacaoEstagio) 1;
      return true;
    } else {
      return false;
    }
  }
  public bool Cancelar(DateTime data) {
    if (this.situacao == (SituacaoEstagio) 1) {
      this.dataCancelamento = data;
      this.situacao = (SituacaoEstagio) 2;
      return true;
    } else {
      return false;
    }
  }
  public bool Finalizar(DateTime data) {
    if (this.situacao == (SituacaoEstagio) 1) {
      this.dataFim = data;
      this.situacao = (SituacaoEstagio) 3;
      return true;
    } else {
      return false;
    }
  }

  public TimeSpan TempoEstagio() {
    TimeSpan te = DateTime.Now.Subtract(this.dataInicio);
    if (this.situacao == (SituacaoEstagio) 2) te = this.dataCancelamento.Subtract(this.dataInicio);
    else if (this.situacao == (SituacaoEstagio) 3) te = this.dataFim.Subtract(this.dataInicio);
    return te;
  }

  public SituacaoEstagio Situacao() {
    return this.situacao;
  }

  public override string ToString() {
    return $"\n[Dados do estagiário]\nNome: {this.estagiario}\nEmpresa: {this.empresa}";
  }
  
}
public enum SituacaoEstagio : byte {
  Cadastrado = 0, Iniciado = 1,
  Cancelado = 2, Finalizado = 3
}

class UI {

  public static void Main() {

    Console.WriteLine("Digite o nome do estagiário:");
    string est = Console.ReadLine();
    Console.WriteLine("Digite o nome da empresa:");
    string emp = Console.ReadLine();
    Estagio e = new Estagio(est, emp);

    bool acao = true;
    while (acao == true) {
      Console.WriteLine("Digite a data da ação (YYYY/MM/DD):");
      DateTime dataAcao = DateTime.Parse(Console.ReadLine());
      Console.WriteLine("Qual ação deseja realizar?");
      Console.WriteLine("I: iniciar estágio, C: cancelar estágio, F: finalizar estágio.");
      string opc = Console.ReadLine();
      if (opc.ToUpper() == "I") {
        if (e.Iniciar(dataAcao)) Console.WriteLine("Estágio iniciado com sucesso!");
      } else if (opc.ToUpper() == "C") { 
        if (e.Cancelar(dataAcao)) { 
          Console.WriteLine("Estágio cancelado com sucesso!");
        } else {
          Console.WriteLine("Você não atende as condições necessárias para cancelar."); break;
        }
      } else if (opc.ToUpper() == "F") {
        if (e.Finalizar(dataAcao)) { 
          Console.WriteLine("Estágio finalizado com sucesso!");
        } else {
          Console.WriteLine("Você não atende as condições necessárias para cancelar."); break;
        }
      } else {
        Console.WriteLine("Erro na escolha da opção!");
        break;
      }
  
      int tempo = e.TempoEstagio().Days;
      SituacaoEstagio status = e.Situacao();
  
      Console.WriteLine(e.ToString());
      Console.WriteLine($"[Relatório do estágio]\nSituação: {status}\nTempo: {tempo} dias");

      if (status == (SituacaoEstagio) 2 || status == (SituacaoEstagio) 3) break;

      Console.WriteLine("\nDeseja fazer uma nova ação? S para Sim, N para Não.");
      string retry = Console.ReadLine();
      if (retry.ToUpper() == "S") {
        acao = true;
      } else if (retry.ToUpper() == "N") {
        acao = false;
      } else {
        Console.WriteLine("Erro na escolha da opção!");
        break;
      }
    }
    
  }
  
}