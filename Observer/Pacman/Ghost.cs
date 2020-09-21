using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public enum GhostStates
    {
        Hunting,
        Running
    }

    // Concrete Observer
    public class Ghost : PacmanObserverAb
    {
        public GhostStates State
        {
            get; set;
        }

        public override void Update(PacmanStates newState)
        {
            if (newState == PacmanStates.Vunerable)
                this.State = GhostStates.Hunting;
            else
                this.State = GhostStates.Running;

            Console.WriteLine("Olá, sou o Ghost {0}! ==> Agora estou {1}!", this.GetHashCode().ToString(), this.State == GhostStates.Hunting ? "Caçando" : "Fugindo");
        }
    }
}
