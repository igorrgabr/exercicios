using System; 

class URI {

    static void Main(string[] args) { 

      while (true) {
        string frase;
        frase = Console.ReadLine();
        bool error = false;
        
        if (frase == "*")
          break;

        string[] palavras = frase.Split();
        
        for (int i = 0; i < palavras.Length; i++) {
          for (int j = i + 1; j < palavras.Length; j++) {
            string l1 = palavras[i].Substring(0,1).ToUpper();
            string l2 = palavras[j].Substring(0,1).ToUpper();
            if (l1 != l2) {
              error = true;
              break;
            }
          }
        }
        
        if (error)
          Console.WriteLine("N");
        else
          Console.WriteLine("Y");
        
      }
    }
}