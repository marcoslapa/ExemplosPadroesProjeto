using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Blanka : LutadorAb
    {

        public Blanka()
        {
            Nome = "BLanka";
            Sexo = 'O';
        }

        public override void MandarEsp1()
        {
            Console.WriteLine("Tzzztzzztzzzzz!!!");
        }

        public override void MandarEsp2()
        {
            Console.WriteLine("Rooaaaarrrrrrrrr!!!");
        }
    }
}
