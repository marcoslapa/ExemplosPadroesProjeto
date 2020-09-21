using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jogadorVenceu = false;
            Console.WriteLine(@"Escolha o lutador(a): 
            1 - ChunLi, 
            2 - Dalsin, 
            3 - Ryu
            4 - Blanka");
            int op = Convert.ToInt32(Console.ReadLine());

            LutadorAb lut;

            switch (op)
            {
                case 1:
                    lut = new ChunLi();
                    break;
                case 2:
                    lut = new Dalsin();
                    break;
                case 3:
                    lut = new Ryu();
                    break;
                default:
                    lut = new Blanka();
                    break;
            }

            Console.WriteLine("Round 1 Fight!!!");
            lut.EstrategiaAtual = new EstrategiaManeh();
            lut.Lutar();

            jogadorVenceu = ObterVencedor();

            bool foiPerfect = false;
            if (jogadorVenceu && foiPerfect)
            {
                lut.EstrategiaAtual = new EstrategiaViradoNaDesgraca();
            }
            else if (jogadorVenceu)
            {
                lut.EstrategiaAtual = new EstrategiaRetadoa();
            }

            Console.WriteLine("Round 2 Fight!!!");
            lut.Lutar();

        }

        private static bool ObterVencedor()
        {
            return true;
        }

    }
}
