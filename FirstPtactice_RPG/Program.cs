using FirstPtactice_RPG.BL;
using FirstPtactice_RPG.Pl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPtactice_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            HeroService start = new HeroService();
            start.Start();
        }
    }
}
