using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.TemplateMethodDP
{
    public class CasinhaTijolo : CasinhaAb
    {
        protected override void CriarJanelas()
        {
            Console.WriteLine("Criando janelas da {0}!", this);
        }

        protected override void CriarParedes()
        {
            Console.WriteLine("Criando paredes de Tijolo!");
        }

        protected override void CriarPilares()
        {
            Console.WriteLine("Criando pilares de concreto!");
        }

        protected override void CriarTelhado()
        {
            Console.WriteLine("Criando telhado comum da {0}!", this);
        }

        public override string ToString()
        {
            return "Casa de Tijolo";
        }
    }
}
