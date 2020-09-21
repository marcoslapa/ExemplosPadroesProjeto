using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    // Subject
    public class PacmanAb
    {
        List<PacmanObserverAb> observers = new List<PacmanObserverAb>();
        protected PacmanStates state;
        public PacmanStates State
        {
            get
            {
                return state;
            }
        }

        public void Attach(PacmanObserverAb obs)
        {
            observers.Add(obs);
        }

        public void NotifyAll()
        {
            foreach(PacmanObserverAb o in observers)
            {
                o.Update(this.State);
            }
        }
    }
}
