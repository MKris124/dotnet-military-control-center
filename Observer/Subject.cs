using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonai_vezerlokozpont.Observer
{
    public class Subject
    {
        private readonly List<IObserver> observers = new();
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }
        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }
        protected void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
