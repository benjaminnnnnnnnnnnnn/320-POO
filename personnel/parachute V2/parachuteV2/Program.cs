using System.Numerics;
using exparachute;
using parachuteV2;

namespace parachute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Parachute> parachutes = new List<Parachute>();

            Planes plane = new Planes();

            Bird bird = new Bird();


            Console.CursorVisible = false;

            Console.SetWindowSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT);

            int i = 0;

            bool running = true;
            while (running)
            {
                // Modifier le modèle (ce qui *est*)
                plane.update();
                foreach (Parachute parachute in parachutes)
                {



                    if (parachute.y != Config.SCREEN_HEIGHT - 7)
                    {
                        parachute.update();
                    }



                    if (parachute.x == 1)
                    {
                        parachute.bird = false;
                    }
                    else if (Math.Abs(parachute.x - bird.X) < 4 && Math.Abs(parachute.y - bird.Y) < 4)
                    {

                        parachute.bird = true;
                    }

                }


                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(intercept: true).Key;
                    switch (key)
                    {

                        case ConsoleKey.Escape:
                            running = false; // Exit loop if Esc is pressed
                            break;
                        case ConsoleKey.Spacebar:
                            parachutes.Add(new Parachute(i));

                            parachutes[i].x = plane.x + 12;
                            parachutes[i].y = 0;
                            parachutes[i].name = RandomName();
                            i++;
                            break;
                        case ConsoleKey.UpArrow:
                            bird.Y +=2;
                            break;
                        case ConsoleKey.DownArrow:
                            bird.Y -=2;
                            break;
                        case ConsoleKey.LeftArrow:
                            bird.X -=2;
                            break;
                        case ConsoleKey.RightArrow:
                            bird.X += 2;
                            break;

                    }




                }






                // Modifier ce que l'on *voit*
                Console.Clear();
                plane.draw();
                bird.draw();
                foreach (Parachute parachute in parachutes)
                {
                    parachute.draw();
                }



                // Temporiser
                Thread.Sleep(100);
            }

            static string RandomName()
            {
                Console.Title = "Pendu : randompassword";
                string line;
                int i = 0;

                StreamReader sr = new StreamReader("first-names.txt");
                string[] Names = new string[4946];

                line = sr.ReadLine();


                while (line != null)
                {
                    Names[i++] = line;

                    //Read the next line
                    line = sr.ReadLine();
                }

                Random rnd = new Random();

                string randomName = Names[rnd.Next(4946)];

                return randomName;
            }
        }
    }
}
