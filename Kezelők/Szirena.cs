using Katonai_vezerlokozpont.Vezérlők;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonai_vezerlokozpont.Kezelők
{
    public class Szirena : Kezelo
    {
        public Szirena(int top, int left, ConsoleColor color,Vezerlo vez) : base(top, left, color,vez)
        {
        }
        public override void Update()
        {
            if (vez.harciFok=="[-----]"||vez.raketaFok == "[-----]")
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Beep();
                    Console.SetCursorPosition(base.Left, base.Top);
                    Console.ForegroundColor = base.Color;
                    WriteBlinkingText("*", 500, true);
                    WriteBlinkingText("*", 500, false);
                    
                }
            }
                       
        }
        private static void WriteBlinkingText(string text, int delay, bool visible)
        {
            if (visible)
                Console.Write(text);
            else
                for (int i = 0; i < text.Length; i++)
                    Console.Write(" ");
            Console.CursorLeft -= text.Length;
            Thread.Sleep(delay);
        }
    }
}
