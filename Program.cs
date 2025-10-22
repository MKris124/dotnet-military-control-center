using Katonai_vezerlokozpont.Kezelők;
using Katonai_vezerlokozpont.Kezelők.Adapter;
using Katonai_vezerlokozpont.Vezérlők;
using Katonai_vezerlokozpont.Kezelők.Feliratok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonai_vezerlokozpont
{
    public class Program
    {
        public static void Main(string[]args)
        {
            Vezerlo vezerlo = new();
            Console.WriteLine("\nRakétakilövő állapota:");
            Console.WriteLine("Harci készültség állapota:");

            //alap állapot
            var fr1 = new RaketaFelirat(1, 27, ConsoleColor.White, vezerlo);
            var fh1 = new HarciFelirat(2, 27, ConsoleColor.White, vezerlo);
            vezerlo.Raketa(Vezerlo.Fokozatok.Alap, "[     ]");
            vezerlo.Harckeszultseg(Vezerlo.Fokozatok.Alap, "[     ]");

            Thread.Sleep(2000);

            #region készenléti állapot
            var fr2 = new RaketaFelirat(1, 27, ConsoleColor.Yellow, vezerlo);
            var fh2 = new HarciFelirat(2, 27, ConsoleColor.Yellow, vezerlo);
            vezerlo.Raketa(Vezerlo.Fokozatok.Készültség, "[-----]");
            vezerlo.Harckeszultseg(Vezerlo.Fokozatok.Készültség, "[-----]");

            #region Rakéta szimuláció
            var szirena1 = new Szirena(1, 35, ConsoleColor.Red, vezerlo);
            var fr3 = new RaketaFelirat(1, 27, ConsoleColor.Red, vezerlo);
            
            vezerlo.Detach(szirena1);
            vezerlo.Raketa(Vezerlo.Fokozatok.Éles, "[!!!!!]");
            var fr4 = new RaketaFelirat(1, 27, ConsoleColor.Yellow, vezerlo);
            #endregion

            #region Harci állapot szimuláció
            var szirena2 = new Szirena(2, 35, ConsoleColor.Red, vezerlo);
            var fh3 = new HarciFelirat(2, 27, ConsoleColor.Red, vezerlo);
            vezerlo.Detach(szirena2);

            var adapter = new ParancsnoksagAdapter(0, 0, ConsoleColor.White, vezerlo);
            vezerlo.Harckeszultseg(Vezerlo.Fokozatok.Éles, "[!!!!!]");
            var fh4 = new HarciFelirat(2, 27, ConsoleColor.Yellow, vezerlo);
            #endregion*/
            #endregion
            #region Vészhelyzet
           /* 
            var adapter = new ParancsnoksagAdapter(0, 0, ConsoleColor.White, vezerlo);
            var fr3 = new RaketaFelirat(1, 27, ConsoleColor.Red, vezerlo);
            var fh3 = new HarciFelirat(2, 27, ConsoleColor.Red, vezerlo);
            vezerlo.Veszhelyzet();
            var fr = new RaketaFelirat(1, 27, ConsoleColor.Yellow, vezerlo);
            var fh4 = new HarciFelirat(2, 27, ConsoleColor.Yellow, vezerlo);
            */
            #endregion
            //Naplók kiírása
            vezerlo.HarciNaploList();
            vezerlo.RaketaNaploList();

        }
        
    }
}
