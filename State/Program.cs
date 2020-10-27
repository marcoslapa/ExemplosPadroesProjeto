using State.PadraoState;
using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaRefri m = new MaquinaRefri();

            ExecutarMaquina(m);
        }

        private static void ExecutarMaquina(MaquinaRefri m)
        {
            Console.Clear();
            Console.WriteLine($"{m.Refris} refris em estoque!");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1: Adicionar Refri");
            Console.WriteLine("2: Comprar Refri");
            Console.WriteLine("3: Ver saldo de vendas");

            string op = Console.ReadLine();

            if (op == "1")
            {
                Console.WriteLine("Quantos refris deseja adicionar?");
                int quant = Convert.ToInt32(Console.ReadLine());
                m.AdicionarRefri(quant);
                Console.ReadKey();
                ExecutarMaquina(m);
            }
            else if (op == "2") // Comprar Refri
            {
                // Só pode comprar se houver refri
                if(m.EstadoAtual is SemRefri)
                {
                    Console.WriteLine("Máquina não possui Refri para vender! Pressione qualquer tecla para voltar às opções...");
                    Console.ReadKey();
                    ExecutarMaquina(m);
                }
                m.AdicionarCredito();
                Console.ReadKey();
                Console.Clear();
                m.SolicitarRefri();
                Console.ReadKey();
                ExecutarMaquina(m);
            }
            else
            {
                Console.WriteLine("Saldo Total: {0}", m.SaldoTotal);
                Console.WriteLine("Pressione qualquer tecla para voltar às opções...");
                Console.ReadKey();
                ExecutarMaquina(m);
            }
        }
    }
}
