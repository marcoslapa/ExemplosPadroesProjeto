using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.TemplateMethodDP
{
    public class CasinhaMadeira : CasinhaAb
    {
        protected override void CriarJanelas()
        {
            Console.WriteLine("Criando janelas de madeira!");
        }

        protected override void CriarParedes()
        {
            Console.WriteLine("Criando paredes de madeira!");
        }

        protected override void CriarPilares()
        {
            Console.WriteLine("Criando pilares de madeira!");
        }

        protected override void CriarTelhado()
        {
            Console.WriteLine("Criando telhado comum da {0}!", this);
        }

        public override string ToString()
        {
            return "Casa de Madeira";
        }
    }
}
