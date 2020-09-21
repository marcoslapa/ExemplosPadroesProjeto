using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Maze : PacmanObserverAb
    {
        public override void Update(PacmanStates newState)
        {
            if(newState == PacmanStates.Powerful)
            {
                Console.WriteLine("********************** Labirinto PISCANDO!!!!!***********************");
            }
            else
            {
                Console.WriteLine("********************** Labirinto NORMAL!!!!!***********************");
            }
        }
    }
}
