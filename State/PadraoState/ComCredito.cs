using System;
using System.Collections.Generic;
using System.Text;

namespace State.PadraoState
{
    public class ComCredito : EstadoMaquinaAb
    {
        public ComCredito()
        {
            Console.WriteLine("Máquina com credito! Pressione qualquer tecla para pedir seu refri...");
            Console.ReadKey();
        }

        public override void MudarEstado(MaquinaRefri maq)
        {
            maq.EstadoAtual = new Venda();
        }
    }
}
