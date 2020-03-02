using FirstPtactice_RPG.BL;

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
