using System;

class Data {

  private int dia, mes, ano;

  public Data(int dia, int mes, int ano) {
    this.SetData(dia, mes, ano);
  }
  public Data(string data) {
    string[] sep = data.Split("/");
    int d = int.Parse(sep[0]);
    int m = int.Parse(sep[1]);
    int a = int.Parse(sep[2]);
    this.SetData(d, m, a);
  }

  public void SetData(int dia, int mes, int ano) {
    bool valid = false;
    if (dia <= 28 && mes == 2) {
      valid = true;
    } else if (dia <= 31 && (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)) {
      valid = true;
    } else if (dia <= 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) {
      valid = true;
    }
    if (valid) {
      this.dia = dia;
      this.mes = mes;
      this.ano = ano;
    }
  }

  public int GetDia() {
    return this.dia;
  }
  public int GetMes() {
    return this.mes;
  }
  public int GetAno() {
    return this.ano;
  }

  public override string ToString() {
    return $"Data: {this.dia:D2}/{this.mes:D2}/{this.ano:D4}";
  }
  
}

class UI {

  public static void Main() {
    Console.WriteLine("Digite a data:");
    string data = Console.ReadLine();
    Data t = new Data(data);
    Console.WriteLine(t.ToString());
  }
  
}