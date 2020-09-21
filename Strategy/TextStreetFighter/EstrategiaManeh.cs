using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class EstrategiaManeh : IEstrategiaLuta
    {
        public void Lutar(LutadorAb l)
        {
            l.Defender();
            l.MandarChuteFraco();
            l.Defender();
            l.MandarSocoFraco();
            l.Defender();
            l.Defender();
            l.MandarSocoForte();
        }
    }
}
