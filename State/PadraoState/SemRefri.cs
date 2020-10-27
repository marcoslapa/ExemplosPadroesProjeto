using System;
using System.Collections.Generic;
using System.Text;

namespace State.PadraoState
{
    public class SemRefri : EstadoMaquinaAb
    {
        public SemRefri()
        {
            Console.WriteLine("Máquina não possui refri para vender! Adicione Refri!");
        }

        public override void MudarEstado(MaquinaRefri maq)
        {
            if(maq.Refris > 0)
            {
                maq.EstadoAtual = new SemCredito();
            }
        }
    }
}
