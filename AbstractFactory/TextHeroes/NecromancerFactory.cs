using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class NecromancerFactory : CharacterClassFactoryAb
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
            return new Esqueleto();
        }

        public override PersonagemSimplesAtirador CriarSimplesAtirador()
        {
            return new EsqueletoArqueiro();
        }
    }
}
