using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Esqueleto : PersonagemSimples
    {
        public override void Bater()
        {
            Console.WriteLine("Esqueleto batendo!!!");
        }
    }
}
