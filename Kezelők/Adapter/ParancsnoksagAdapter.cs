using Katonai_vezerlokozpont.Vezérlők;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonai_vezerlokozpont.Kezelők.Adapter
{
    public class ParancsnoksagAdapter : Kezelo
    {
        private readonly ParancsnoksagiFelugyelet felugyelet=new();
        public ParancsnoksagAdapter(int top, int left, ConsoleColor color, Vezerlo vezerlo) : base(top, left, color, vezerlo)
        {
            felugyelet = new ParancsnoksagiFelugyelet();
        }

        public override void Update()
        {
            felugyelet.HarciAllapotDeaktivalva();

            if (vez.harciFok == "[!!!!!]")
            {
                felugyelet.HarciAllapotAktivalva();
            }
            
        }
    }
}
