using System;

class Estagiario {

  private string nome = "?", cpf = "?", telefone = "?";
  private Dias dias;
  private Turno turno;

  public Estagiario(string n, string c, string t) {
    if (String.IsNullOrEmpty(n) == false) this.nome = n;
    if (String.IsNullOrEmpty(c) == false) this.cpf = c;
    if (String.IsNullOrEmpty(t) == false) this.telefone = t;
  }

  public void SetDias(Dias d) {
    this.dias = d;
  }
  public void SetTurno(Turno t) {
    this.turno = t;
  }

  public Dias GetDias() {
    return this.dias;
  }
  public Turno GetTurno() {
    return this.turno;
  }

  public override string ToString() {
    return $"[Dados do estagiário]\nNome: {this.nome}\nCPF: {this.cpf}\nTelefone: {this.telefone}";
  }
  
}
[Flags]
public enum Dias {
  Segunda = 1,
  Terça = 2,
  Quarta = 4,
  Quinta = 8,
  Sexta = 16
}
[Flags]
public enum Turno {
  Matutino = 0, Vespertino = 1, Noturno = 2
}

class UI {

  public static void Main() {

    Console.WriteLine("Digite o seu nome:");
    string nome = Console.ReadLine();
    Console.WriteLine("Digite o seu CPF:");
    string cpf = Console.ReadLine();
    Console.WriteLine("Digite o seu telefone:");
    string tel = Console.ReadLine();
    Estagiario e = new Estagiario(nome, cpf, tel);

    Console.WriteLine("Digite os dias que tem disponibilidade, separados por espaço:");
    string[] dias = Console.ReadLine().Split();
    int countDias = 0;
    foreach (string n in dias) {
      if (n.ToUpper() == "SEGUNDA") countDias += 1;
      else if (n.ToUpper() == "TERÇA") countDias += 2;
      else if (n.ToUpper() == "QUARTA") countDias += 4;
      else if (n.ToUpper() == "QUINTA") countDias += 8;
      else if (n.ToUpper() == "SEXTA") countDias += 16;
    }
    Dias d = (Dias) countDias;
    e.SetDias(d);

    Console.WriteLine("Digite o turno que tem disponibilidade (matutino, vespertino ou noturno):");
    string turno = Console.ReadLine();
    int countTurno = 0;
    if (turno.ToUpper() == "MATUTINO") countTurno = 0;
    else if (turno.ToUpper() == "VESPERTINO") countTurno = 1;
    else if (turno.ToUpper() == "NOTURNO") countTurno = 2;
    Turno t = (Turno) countTurno;
    e.SetTurno(t);

    Console.WriteLine(e.ToString());
    Console.WriteLine($"[Horários]\nDias: {e.GetDias()}\nTurno: {e.GetTurno()}");
    
    }

}