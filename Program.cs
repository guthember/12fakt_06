using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megszamlalas
{
  class Program
  {
    static void Main(string[] args)
    {
      // Random vel = new Random(); ez is tökéletesen jó!
      Random vel = new Random(Guid.NewGuid().GetHashCode());
      // 10 elemű egészeket tartalmazó tömb
      int[] tomb = new int[10]; // 0..9 indexek

      // tömb feltöltése
      for (int i = 0; i < tomb.Length; i++)
      {
        tomb[i] = vel.Next(1, 101); // [1..100]
        Console.WriteLine("{0}. indexű eleme: {1}", i, tomb[i]);
      }

      // Egy feltételnek megfelelő elemek száma
      // Hány 50 feletti érték van? (sok elem vizsgálata -> egy értéket ad vissza)
      int db = 0; // számláló, induló érték

      // Megszámolás
      for (int i = 0; i < tomb.Length; i++)
      {
        if (tomb[i] > 50)
        {
          db++;
        }
      }

      Console.WriteLine("\n50-nél nagyobb elemek darabszáma: {0}",db);

      Console.ReadLine(); // "Enter"-ig vár
    }
  }
}
