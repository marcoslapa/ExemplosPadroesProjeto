using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ChunLi : LutadorAb
    {
        public ChunLi()
        {
            Nome = "ChunLi";
            Sexo = 'F';
        }

        public override void MandarEsp1()
        {
            Console.WriteLine("Minitaxi!!!");
        }

        public override void MandarEsp2()
        {
            Console.WriteLine("Kikikikikikikiki!!!");
        }
    }
}
