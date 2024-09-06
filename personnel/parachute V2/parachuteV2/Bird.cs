using exparachute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace parachuteV2
{
    internal class Bird
    {
        Random rnd = new Random();
        private int _x = 132;
        private int _y = 20;
        private string[] flyingbird =
        {
            @"                 ,",
            @" ,_     ,     .'<_",
            @"_> `'-,'(__.-' __<",
            @">_.--(.. )  =;`   ",
            @"     `V-'`'\/``   ",
        };



        public int Y
        {
            get { return _y; }
            set { if (_y > 0 && _y < Config.SCREEN_HEIGHT) { _y = value; } }
        }

        public int X 
        {
            get { return _x; }
            set { if (_x > 0 && _x < Config.SCREEN_WIDTH) { _x = value; } }
        }



        public void update()
        {
            X = X - 2;
        }


        public void draw()
        {

            foreach (string line in flyingbird)
            {
                if (X == 0)
                {
                    X = 132;
                    Y = rnd.Next(10, 30);
                }

                Console.SetCursorPosition(X, Y);
                Console.Write(line);




                Y++;
            }
            Y = Y - 5;



        }

    }
}
