using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.MonstrosDecorator
{
    // ConcreteComponent
    public class MonstroRPG : MonstroAb
    {
        public override void Atacar()
        {
            Console.WriteLine("Ataque simples do Monstro!!!");
        }
    }
}
