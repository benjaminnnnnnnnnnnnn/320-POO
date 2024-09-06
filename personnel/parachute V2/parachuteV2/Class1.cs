using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace exparachute
{
    static class Config
    {
        public const int SCREEN_HEIGHT = 40;
        public const int SCREEN_WIDTH = 150;
    }
    internal class Parachute
    {
        public int x = 0;
        public int y = 0;
        public string name;
        private string[] withoutParachute =
{
         @"     ",
         @"     ",
         @"     ",
         @"  o  ",
         @" /░\ ",
         @" / \ ",
        };
        private string[] withParachute =
        {
         @" ___ ",
         @"/|||\",
         @"\   /",
         @" \o/ ",
         @"  ░  ",
         @" / \ ",
        };

        //constructeur

        public Parachute(int y)
        {
            this.y = y;
        }


        //metode


        public void update()
        {
            y++;

            if (y < (Config.SCREEN_HEIGHT - 7) / 2)
            {
                y = y + 3;
            }
        }

        public void draw()
        {
            if (y < (Config.SCREEN_HEIGHT - 7 )/ 2)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(name);
                foreach (string line in withoutParachute)
                {
                    Console.SetCursorPosition(x, y+1);
                    Console.Write(line);




                    y++;
                }
            }
            else
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(name);
                foreach (string line in withParachute)
                {
                    Console.SetCursorPosition(x, y+1);
                    Console.Write(line);




                    y++;
                }
            }

            y = y - 6;

        }

    }
    internal class Planes
    {
        //atribut
        public int x = 0;
        public int y = 0;
        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };
        private string[] view2 =
{
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____     ",
            @"  \_______ --------- __> } ",
            @"        \_____|_____/      "
        };

        //constructeur




        //metode
        public void update()
        {
            x++;
        }

        public void draw()
        {
            if (x%2 == 0)
            {
                foreach (string line in view)
                {
                    if (x == 150) { x = 0; }

                    Console.SetCursorPosition(x, y);
                    Console.Write(line);




                    y++;
                }
                y = y - 6;
            }
            else
            {
                foreach (string line in view2)
                {
                    if (x == 150) { x = 0; }

                    Console.SetCursorPosition(x, y);
                    Console.Write(line);




                    y++;
                }
                y = y - 6;
            }


        }


    }

}
