using System;

class POO {

  public static void Main() {
    Console.WriteLine("Escreva um texto:");
    string text = Console.ReadLine();
    string formTxt = FormatarTexto(text);
    Console.WriteLine("Texto formatado:");
    Console.WriteLine(formTxt);
  }

  public static string FormatarTexto(string texto) {
    char espaço = ' ';
    string novoTxt = String.Join(" ", texto.Split(espaço, StringSplitOptions.RemoveEmptyEntries));
    return novoTxt;
  }
  
}