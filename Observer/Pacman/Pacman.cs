using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public enum PacmanStates
    {
        Vunerable,
        Powerful
    }

    //Concrete Subject
    public class Pacman : PacmanAb
    {
        public Pacman()
        {
            state = PacmanStates.Vunerable;
            //NotifyAll();
        }

        public int score = 0;

        public void Comer()
        {
            if (score % 10 == 0)
            {
                this.state = PacmanStates.Vunerable;
                NotifyAll();
            }
            score++;

            Console.WriteLine("Comi + 1");
            Console.WriteLine("Total: {0}", score);
        }

        public void ComerEnergia()
        {
            score += 100;
            state = PacmanStates.Powerful;
            Console.WriteLine("Comi ENERGIA");
            Console.WriteLine("Total: {0}", score);
            NotifyAll();
        }
    }
}
