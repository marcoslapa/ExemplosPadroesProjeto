using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.TemplateMethodDP
{
    public class CasinhaVidro : CasinhaAb
    {
        protected override void CriarJanelas()
        {
            Console.WriteLine("Criando janelas de vidro!");
        }

        protected override void CriarParedes()
        {
            Console.WriteLine("Criando paredes de vidro!");
        }

        protected override void CriarPilares()
        {
            Console.WriteLine("Criando pilares para a {0}!", this);
        }

        protected override void CriarTelhado()
        {
            Console.WriteLine("Criando telhado comum da {0}!", this);
        }

        public override string ToString()
        {
            return "Casa de Vidro";
        }

    }
}
