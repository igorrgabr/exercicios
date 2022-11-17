using System;

class BankAccount {

  public string name, accountNumber;
  public double balance;
  
  public double Deposit(double num) {
    return balance + num;
  }

  public bool isValid(double num) {
    if (num < balance)
      return true;
    else
      return false;
  }

  public double Withdraw(double num) {
    return balance - num;
  }
  
}

class Cliente {

  public static void Main() {
    double saldo;

    BankAccount b = new BankAccount();
    Console.WriteLine("Digite o seu nome:");
    b.name = Console.ReadLine();
    Console.WriteLine("Digite o número da sua conta:");
    b.accountNumber = Console.ReadLine();
    Console.WriteLine("Digite o seu saldo:");
    b.balance = double.Parse(Console.ReadLine());

    Console.WriteLine("Qual operação deseja realizar? (S para Saque, D para depósito):");
    string op = Console.ReadLine();
    if (op == "S") {
      Console.WriteLine("Digite o valor do saque:");
      double s = double.Parse(Console.ReadLine());
      if (b.isValid(s)) {
        saldo = b.Withdraw(s);
        Console.WriteLine($"Você sacou R$ {s:0.00} com sucesso.");
        Console.WriteLine($"Saldo atual: R$ {saldo:0.00}.");
      } else {
        Console.WriteLine("Erro! Valor solicitado maior do que o saldo em conta.");
      }
    } else if (op == "D") {
      Console.WriteLine("Digite o valor do depósito:");
      double d = double.Parse(Console.ReadLine());
      saldo = b.Deposit(d);
      Console.WriteLine($"Você depositou R$ {d:0.00} com sucesso.");
      Console.WriteLine($"Saldo atual: R$ {saldo:0.00}.");
    } else {
      Console.WriteLine("Erro! Operação não identificada.");
    }
    
  }
  
}