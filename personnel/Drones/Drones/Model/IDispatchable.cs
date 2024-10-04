using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public interface IDispatchable
    {
        public void addbox(Box box);

        public void removebox(Box box);
    }


}
