using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Pacman pac = new Pacman();
            Ghost g1 = new Ghost(), g2 = new Ghost(), g3 = new Ghost(), g4 = new Ghost();
            Maze m = new Maze();
            pac.Attach(g1);
            pac.Attach(g2);
            pac.Attach(g3);
            pac.Attach(g4);
            pac.Attach(m);

            while (pac.score < 1000)
            {
                for (int i = 0; i < 8; i++) pac.Comer();
                pac.ComerEnergia();
            }
        }
    }
}
