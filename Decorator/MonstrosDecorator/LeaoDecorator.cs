using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.MonstrosDecorator
{
    public class LeaoDecorator : MonstroDecorator
    {
        public override void Atacar()
        {
            this.MonstroComp.Atacar();
            Console.WriteLine("Aplicando a Mordida Feroz!!!!!!!");
        }
    }
}
