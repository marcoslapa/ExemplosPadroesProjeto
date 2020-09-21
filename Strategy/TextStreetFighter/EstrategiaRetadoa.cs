using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class EstrategiaRetadoa : IEstrategiaLuta
    {
        public void Lutar(LutadorAb l)
        {
            l.MandarChuteForte();
            l.Defender();
            l.MandarEsp1();
            l.MandarChuteFraco();
            l.Defender();
            l.MandarEsp2();
            l.MandarEsp1();
        }
    }
}
