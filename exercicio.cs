using System; 
using System.Linq;
using System.Collections.Generic;

class URI {
    static void Main(string[] args) {
        
        int quantidade = int.Parse(Console.ReadLine());

        List<int> par = new List<int>();
        List<int> impar = new List<int>();

         for (int i = 0; i < quantidade; i++)
         {
             int valor = int.Parse(Console.ReadLine());
             if(valor % 2 == 0)
             {
                 par.Add(valor);
             }
             else
             {
                 impar.Add(valor);
             }
         }  
          par.Sort();
          impar.Sort();
          impar.Reverse();
          foreach( var p in par)
          {
              Console.WriteLine(p);
          }
            foreach( var i in impar)
            {
                Console.WriteLine(i);
            }
    }
}