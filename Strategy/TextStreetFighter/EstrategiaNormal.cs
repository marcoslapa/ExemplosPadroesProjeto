using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class EstrategiaNormal : IEstrategiaLuta
    {
        public void Lutar(LutadorAb l)
        {
            l.MandarChuteForte();
            l.MandarSocoFraco();
            l.Defender();
            l.MandarEsp1();
            l.MandarSocoForte();
            l.MandarEsp2();
        }
    }
}
