using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.MonstrosDecorator
{
    public class DragaoDecorator : MonstroDecorator
    {
        public override void Atacar()
        {
            this.MonstroComp.Atacar();
            Console.WriteLine("Cuspindo Fogo!!!!");
        }
    }
}
