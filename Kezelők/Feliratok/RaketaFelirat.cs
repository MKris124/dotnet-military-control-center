using Katonai_vezerlokozpont.Vezérlők;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonai_vezerlokozpont.Kezelők.Feliratok
{
    public class RaketaFelirat : Kezelo
    {
        public RaketaFelirat(int top, int left, ConsoleColor color, Vezerlo vez) : base(top, left, color, vez)
        {
        }
        public override void Update()
        {
            Console.SetCursorPosition(base.Left, base.Top);
            Console.ForegroundColor = base.Color;
            Console.WriteLine(vez.raketaFok);
        }
    }
}
