
namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone : IExpellable
    {
        public static readonly int FULLCHARGE = 1000;   // Charge maximale de la batterie
        private int _charge;                            // La charge actuelle de la batterie
        private string _name;                           // Un nom
        private int _x;                                 // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien
        private EvacuationState _state;
        // Constructeur
        public Drone(int x, int y, string name)
        {
            _x = x;
            _y = y;
            _name = name;
            _charge = GlobalHelpers.alea.Next(FULLCHARGE); // La charge initiale de la batterie est choisie aléatoirement

        }

        public Drone(int x, int y)
        {
            _x = x;
            _y = y;
            _state = EvacuationState.Free;
        }

        public int X { get { return _x;} }
        public int Y { get { return _y;} }
        public string Name { get { return _name;} }



        public bool Evacuate(Rectangle zone)
        {
            if (zone.IntersectsWith(new Rectangle((X - 4), (Y - 2), 8, 8))) 
            {
                _state = EvacuationState.Evacuating;
                return false;
            }
            else
            {
                _state = EvacuationState.Evacuated;
                return true;
            }
        }
        
        public void FreeFlight()
        {
            _state = EvacuationState.Free;
        }

        public EvacuationState GetEvacuationState()
        {
            return _state;
        }

        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            _x += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            _y += GlobalHelpers.alea.Next(-2, 3);       // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            _charge--;                                  // Il a dépensé de l'énergie
        }

    }
}
