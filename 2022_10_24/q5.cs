using System;

class Cinema {

  private string dia, hora;
  private int h, m;
  private bool estudante;

  public void setDia(string dia) {
    this.dia = dia.ToUpper();
  }
  public void setHora(string hora) {
    this.hora = hora;
  }
  public void setHorario() {
    string[] hsep = hora.Split(":");
    this.h = int.Parse(hsep[0]);
    this.m = int.Parse(hsep[1]);
  }
  public void setEstudante(string x) {
    if (x == "S")
      this.estudante = true;
    else
      this.estudante = false;
  }

  public int verifDia() {
    if (dia == "SEGUNDA" || dia == "TERÇA" || dia == "QUINTA")
      return 1;
    else if (dia == "SEXTA" || dia == "SÁBADO" || dia == "DOMINGO")
      return 2;
    else
      return 3;
  }
  public bool verifHorario() {
    if ((h >= 17 && h <= 23 && m >= 0 && m <= 59) || (h == 0 && m == 0))
      return true;
    else
      return false;
  }
  
  public double valorIngresso() {
    if (verifDia() == 3)
      return 8;
    
    if (verifHorario()) {
      if (estudante) {
        if (verifDia() == 1)
          return (16 * 1.5) / 2;
        else
          return (20 * 1.5) / 2;
      } else {
        if (verifDia() == 1)
          return 16 * 1.5;
        else
          return 20 * 1.5;
      }
    } else {
      if (estudante) {
        if (verifDia() == 1)
          return 16 / 2;
        else
          return 20 / 2;
      } else {
        if (verifDia() == 1)
          return 16;
        else
          return 20;
      }
    }
  }
  
}

class Cliente {

  public static void Main() {

    Cinema c = new Cinema();
    Console.WriteLine("Digite o dia da sessão:");
    c.setDia(Console.ReadLine());
    Console.WriteLine("Digite o horário da sessão (HH:MM):");
    c.setHora(Console.ReadLine());
    c.setHorario();
    Console.WriteLine("Você é estudante? Digite S para Sim ou N para Não.");
    c.setEstudante(Console.ReadLine());
    double valor = c.valorIngresso();
    Console.WriteLine($"O valor do seu ingresso é R$ {valor:0.00}.");
    
  }
  
}