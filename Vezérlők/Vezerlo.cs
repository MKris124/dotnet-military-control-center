using Katonai_vezerlokozpont.Kezelők;
using Katonai_vezerlokozpont.Observer;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Katonai_vezerlokozpont.Vezérlők.Vezerlo;

namespace Katonai_vezerlokozpont.Vezérlők
{
    public class Vezerlo : Subject
    {
        private readonly List<string> RaketaNaplo= new();
        private readonly List<string> HarciNaplo = new();
        public string raketaFok { get; set; } = "";
        public string harciFok { get; set; } = "";

        public enum Fokozatok {  Alap, 
                                 Éles, 
                                Készültség }
        public void Raketa(Fokozatok fokozatok,string fokozat)
        {
            raketaFok = "";
            Notify();          
            raketaFok = fokozat;
            Notify();
            if (fokozatok == Fokozatok.Éles)
            {
                RaketaNaplo.Add($"{DateTime.Now} - RakétaFokozat: {fokozatok}");
                for (int i = 0; i < 5; i++)
                {
                    Notify();
                    Thread.Sleep(1000);
                }
                raketaFok = "[-----]";
                Notify();
                fokozatok = Fokozatok.Készültség;
                
            }
            RaketaNaplo.Add($"{DateTime.Now} - RakétaFokozat: {fokozatok}");
            
            
        }
        public void Harckeszultseg(Fokozatok fokozatok,string fokozat)
        {
            harciFok = "";
            Notify();              
            harciFok = fokozat;
            Notify();
            if (fokozatok == Fokozatok.Éles)
            {
                HarciNaplo.Add($"{DateTime.Now} - HarciFokozat: {fokozatok}");
                for (int i = 0; i < 5; i++)
                {
                    Notify();
                    Thread.Sleep(1000);
                }
                harciFok = "[-----]";
                Notify();
                fokozatok = Fokozatok.Készültség;               
            }
            HarciNaplo.Add($"{DateTime.Now} - HarciFokozat: {fokozatok}");

        }
        public void Veszhelyzet() 
        {
            harciFok = "[!!!!!]";
            Notify();
            raketaFok = "[!!!!!]";
            Notify();
            HarciNaplo.Add($"{DateTime.Now} - HarciFokozat: {Fokozatok.Éles}");
            RaketaNaplo.Add($"{DateTime.Now} - RakétaFokozat: {Fokozatok.Éles}");
            for (int i = 0; i < 5; i++)
            {
                Notify();
                Thread.Sleep(1000);
            }
            harciFok = "[-----]";
            Notify();
            raketaFok = "[-----]";
            Notify();
            HarciNaplo.Add($"{DateTime.Now} - HarciFokozat: {Fokozatok.Készültség}");
            RaketaNaplo.Add($"{DateTime.Now} - RakétaFokozat: {Fokozatok.Készültség}");
        }
        public void RaketaNaploList() 
        {
            Console.WriteLine("\n");
            foreach (var item in RaketaNaplo)
            {
                Console.WriteLine(item);
            }
        }
        public void HarciNaploList()
        {
            Console.WriteLine("\n");
            foreach (var item in HarciNaplo)
            {
                Console.WriteLine(item);
            }
        }

    }
}
