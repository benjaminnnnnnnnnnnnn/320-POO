using System.Numerics;
using parachute;

namespace parachute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane();
            Config.SCREEN_HEIGHT;

            while (true)
            {
                // Modifier le modèle (ce qui *est*)
                plane.update();
                

                 // Modifier ce que l'on *voit*
                Console.Clear();
                plane.draw();

                // Temporiser
                Thread.Sleep(100);
            }
        }
    }
}
