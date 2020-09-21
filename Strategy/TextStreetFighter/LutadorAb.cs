using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// Classe abstrata para definicao das classes de lutadores
    /// </summary>
    public abstract class LutadorAb
    {
        public IEstrategiaLuta EstrategiaAtual { get; set; }
        
        /// <summary>
        /// NOme do Lutador
        /// </summary>
        public String Nome { get; set; }
        
        /// <summary>
        /// Sexo do Lutador ('M', 'F', 'O')
        /// </summary>
        public char Sexo { get; set; }

        public void MandarSocoForte()
        {
            Console.WriteLine("{0} dando soco forte!", Nome);
        }

        public void MandarSocoFraco()
        {
            Console.WriteLine("{0} dando soco fraquin!", Nome);
        }

        public void MandarChuteForte()
        {
            Console.WriteLine("{0} chutando forte!", Nome);
        }

        public void MandarChuteFraco()
        {
            Console.WriteLine("{0} chutando fraquin!", Nome);
        }

        public abstract void MandarEsp1();

        public abstract void MandarEsp2();

        public void Defender()
        {
            Console.WriteLine("{0} defendendo!", Nome);
        }

        /// <summary>
        /// Metodo que repassa a responsabilidade de lutar para o objeto 
        /// atual de estrategia.
        /// </summary>
        public void Lutar()
        {
            EstrategiaAtual.Lutar(this);
        }
    }
}
