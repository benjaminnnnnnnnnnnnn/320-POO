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


        public void addbox(List<Box> boxes)
        {
            dispatchbox.Add(boxes[0]);
            boxes.Remove(boxes[0]);
            Console.WriteLine("box sent to dispatch");
        }


        public void removebox()
        {
            dispatchbox.Remove(dispatchbox[0]);
            Console.WriteLine("dispatch box remouved");
        }
    }
}
