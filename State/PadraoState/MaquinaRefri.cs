using System;
using System.Collections.Generic;
using System.Text;

namespace State.PadraoState
{
    public class MaquinaRefri
    {
        public int Refris { get; set; } // Cada refri vale R$ 1,50
        public double Credito { get; set; } // Cada crédito está fixo em R$ 1,50
        public double SaldoTotal { get; set; }

        public EstadoMaquinaAb EstadoAtual { get; set; }

        public MaquinaRefri()
        {
            EstadoAtual = new SemRefri();
        }

        public MaquinaRefri(EstadoMaquinaAb estado)
        {
            EstadoAtual = estado;
        }

        public void AdicionarRefri(int quant)
        {
            Console.WriteLine($"Adicionando {quant} refris na máquina!");
            Refris += quant;
            VerificarMudarEstado(); // Vai para SemCredito
        }
         
        public void AdicionarCredito()
        {
            double cred = 1.5;
            Console.WriteLine($"Adicionando crédito de {cred}");
            Credito += cred;
            VerificarMudarEstado(); // Vai para ComCredito ou fica em SemCredito
        }

        public void SolicitarRefri()
        {
            Console.WriteLine($"Refrigerante foi solicitado!");
            VerificarMudarEstado(); // Vai para Venda
            Refris--;
            SaldoTotal += 1.5;
            Credito = 0;
            Console.WriteLine($"Analisando se a máquina ainda possui Refri...");
            VerificarMudarEstado(); // Vai para SemCredito ou SemRefri
        }

        public void VerificarMudarEstado()
        {
            EstadoAtual.MudarEstado(this);
        }

    }
}
