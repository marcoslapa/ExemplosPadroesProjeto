using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class HumanFactory : CharacterClassFactoryAb
    {
        public override PersonagemMagico CriarMagico()
        {
            throw new NotImplementedException();
        }

        public override PersonagemMitico CriarMitico()
        {
            throw new NotImplementedException();
        }

        public override PersonagemSimples CriarSimples()
        {
            return new Soldado();
        }

        public override PersonagemSimplesAtirador CriarSimplesAtirador()
        {
            return new Arqueiro();
        }
    }
}
