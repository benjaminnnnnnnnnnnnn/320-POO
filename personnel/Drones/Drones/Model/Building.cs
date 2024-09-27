using System.Drawing;

namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Building
    {

        protected int _x;                                 // Position en X depuis la gauche de l'espace aérien
        protected int _y;                                 // Position en Y depuis le haut de l'espace aérien
        protected int _death = 5;
        protected int _width = 5;
        private Color _color;


        // Constructeur
        public Building()
        {
            _x = GlobalHelpers.alea.Next(0, AirSpace.WIDTH);
            _y = GlobalHelpers.alea.Next(0, AirSpace.HEIGHT);
            _color = Color.Blue;
            _droneBrush = new Pen(new SolidBrush(_color), 3);

        }

        public int X { get { return _x; } }
        public int Y { get { return _y; } }
        public int Death { get { return _death; } }
        public int Width { get { return _width; } }

        protected Color Color
        {
            get => _color;
            set
            {
                _color = value;
                
            }
        }

        public void Show()
        {
            Console.WriteLine("posX : " + _x);
            Console.WriteLine("posY : " + _y);
            Console.WriteLine("Color : " + _color);
        }
    }

    public class Factory : Building
    {
        private float _PowerConsumption;
        private Color _color;



        public Factory()
        {
            _PowerConsumption = GlobalHelpers.alea.Next(0,100);
            _color = Color.Gray;

        }



        public void Show()
        {
            Console.WriteLine("posX : " + _x);
            Console.WriteLine("posY : " + _y);
            Console.WriteLine("Color : " + _color);
            Console.WriteLine("Power consumption : " + _PowerConsumption);
        }
    }

    public class Store : Building
    {
        private string _OpeningHours;
        private Color _color;
        



        public Store()
        {
            _OpeningHours = "24/7";
            _color = Color.Green;
        }

        public void Show()
        {
            Console.WriteLine("posX : " + _x);
            Console.WriteLine("posY : " + _y);
            Console.WriteLine("Color : " + _color);
            Console.WriteLine("Open hours : " + _OpeningHours);
        }
    }
}
