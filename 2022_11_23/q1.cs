using System;

class Paciente {

  private string nome = "?", cpf = "?", telefone = "?";
  private DateTime nascimento;

  public Paciente(string n, string c, string t, DateTime nasc) {
    if (String.IsNullOrEmpty(n) != true) this.nome = n;
    if (String.IsNullOrEmpty(c) != true) this.cpf = c;
    if (String.IsNullOrEmpty(t) != true) this.telefone = t;
    this.nascimento = nasc;
  }

  public string Idade() {
    DateTime hoje = DateTime.Now;
    TimeSpan dif = hoje.Subtract(nascimento);
    int a = (int) dif.TotalDays / 365;
    int m = (int) (dif.TotalDays % 365) / 30;
    return $"O paciente tem {a} anos e {m} meses.";
  }

  public override string ToString() {
    return $"Nome: {this.nome}\nCPF: {this.cpf}\nTelefone: {this.telefone}\nNascimento: {this.nascimento:dd/MM/yyyy}";
  }
  
}

class UI {

  public static void Main() {
    Console.WriteLine("Digite o nome do paciente:");
    string n = Console.ReadLine();
    Console.WriteLine("Digite o CPF do paciente:");
    string c = Console.ReadLine();
    Console.WriteLine("Digite o telefone do paciente:");
    string t = Console.ReadLine();
    Console.WriteLine("Digite a data de nascimento do paciente (YYYY/MM/DD):");
    DateTime nasc = DateTime.Parse(Console.ReadLine());
    Paciente p = new Paciente(n, c, t, nasc);
    Console.WriteLine("[Ficha do paciente]");
    Console.WriteLine(p.ToString());
    Console.WriteLine(p.Idade());
  }
  
}