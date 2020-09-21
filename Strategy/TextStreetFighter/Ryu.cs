using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Ryu : LutadorAb
    {
        public Ryu()
        {
            Nome = "Ryu da Bahia";
            Sexo = 'M';
        }

        public override void MandarEsp1()
        {
            Console.WriteLine("Hadoouuuuken!!!");
        }

        public override void MandarEsp2()
        {
            Console.WriteLine("Tratrektrekiruuuguem!!!");
        }
    }
}
