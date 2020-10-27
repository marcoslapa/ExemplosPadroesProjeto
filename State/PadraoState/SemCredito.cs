using System;
using System.Collections.Generic;
using System.Text;

namespace State.PadraoState
{
    public class SemCredito : EstadoMaquinaAb
    {
        public SemCredito()
        {
            Console.WriteLine("Máquina está sem crédito! Adicione Crédito!");
        }


        public override void MudarEstado(MaquinaRefri maq)
        {
            Console.WriteLine($"Máquina possui agora um crédito de {maq.Credito}!");

            if (maq.Credito >= 1.5)
            {
                maq.EstadoAtual = new ComCredito();
            }
            else
            {
                Console.WriteLine("Esse crédito não é suficiente para comprar refri! Adicione mais crédito!");
            }
        }
    }
}
