using System;
using TemplateMethod.TemplateMethodDP;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite largura da casinha!");
            double largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite comprimento da casinha!");
            double comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escolha o tipo da casinha:\n 1: Tijolo\n 2: Madeira\n 3: Vidro");
            int tipo = Convert.ToInt32(Console.ReadLine());

            CasinhaAb c;

            switch (tipo)
            {
                case 1:
                    c = new CasinhaTijolo();
                    break;
                case 2:
                    c = new CasinhaMadeira();
                    break;
                default:
                    c = new CasinhaVidro();
                    break;
            }
            
            // Chamando o TemplateMethod!
            c.Criar(largura, comprimento);
        }
    }
}
