using System;

class PecaDomino {

  private int ladoEsq, ladoDir;

  public PecaDomino(int ladoEsq, int ladoDir) {
    this.SetLadoEsq(ladoEsq);
    this.SetLadoDir(ladoDir);
  }

  public void SetLadoEsq(int ladoEsq) {
    if (ladoEsq >= 1 && ladoEsq <= 6)
      this.ladoEsq = ladoEsq;
  }
  public void SetLadoDir(int ladoDir) {
    if (ladoDir >= 1 && ladoDir <= 6)
      this.ladoDir = ladoDir;
  }

  public int GetLadoEsq() {
    return this.ladoEsq;
  }
  public int GetLadoDir() {
    return this.ladoDir;
  }

  public override string ToString() {
    return $"Sua peça de dominó possui lados {this.ladoEsq} e {this.ladoDir}.";
  }

  public bool Combinar(PecaDomino pd) {
    if (this.ladoEsq == pd.GetLadoEsq() || this.ladoEsq == pd.GetLadoDir() || this.ladoDir == pd.GetLadoEsq() || this.ladoDir == pd.GetLadoDir())
      return true;
    else
      return false;
  }
  
}

class UI {

  public static void Main() {
    Console.WriteLine("Escreva os dois valores da primeira peça:");
    string[] l1 = Console.ReadLine().Split();
    int le1 = int.Parse(l1[0]);
    int ld1 = int.Parse(l1[1]);
    PecaDomino peca1 = new PecaDomino(le1, ld1);

    Console.WriteLine("Escreva os dois valores da segunda peça:");
    string[] l2 = Console.ReadLine().Split();
    int le2 = int.Parse(l2[0]);
    int ld2 = int.Parse(l2[1]);
    PecaDomino peca2 = new PecaDomino(le2, ld2);

    if(peca1.Combinar(peca2))
      Console.WriteLine("As peças combinam!");
    else
      Console.WriteLine("As peças não combinam...");
  }
  
}