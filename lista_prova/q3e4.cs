using System;

class CartaBaralho {

  private string naipe;
  private int valor;

  public CartaBaralho(string naipe, int valor) {
    this.SetNaipe(naipe);
    this.SetValor(valor);
  }

  public void SetNaipe(string naipe) {
    if (naipe == "ouro" || naipe == "copas" || naipe == "espada" || naipe == "paus")
      this.naipe = naipe;
  }
  public void SetValor(int valor) {
    if (valor >= 1 && valor <= 13)
      this.valor = valor;
  }

  public string GetNaipe() {
    return this.naipe;
  }
  public int GetValor() {
    return this.valor;
  }

  public override string ToString() {
    return $"Naipe: {this.naipe}.\nValor: {this.valor}.";
  }

  public bool CartasIguais(CartaBaralho carta) {
    if (this.naipe == carta.GetNaipe() && this.valor == carta.GetValor())
      return true;
    else
      return false;
  }
}

class UI {

  public static void Main() {

    Console.WriteLine("Digite o naipe da 1ª carta:");
    string naipe1 = Console.ReadLine().ToLower();
    Console.WriteLine("Digite o valor da 1ª carta:");
    int valor1 = int.Parse(Console.ReadLine());
    CartaBaralho carta1 = new CartaBaralho(naipe1, valor1);
    
    Console.WriteLine("Digite o naipe da 2ª carta:");
    string naipe2 = Console.ReadLine().ToLower();
    Console.WriteLine("Digite o valor da 2ª carta:");
    int valor2 = int.Parse(Console.ReadLine());
    CartaBaralho carta2 = new CartaBaralho(naipe2, valor2);

    if (carta1.CartasIguais(carta2))
      Console.WriteLine("As cartas são iguais.");
    else
      Console.WriteLine("As cartas não são iguais.");
    
  }
  
}