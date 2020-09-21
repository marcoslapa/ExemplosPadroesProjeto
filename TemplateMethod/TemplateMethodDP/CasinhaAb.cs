using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.TemplateMethodDP
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class CasinhaAb
    {
        /// <summary>
        /// Template Method para criacao de casas
        /// </summary>
        /// <param name="l">Largura da casa</param>
        /// <param name="c">Comprimento da casa</param>
        public void Criar(double l, double c)
        {
            // Criar Fundacao
            Console.WriteLine("Passo 1:");
            Console.WriteLine("Criando fundacao para uma {0} de {1}m2", this, (l*c));

            Console.WriteLine("Passo 2:");
            CriarPilares();

            Console.WriteLine("Passo 3:");
            CriarParedes();

            Console.WriteLine("Passo 4:");
            CriarTelhado();

            Console.WriteLine("Passo 5:");
            CriarJanelas();
        }

        protected abstract void CriarParedes();
        protected abstract void CriarPilares();
        protected abstract void CriarJanelas();
        protected abstract void CriarTelhado();
    }
}
