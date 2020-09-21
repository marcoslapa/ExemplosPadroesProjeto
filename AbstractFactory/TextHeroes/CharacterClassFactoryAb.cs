using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class CharacterClassFactoryAb
    {
        public abstract PersonagemSimples CriarSimples();
        public abstract PersonagemSimplesAtirador CriarSimplesAtirador();
        public abstract PersonagemMagico CriarMagico();
        public abstract PersonagemMitico CriarMitico();

    }
}
