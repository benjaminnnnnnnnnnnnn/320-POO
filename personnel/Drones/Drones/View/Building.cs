using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Building
    {
        private Pen _droneBrush;

        // De manière graphique
        public void Render(BufferedGraphics drawingSpace, bool isround)
        {



            if (isround )
            {
                drawingSpace.Graphics.DrawEllipse(_droneBrush, new Rectangle(X, Y, Death, Width));
            }
            else
                drawingSpace.Graphics.DrawRectangle(_droneBrush, new Rectangle(X, Y, Death, Width));


        }




    }
}
