using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Box
    {
        private int _id;
        private int _kilos;
        private string _color;

        public Box(int id) 
        { 
            _id = id;
            _kilos = GlobalHelpers.alea.Next(5,10);
            _color = "red";
        }

    }
}
