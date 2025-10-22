using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonai_vezerlokozpont.Kezelők.Adapter
{
    public class ParancsnoksagiFelugyelet
    {
        public void HarciAllapotAktivalva()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, 0);
            Console.Write("Figyelem, ÉLES HARCI ÁLLAPOT aktiválva! ");
        }
        public void HarciAllapotDeaktivalva()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 0);
            Console.Write("Figyelem, ÉLES HARCI ÁLLAPOT vége! ! ");
        }
    }
}

