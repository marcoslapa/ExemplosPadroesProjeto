using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.MonstrosDecorator
{
    // Decorator
    public class MonstroDecorator : MonstroAb
    {
        public MonstroAb MonstroComp { get; set; }

        public override void Atacar()
        {
            this.MonstroComp.Atacar();
        }
    }
}
