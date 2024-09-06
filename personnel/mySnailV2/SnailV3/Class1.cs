using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSnail
{
    internal class Snail
    {

        //atribut 

        public int vie = 50;             //vie du escargot
        public int x = 10;                //position
        public int y;                   //possition
        public string alive = "_@_ö";    //escargot vivant
        public string dead = "____";     //escargot mort
        public string name = "snail";
        public int originalvie = 50;

        //constructeur

        public Snail(int y)
        {
            this.y = y ;
        }

        //metode

        public void move()
        {
            alive = " " + alive;
            dead = " " + dead;
            vie--;
        }


    }
}
