using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class EsqueletoArqueiro : PersonagemSimplesAtirador
    {
        public override void Atirar()
        {
            Console.Write("Esqueleto Arqueiro mandando flecha!");
        }
    }
}
