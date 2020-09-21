using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Dalsin : LutadorAb
    {
        public Dalsin()
        {
            Nome = "Dalsin Ioga Man";
            Sexo = 'M';
        }

        public override void MandarEsp1()
        {
            Console.WriteLine("Ioga fire!!!");
        }

        public override void MandarEsp2()
        {
            Console.WriteLine("Ioga flame!!!");
        }
    }
}
