using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class EstrategiaViradoNaDesgraca : IEstrategiaLuta
    {
        public void Lutar(LutadorAb l)
        {
            l.MandarEsp1();
            l.MandarEsp2();
            l.MandarChuteForte();
            l.MandarEsp1();
            l.MandarSocoForte();
            l.MandarEsp2();
        }
    }
}
