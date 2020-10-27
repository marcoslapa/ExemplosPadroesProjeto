using System;
using System.Collections.Generic;
using System.Text;

namespace State.PadraoState
{
    public class Venda : EstadoMaquinaAb
    {
        public Venda()
        {
            Console.WriteLine("Refrigerante sendo entregue... pressione qualquer tecla para pegar o produto!");
            Console.ReadKey();
        }

        public override void MudarEstado(MaquinaRefri maq)
        {   
            if(maq.Refris == 0)
            {
                maq.EstadoAtual = new SemRefri();
            }
            else
            {
                maq.EstadoAtual = new SemCredito();
            }
        }
    }
}
