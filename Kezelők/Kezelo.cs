using Katonai_vezerlokozpont.Observer;
using Katonai_vezerlokozpont.Vezérlők;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonai_vezerlokozpont.Kezelők
{
    public class Kezelo:IObserver
    {
        public int Top{ get; set; }
        public int Left { get; set; }
        public ConsoleColor Color { get; set; }
        protected readonly Vezerlo vez;
        public Kezelo(int top, int left, ConsoleColor color, Vezerlo vezerlo)
        {          
            Top = top;
            Left = left;
            Color = color;
            vez = vezerlo;
            vez.Attach(this);
            Update();
        }

        public virtual void Update()
        {
        }
    }
}
