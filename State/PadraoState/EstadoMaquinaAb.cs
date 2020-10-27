using System;
using System.Collections.Generic;
using System.Text;

namespace State.PadraoState
{
    public abstract class EstadoMaquinaAb
    {
        public abstract void MudarEstado(MaquinaRefri maq);
    }
}
