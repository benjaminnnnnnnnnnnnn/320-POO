using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Dispatch : IDispatchable
    {
        public List<Box> dispatchbox = new List<Box> ();


        public void addbox(Box box)
        {
            dispatchbox.Add(box);            
            Console.WriteLine("box sent to dispatch");
        }


        public void removebox(Box box)
        {
            dispatchbox.Remove(box);
            Console.WriteLine("dispatch box remouved");
        }
    }
}
